// <copyright file="Form1.cs" company="codeguys.dk">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------

/// <summary>
/// Validates if there are any workspaces, no execution.
/// </summary>
namespace DosBoxLauncher
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Configuration;
    using System.Data;
    using System.Diagnostics;
    using System.Drawing;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;
    using System.Windows.Forms.VisualStyles;
    using DosBoxLauncher.Functions;
    using DosBoxLauncher.Functions.UI;
    using DosBoxLauncher.Models;

    /// <summary>
    /// Launcher summary
    /// </summary>
    public partial class FrmLauncher : Form
    {
        private LauncherConfiguration config = new LauncherConfiguration();
        private DataTable wsTable = new DataTable();

        private string configXML;

        public FrmLauncher()
        {
            this.InitializeComponent();

            this.configXML = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\DOSBoxLauncher\UserConfiguration.xml";
            this.config = Functions.UserConfiguration.LoadConfiguration(this.configXML);

            this.dataGridView1 = Helpers.FormatGridColumns(this.dataGridView1);
            DataColumn autoNumber = new DataColumn();
            autoNumber.ColumnName = "Index";
            autoNumber.DataType = typeof(int);
            autoNumber.AutoIncrement = true;
            autoNumber.AutoIncrementSeed = 1;
            autoNumber.AutoIncrementStep = 1;
            this.wsTable.Columns.Add(autoNumber);
            this.wsTable.Columns.Add("Define", typeof(string));
            this.wsTable.Columns.Add("Delete", typeof(string));
            this.wsTable.Columns.Add("Path", typeof(string));
            this.wsTable.Columns.Add("Order", typeof(string));
            this.wsTable.Columns.Add("Title", typeof(string));
            this.wsTable.Columns.Add("Valid", typeof(string));
            this.wsTable.Columns.Add("Browse", typeof(string));
            this.wsTable.Columns.Add("ZipManager", typeof(string));
            var queryWorkspaces =
                from ws
                in this.config.Workspaces
                orderby ws.Index
                select ws;
            foreach (Models.Workspace ws in queryWorkspaces)
            {
                this.wsTable.Rows.Add(
                    null,
                    "Update",
                    "Delete",
                    ws.Path,
                    ws.Index,
                    ws.Title,
                    string.Empty,
                    "Files",
                    "Manager");
            }

            this.wsTable.Rows.Add(
                    null,
                    "New",
                    string.Empty,
                    string.Empty,
                    string.Empty,
                    string.Empty,
                    string.Empty,
                    string.Empty,
                    string.Empty);

            this.dataGridView1.DataSource = this.wsTable;

            this.SetUiControlsFromConfig();

            this.cbLauncherWorspaceSelector.Text = "Vælg mappe";
            this.cbLauncherWorspaceSelector = Helpers.PopulateComboLauncher(this.cbLauncherWorspaceSelector, this.config);
            this.WriteLogEntry("Launcher startup...");

            this.DisplayVersion();
        }

        /// <summary>
        /// Handles the Click event of the button1 control.
        /// Checks the name of the selected with name in list, when equal calls next operation.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void BtnStartPCPlus_Click(object sender, EventArgs e)
        {
            bool fullscreenMode = this.checkBox1.Checked;

            Models.Workspace ws = (Models.Workspace)cbLauncherWorspaceSelector.SelectedItem;

            if (ws != null)
            {
                this.ChangeDosBoxConfiguration(ws.Path, fullscreenMode);

                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.FileName = this.config.DosBoxExecutable;

                Process.Start(startInfo);
            }
            else
            {
                this.ShowValidationMessage("Define one or more workspaces, and try again", EventLogEntryType.FailureAudit);
                this.lblMessage.BackColor = Color.Orange;
                this.lblMessage.ForeColor = Color.White;
            }
        }

        /// <summary>
        /// Writes in the lower part of the file <code>dosbox</code> configuration file
        /// last line will be [autoexec]
        /// Inserting dos commands in this file, and then execute with the changed configuration file
        /// makes it possible to abstract users knowledge of the mount command
        /// though it is not that difficult:
        /// <code>mount c c:\documents</code>
        /// Do not root large drives!!!!!!!!!!!
        /// </summary>
        /// <param name="pathName">The <code>mountdrive</code>. Path to be mounted inside <code>dosbox</code></param>
        /// <param name="fullscreenMode">if set to <c>true</c> <code>fullscreen</code>.</param>
        /// TODO: Errors: pcplus.com not present on system
        /// causes: erraneous configuration, mount command failure, all kinds of things in <code>dosbox</code>.
        private void ChangeDosBoxConfiguration(string pathName, bool fullscreenMode)
        {
            bool autoexecReached = false;
            string tempFile = Path.GetTempFileName();
            string command;
            using (var sr = new StreamReader(this.config.DosBoxConfigFile))
            {
                using (var sw = new StreamWriter(tempFile))
                {
                    string line;
                    string fullscreenSetting = "fullscreen=";

                    while (((line = sr.ReadLine()) != null) && (autoexecReached != true))
                    {
                        if (line.Length > 11)
                        {
                            string tester = line.Substring(0, 11);
                            if (tester == fullscreenSetting)
                            {
                                line = string.Format("fullscreen={0}", fullscreenMode);
                            }
                        }

                        if (line == "[autoexec]")
                        {
                            autoexecReached = true;
                        }

                        sw.WriteLine(line);
                    }

                    command = string.Format("mount c {0}", pathName);
                    sw.WriteLine(command);
                    command = "c:";
                    sw.WriteLine(command);
                    //// command = string.Format("cd {0}", pathName);
                    //// sw.WriteLine(command);
                    command = "pcplus.com";
                    sw.WriteLine(command);
                }
            }

            File.Delete(this.config.DosBoxConfigFile);
            File.Move(tempFile, this.config.DosBoxConfigFile);
        }

        private void ShowCriticalError(string message)
        {
            MessageBox.Show(
                    message,
                    "Critical Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation,
                    MessageBoxDefaultButton.Button1);
        }

        /// <summary>
        /// Writes the log entry available on the configuration tab.
        /// </summary>
        /// <param name="logEntry">The log entry.</param>
        private void WriteLogEntry(string logEntry)
        {
            this.tbLogEntries.AppendText(string.Format(
                "{0}: {1}{2}",
                TimeStamp.GetTimeStamp(),
                logEntry,
                Environment.NewLine));
        }

        private void ShowValidationMessage(string message)
        {
            this.ShowValidationMessage(message, EventLogEntryType.Information);
        }

        private void ShowValidationMessage(string message, EventLogEntryType type)
        {
            this.lblMessage.Text = message;

            switch (type)
            {
                case EventLogEntryType.Error:
                    this.lblMessage.BackColor = Color.Red;
                    this.lblMessage.ForeColor = Color.White;
                    break;
                case EventLogEntryType.FailureAudit:
                    this.lblMessage.BackColor = Color.Red;
                    this.lblMessage.ForeColor = Color.White;
                    break;
                case EventLogEntryType.Warning:
                    this.lblMessage.BackColor = Color.Orange;
                    this.lblMessage.ForeColor = Color.White;
                    break;
                case EventLogEntryType.SuccessAudit:
                    this.lblMessage.BackColor = Color.Green;
                    this.lblMessage.ForeColor = Color.White;
                    break;
                default:
                    this.lblMessage.BackColor = Color.White;
                    this.lblMessage.ForeColor = Color.Black;
                    break;
                //// case EventLogEntryType.Information:
            }
        }

        private void DisplayVersion()
        {
            string version = string.Format(
                "PCPlus-DOSBoxLauncher - version: {0} - ®codeguys.dk",
                ((System.Reflection.AssemblyFileVersionAttribute)System.Reflection.Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(System.Reflection.AssemblyFileVersionAttribute), false)[0]).Version);
            this.Text = version;
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            int rowindex = e.RowIndex;
            Validation.ErrorType rowValid;

            if (this.dataGridView1.Columns[e.ColumnIndex].Name == "Valid")
            {
                if ((string)dataGridView1.Rows[rowindex].Cells["Define"].Value != "New")
                {
                    rowValid = Validation.IsRowValid(
                    (string)dataGridView1.Rows[rowindex].Cells["Path"].Value,
                    (string)dataGridView1.Rows[rowindex].Cells["Order"].Value,
                    (string)dataGridView1.Rows[rowindex].Cells["Title"].Value);
                    if (rowValid != Validation.ErrorType.Valid)
                    {
                        e.CellStyle.BackColor = Color.Red;
                    }
                    else
                    {
                        e.CellStyle.BackColor = Color.Green;
                    }
                }
            }

            if (this.dataGridView1.Columns[e.ColumnIndex].Name == "Browse")
            {
                if ((string)dataGridView1.Rows[rowindex].Cells["Define"].Value != "New")
                {
                    rowValid = Validation.IsRowValid(
                     (string)dataGridView1.Rows[rowindex].Cells["Path"].Value,
                     (string)dataGridView1.Rows[rowindex].Cells["Order"].Value,
                     (string)dataGridView1.Rows[rowindex].Cells["Title"].Value);
                    if (rowValid != Validation.ErrorType.Valid)
                    {
                       e.Value = string.Empty;
                    }
                }
            }

            if (this.dataGridView1.Columns[e.ColumnIndex].Name == "ZipManager")
            {
                if ((string)dataGridView1.Rows[rowindex].Cells["Define"].Value != "New")
                {
                    rowValid = Validation.IsRowValid(
                    (string)dataGridView1.Rows[rowindex].Cells["Path"].Value,
                    (string)dataGridView1.Rows[rowindex].Cells["Order"].Value,
                    (string)dataGridView1.Rows[rowindex].Cells["Title"].Value);
                    if (rowValid != Validation.ErrorType.Valid)
                    {
                        e.Value = string.Empty;
                    }
                }
            }
        }

        /// <summary>
        /// Handles the CellContentClick event of the dataGridView1 control.
        /// Depending on the text inside the cell, the proper function is called
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="DataGridViewCellEventArgs"/> instance containing the event data.</param>
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowindex = e.RowIndex;

            switch ((string)dataGridView1.CurrentCell.Value)
            {
                case "New":
                    FrmWorkspace frmNew = new FrmWorkspace(dataGridView1.CurrentRow, this.tbWorkspaceRootPath.Text, "New");
                    frmNew.ShowDialog();
                    if (frmNew.ReturnCode == Validation.ErrorType.Valid)
                    {
                        this.WorkspaceInsert(
                            frmNew.NewPath, 
                            frmNew.NewTitle, 
                            Convert.ToInt16(frmNew.NewOrder), 
                            false);
                        this.SaveConfiguration();
                    }

                    this.ShowValidationMessage("New workspace defined", EventLogEntryType.SuccessAudit);
                    this.WriteLogEntry(string.Format("New workspace defined: Path:{0} Title:{1}", frmNew.NewPath, frmNew.NewTitle));
                    break;
                case "Update":
                    FrmWorkspace frmUpdate = new FrmWorkspace(dataGridView1.CurrentRow, this.tbWorkspaceRootPath.Text, "Update");
                    frmUpdate.ShowDialog();
                    if (frmUpdate.ReturnCode == Validation.ErrorType.Valid)
                    {
                        this.WorkspaceUpdate(
                            frmUpdate.Index,
                            frmUpdate.OldPath, 
                            frmUpdate.OldTitle, 
                            Convert.ToInt16(frmUpdate.OldOrder), 
                            frmUpdate.NewPath, 
                            frmUpdate.NewTitle, 
                            Convert.ToInt16(frmUpdate.NewOrder));
                        this.SaveConfiguration();
                    }

                    this.ShowValidationMessage("Workspace updated", EventLogEntryType.SuccessAudit);
                    this.WriteLogEntry(string.Format("Workspace updated: Path:{0} Title:{1}", frmUpdate.NewPath, frmUpdate.NewTitle));
                    break;
                case "Delete":
                    var confirmResult = MessageBox.Show(
                        "Are you sure to delete the item?",
                        "Confirm Delete!!",
                        MessageBoxButtons.YesNo);
                    if (confirmResult == DialogResult.Yes)
                    {
                        string oldPath = (string)dataGridView1.CurrentRow.Cells["Path"].Value;
                        string oldTitle = (string)dataGridView1.CurrentRow.Cells["Title"].Value;
                        int oldOrder = Convert.ToInt16((string)dataGridView1.CurrentRow.Cells["Order"].Value);
                        int index = (int)dataGridView1.CurrentRow.Cells["Index"].Value;
                        this.WorkspaceDelete(
                            index,
                            oldPath,
                            oldTitle,
                            oldOrder,
                            false);
                        this.SaveConfiguration();
                        this.ShowValidationMessage("Workspace deleted", EventLogEntryType.SuccessAudit);
                        this.WriteLogEntry(string.Format("Workspace deleted: Path:{0} Title:{1}", oldPath, oldTitle));
                    }
                    else
                    {
                        this.ShowValidationMessage("user cancelled", EventLogEntryType.Warning);
                    }

                    break;
                case "Manager":
                    FrmZipFileManager frm = new FrmZipFileManager(dataGridView1.Rows[e.RowIndex].Cells["Path"].Value.ToString());
                    frm.ShowDialog();
                    break;
                case "Files":
                    External.StartExplorer(dataGridView1.Rows[e.RowIndex].Cells["Path"].Value.ToString());
                    break;
                
                default:
                    break;
            }
        }

        /// <summary>
        /// Calls save the configuration.
        /// Also updates ui elements telleing the user when the configurtion was saved last time
        /// Also updates the combo launcher, and adjust it to the present list of workspaces
        /// </summary>
        private void SaveConfiguration()
        {
            string timestamp;
            try
            {
                timestamp = Convert.ToString(UserConfiguration.SaveConfiguration(this.config, this.configXML));
                this.lblConfigurationLastUpdateLauncher.Text = timestamp;
                this.lblConfigurationLastUpdateConfig.Text = timestamp;
                this.cbLauncherWorspaceSelector = Helpers.PopulateComboLauncher(this.cbLauncherWorspaceSelector, this.config);
            }
            catch (Exception ex)
            {
                this.ShowCriticalError(string.Format("Unable to save configuration. Somehow the configuration cannot be saved here:\n{0}\n{1}", this.configXML, ex.ToString()));
            }
        }

        private void WorkspaceUpdate(int index, string oldPath, string oldTitle, int oldOrder, string newPath, string newTitle, int newOrder)
        {
            this.WorkspaceDelete(index, oldPath, oldTitle, oldOrder, true);
            this.WorkspaceInsert(newPath, newTitle, newOrder, true);

            DataRow[] dtRow = this.wsTable.Select("Index = " + index);
            dtRow[0]["Define"] = "Update";
            dtRow[0]["Path"] = newPath;
            dtRow[0]["Order"] = newOrder;
            dtRow[0]["Title"] = newTitle;
            dtRow[0]["Valid"] = string.Empty;
            dtRow[0]["Delete"] = "Delete";
            dtRow[0]["Browse"] = "Files";
            dtRow[0]["ZipManager"] = "Manager";
        }

        private void WorkspaceDelete(int index, string oldPath, string oldTitle, int oldOrder, bool updateSub)
        {
            var queryWorkspaces =
                from ws
                in this.config.Workspaces
                orderby ws.Index
                select ws;
            foreach (Models.Workspace ws in queryWorkspaces)
            {
                if (ws.Path == oldPath && ws.Title == oldTitle && ws.Index == oldOrder)
                {
                    this.config.Workspaces.Remove(ws);

                    if (!updateSub)
                    {
                        DataRow[] dtRow = this.wsTable.Select("Index = " + index);
                        dtRow[0].Delete();
                    }

                    return;
                }
            }
        }

        private void WorkspaceInsert(string path, string title, int order, bool updateSub)
        {
            Models.Workspace ws = new Models.Workspace();
            ws.Path = path;
            ws.Title = title;
            ws.Index = order;
            this.config.Workspaces.Add(ws);

            if (!updateSub)
            {
                DataRow dtRow = this.wsTable.NewRow();
                dtRow["Define"] = "Update";
                dtRow["Path"] = path;
                dtRow["Order"] = order;
                dtRow["Title"] = title;
                dtRow["Valid"] = string.Empty;
                dtRow["Delete"] = "Delete";
                dtRow["Browse"] = "Files";
                dtRow["ZipManager"] = "Manager";
                this.wsTable.Rows.InsertAt(dtRow, 0);
            }
        }

        /// <summary>
        /// Sets the label text boxes.
        /// Sets the valid color of files and directories
        /// </summary>
        /// <remarks>
        /// Pre: Read configfile into global variable
        /// </remarks>
        private void SetUiControlsFromConfig()
        {
            bool notify = false;

            this.tbWorkspaceRootPath.Text = this.config.WorkspaceRootFolder;
            #region tbWorkspaceRootPath Validation
            Validation.ErrorType valid = Validation.IsPcPlusFolderValid(this.config.WorkspaceRootFolder);
            if (valid != Validation.ErrorType.Valid)
            {
                this.tbWorkspaceRootPathValid.BackColor = Color.Red;
                this.WriteLogEntry("The Workspace root folder does not exist.");
                notify = true;
            }
            else
            {
                this.tbWorkspaceRootPathValid.BackColor = Color.Green;
            }
            #endregion

            this.tbDOSBoxExe.Text = this.config.DosBoxExecutable;
            #region tbDOSBoxExe Validation
            valid = Validation.IsDosBoxExeValid(this.config.DosBoxExecutable);
            if (valid != Validation.ErrorType.Valid)
            {
                this.tbDOSBoxExeValid.BackColor = Color.Red;
                this.WriteLogEntry("The DosBox.exe file is not valid.");
                notify = true;
            }
            else
            {
                this.tbDOSBoxExeValid.BackColor = Color.Green;
            }
            #endregion

            this.tbDOSBoxConfig.Text = this.config.DosBoxConfigFile;
            #region tbDOSBoxConfig Validation
            valid = Validation.IsDosBoxConfigValid(this.config.DosBoxConfigFile);
            if (valid != Validation.ErrorType.Valid)
            {
                this.tbDOSBoxConfigValid.BackColor = Color.Red;
                this.WriteLogEntry(string.Format("The DOSBox configfile needs to be writable."));
                notify = true;
            }
            else
            {
                this.tbDOSBoxConfigValid.BackColor = Color.Green;
            }
            #endregion

            if (notify == true)
            {
                this.ShowValidationMessage("The configuration has errors. Check the log entries for more information...", EventLogEntryType.FailureAudit);
            }

            this.lblConfigurationCreatedConfig.Text = Convert.ToString(this.config.DateCreated);
            this.lblConfigurationCreatedLauncher.Text = Convert.ToString(this.config.DateCreated);
            this.lblConfigurationLastUpdateConfig.Text = Convert.ToString(this.config.DateUpdated);
            this.lblConfigurationLastUpdateLauncher.Text = Convert.ToString(this.config.DateUpdated);

            this.cbShowWorkspaces.Checked = (bool)Convert.ToBoolean(this.config.ShowConfigurationWorkspace);
            if (this.cbShowWorkspaces.Checked)
            {
                this.panelWorkspaces.Visible = true;
            }
            else
            {
                this.panelWorkspaces.Visible = false;
            }

            this.cbShowDosBoxConfig.Checked = (bool)Convert.ToBoolean(this.config.ShowConfigurationDosBox);
            if (this.cbShowDosBoxConfig.Checked)
            {
                this.panelDosBoxConfig.Visible = true;
            }
            else
            {
                this.panelDosBoxConfig.Visible = false;
            }

            this.lblInfoLauncher.Text = "Start PCPlus i den valgte mappe. Vælg mappe og om du vil starte i full screen, tryk derefter knappen'Start PCPlus'";
            this.lblInfoWorkspaceRootFolder.Text = "Brug knappen til at søge efter din rodmappe hvor du gemmer dine PCPlus filer";
            this.lblInfoDosBoxExeConfig.Text = "Når først konfigurationen er gjort, har du normalt ikke brug for at opdatere disse konfigurationer";
            this.lblInfoShowDosBoxConfiguration.Text = "Her udpeger du DOSBox filer";
            this.lblInfoShowWorkspaces.Text = "Her definerer du dine PCPlus filmapper";
        }

        private void cbShowDosBoxConfig_CheckedChanged(object sender, EventArgs e)
        {
            switch (this.cbShowDosBoxConfig.CheckState)
            {
                case CheckState.Checked:
                    this.panelDosBoxConfig.Visible = true;
                    this.config.ShowConfigurationDosBox = true;
                    goto default;
                case CheckState.Unchecked:
                    this.config.ShowConfigurationDosBox = false;
                    panelDosBoxConfig.Visible = false;
                    goto default;
                case CheckState.Indeterminate:
                    // Code for indeterminate state.
                    goto default;
                default:
                    this.SaveConfiguration();
                    break;
            }
        }

        private void cbShowWorkspaces_CheckedChanged(object sender, EventArgs e)
        {
            switch (this.cbShowWorkspaces.CheckState)
            {
                case CheckState.Checked:
                    this.config.ShowConfigurationWorkspace = true;
                    this.panelWorkspaces.Visible = true;
                    goto default;
                case CheckState.Unchecked:
                    this.config.ShowConfigurationWorkspace = false;
                    this.panelWorkspaces.Visible = false;
                    goto default;
                case CheckState.Indeterminate:
                    // Code for indeterminate state.
                    goto default;
                default:
                    this.SaveConfiguration();
                    break;
            }
        }

        private void cbShowWorkspaces_Click(object sender, EventArgs e)
        {
            switch (cbShowWorkspaces.CheckState)
            {
                case CheckState.Checked:
                    panelWorkspaces.Visible = true;
                    break;
                case CheckState.Unchecked:
                    panelWorkspaces.Visible = false;
                    break;
                case CheckState.Indeterminate:
                    // Code for indeterminate state.
                    break;
            }
        }

        private void BtnWorkspaceRootFolderSearch_Click(object sender, EventArgs e)
        {
            string defaultValue = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string currentValue = this.tbWorkspaceRootPath.Text;
            string newValue = string.Empty;
            string filter = string.Empty;

            this.BtnSearch(defaultValue, currentValue, newValue, filter, Validation.ValidationType.WorkspaceRoot);
        }

        private void BtnDosBoxConfigSearch_Click(object sender, EventArgs e)
        {
            string defaultValue = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\DOSBox\";
            string currentValue = this.tbDOSBoxConfig.Text;
            string newValue = null;
            string filter = "dosbox.conf files (dosbox-*.conf)|dosbox-*.conf|config files (*.conf)|*.conf|All files (*.*)|*.*";

            this.BtnSearch(defaultValue, currentValue, newValue, filter, Validation.ValidationType.DosBoxConfig);
        }

        private void BtnDosBoxExeSearch_Click(object sender, EventArgs e)
        {
            string defaultValue = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86) + @"\DOSBox\";
            string currentValue = this.tbDOSBoxExe.Text;
            string newValue = string.Empty;
            string filter = "DOSBox.exe file (DOSBox.exe)|DOSBox.exe|Exe files (*.exe)|*.exe|All files (*.*)|*.*";

            this.BtnSearch(defaultValue, currentValue, newValue, filter, Validation.ValidationType.DosBoxExe);
        }

        /// <summary>
        /// common validation caller for all file and folder searches
        /// </summary>
        /// <param name="defaultValue">The default value.</param>
        /// <param name="currentValue">The current value.</param>
        /// <param name="newValue">The new value.</param>
        /// <param name="filter">The filter.</param>
        /// <param name="type">The type.</param>
        private void BtnSearch(string defaultValue, string currentValue, string newValue, string filter, Validation.ValidationType type)
        {
            this.ShowValidationMessage("Waiting...");

            int validated = 0;
            string logEntry = string.Empty;
            #region Workspace root
            if (type == Validation.ValidationType.WorkspaceRoot)
            {
                if (Helpers.OpenFolderBrowserDialogSetDefault(currentValue, defaultValue, out newValue, filter))
                {
                    this.config.WorkspaceRootFolder = newValue;
                    this.tbWorkspaceRootPath.Text = newValue;
                    Validation.ErrorType valid = Validation.IsPcPlusFolderValid(newValue);
                    if (valid != Validation.ErrorType.Valid)
                    {
                        validated = -1;
                        this.tbWorkspaceRootPathValid.BackColor = Color.Red;
                        logEntry = "The Workspace root folder does not exist. Use the search button and point out the rootfolder of you workspace(s)";
                    }
                    else
                    {
                        validated = 1;
                        this.tbWorkspaceRootPathValid.BackColor = Color.Green;
                        this.lblConfigurationLastUpdateLauncher.Text = Convert.ToString(UserConfiguration.SaveConfiguration(this.config, this.configXML));
                        logEntry = "Configuration saved - Workspace root updated";
                    }
                }
            }
            #endregion
            #region DosBoxExe 
            if (type == Validation.ValidationType.DosBoxExe)
            {
                if (Helpers.OpenFileDialogSetDefault(currentValue, defaultValue, out newValue, filter))
                {
                    this.config.DosBoxExecutable = newValue;
                    this.tbDOSBoxExe.Text = newValue;
                    Validation.ErrorType valid = Validation.IsDosBoxExeValid(newValue);
                    if (valid != Validation.ErrorType.Valid)
                    {
                        validated = -1;
                        this.tbDOSBoxExeValid.BackColor = Color.Red;
                        logEntry = "No DosBox.exe found. Have you installed DOSBox? Where did it install? DosBox version has changed?";
                    }
                    else
                    {
                        validated = 1;
                        this.tbDOSBoxExeValid.BackColor = Color.Green;
                        logEntry = "Configuration saved - DosBox.exe updated";
                    }
                }
            }
            #endregion

            if (type == Validation.ValidationType.DosBoxConfig)
            {
                if (Helpers.OpenFileDialogSetDefault(currentValue, defaultValue, out newValue, filter))
                {
                    this.config.DosBoxConfigFile = newValue;
                    this.tbDOSBoxConfig.Text = newValue;
                    Validation.ErrorType valid = Validation.IsDosBoxConfigValid(newValue);
                    if (valid != Validation.ErrorType.Valid)
                    {
                        this.tbDOSBoxConfigValid.BackColor = Color.Red;
                        logEntry = "No DosBox.config found.";
                    }
                    else
                    {
                        validated = 1;
                        this.tbDOSBoxConfigValid.BackColor = Color.Green;
                        logEntry = "Configuration saved - DosBox.config updated";
                    }
                }
            }

            if (validated == 1)
            {
                this.lblConfigurationLastUpdateLauncher.Text = Convert.ToString(UserConfiguration.SaveConfiguration(this.config, this.configXML));
                this.ShowValidationMessage("Entry updated", EventLogEntryType.SuccessAudit);
                this.WriteLogEntry(string.Format("Entry updated to {0}", newValue));
            }
            else if (validated == -1)
            {
                this.ShowValidationMessage("The configuration has errors. Check the log entries for more information...", EventLogEntryType.FailureAudit);
            }
            else
            {
                this.ShowValidationMessage("No change");
            }
        }

        private void BtnReadMe_Click(object sender, EventArgs e)
        {
            string filename = string.Format(
                "{0}{1}{2}",
                Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86),
                @"\CodeGuys\PCPlus DOSBoxLauncher\",
                @"PcPlus DosBox Launcher - ReadMe.pdf");
            this.ShowHelpFile(filename);
        }

        private void BtnUserManual_Click(object sender, EventArgs e)
        {
            string filename = string.Format(
                "{0}{1}{2}",
                Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86),
                @"\CodeGuys\PCPlus DOSBoxLauncher\",
                @"PcPlus DosBox Launcher - Brugervejledning.pdf");
            this.ShowHelpFile(filename);
        }

        private void BtnBasicConfiguration_Click(object sender, EventArgs e)
        {
            string filename = string.Format(
                "{0}{1}{2}",
                 Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86),
                 @"\CodeGuys\PCPlus DOSBoxLauncher\",
                 @"PcPlus DosBox Launcher - Brugervejledning.pdf");
            this.ShowHelpFile(filename);
        }

        private void BtnSystemSetup_Click(object sender, EventArgs e)
        {
            string filename = string.Format(
                "{0}{1}{2}",
                Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86),
                @"\CodeGuys\PCPlus DOSBoxLauncher\",
                @"PcPlus DosBox Launcher - SystemSetup.pdf");
            this.ShowHelpFile(filename);
        }

        private void ShowHelpFile(string filename)
        {
            try
            {
                Functions.External.StartExplorer(filename);
            }
            catch (Exception e)
            {
                this.ShowCriticalError(string.Format("An error occured trying to read the helpfile '{0}' {1}", filename, e));
            }
        }
    }
}