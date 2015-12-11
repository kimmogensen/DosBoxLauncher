/// <summary>
/// Filemanger Form file
/// </summary>
namespace DosBoxLauncher
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.IO;
    using System.IO.Compression;
    using System.Linq;
    using System.Text;
    using System.Text.RegularExpressions;
    using System.Threading.Tasks;
    using System.Windows.Forms;
    using DosBoxLauncher.Functions;

    /// <summary>
    /// Filemanager Form
    /// </summary>
    public partial class FrmZipFileManager : Form
    {
        private static string workspacePath;

        public FrmZipFileManager(string pcPlusPath)
        {
            this.InitializeComponent();

            workspacePath = pcPlusPath;
            this.linkLabelPcPlusFolder.Text = workspacePath;

            DataGridViewTextBoxColumn pcPlusName = new DataGridViewTextBoxColumn();
            pcPlusName.HeaderText = "Kunde";
            pcPlusName.Name = "PcPlusName";
            pcPlusName.Width = 70;
            DataGridViewTextBoxColumn countFiles = new DataGridViewTextBoxColumn();
            countFiles.HeaderText = "Antal Filer";
            countFiles.Name = "countFiles";
            countFiles.Width = 70;
            DataGridViewTextBoxColumn lastUpdate = new DataGridViewTextBoxColumn();
            lastUpdate.HeaderText = "Opdateret";
            lastUpdate.Name = "LastUpdate";
            lastUpdate.Width = 120;
            DataGridViewLinkColumn zipThis = new DataGridViewLinkColumn();
            zipThis.DataPropertyName = "ZipThis";
            zipThis.Name = "ZipThis";
            this.dataGridView1.Columns.Add(pcPlusName);
            this.dataGridView1.Columns.Add(countFiles);
            this.dataGridView1.Columns.Add(lastUpdate);
            this.dataGridView1.Columns.Add(zipThis);
            this.UpdateGridView();
        }

        private void UpdateGridView()
        {
            System.IO.DirectoryInfo dir = new System.IO.DirectoryInfo(workspacePath);
            IEnumerable<System.IO.FileInfo> fileList = dir.GetFiles("*.*", System.IO.SearchOption.TopDirectoryOnly);
            Regex regex = new Regex(Functions.RegExExpressions.GetPcPlusFilesRegEx());
            var queryMatchingFiles =
                from file in fileList.AsEnumerable()
                where regex.IsMatch(file.Name)
                group file by file.Name.Split('.')[0]
                    into pcPlusGroup
                    select new
                    {
                        GroupName = pcPlusGroup.Select(s => Path.GetFileName(s.FullName)
                                                                            .Substring(0, 8)
                                                                            .Substring(0, 8))
                                                                            .OrderBy(t => t)
                                                                            .Distinct()
                                                                            .FirstOrDefault(),
                        MaxDate = pcPlusGroup.Select(x => x.LastWriteTime).OrderByDescending(d => d).FirstOrDefault(),
                        Count = pcPlusGroup.Count()
                    };

            // Execute the query.
            foreach (var filename in queryMatchingFiles)
            {
                DataGridViewRow row = (DataGridViewRow)dataGridView1.Rows[0].Clone();
                row.Cells[0].Value = filename.GroupName;
                row.Cells[1].Value = filename.Count;
                row.Cells[2].Value = filename.MaxDate;
                if (filename.Count == 9)
                {
                    DataGridViewLinkCell zipCell = new DataGridViewLinkCell();
                    zipCell.Value = row.Cells[0].Value + ".zip";
                    row.Cells[3] = zipCell;
                }
                else
                {
                    row.Cells[3].Style.BackColor = System.Drawing.Color.Red;
                }

                this.dataGridView1.Rows.Add(row);
            }

            this.dataGridView1.AllowUserToAddRows = false;
        }

        private void linkLabelPcPlusFolder_MouseClick(object sender, MouseEventArgs e)
        {
            External.StartExplorer(this.linkLabelPcPlusFolder.Text.ToString());
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string groupName;
            DateTime dt;

            if ((e.RowIndex > -1) && (e.ColumnIndex > -1))
            {
                groupName = dataGridView1.Rows[e.RowIndex].Cells["PcPlusName"].Value.ToString();
                dt = Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells["LastUpdate"].Value.ToString());
                switch (e.ColumnIndex)
                {
                    case 3:
                        if (this.CreateZip(ref groupName, dt))
                        {
                             MessageBox.Show(
                            "Zip file created: " + groupName,
                            "Zip file created",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information,
                            MessageBoxDefaultButton.Button1);
                        };
                        break;
                }
            }
        }

        private bool CreateZip(ref string zipFilename, DateTime date)
        {
            bool successfull = false;

            string zipFolder = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\PCPlusDOSBoxLauncher\\Zip";
            string timestamp = "-" + Functions.TimeStamp.GetTimeDateStamp(date) + "-" + Functions.TimeStamp.GetTimeDateStamp();
            zipFolder = zipFolder + "\\" + zipFilename + "-" + timestamp;
            if (!File.Exists(zipFolder))
            {
                try
                {
                    Directory.CreateDirectory(zipFolder);
                }
                catch (Exception ex)
                {
                    this.ShowCriticalError("Unable to save zip file" + ex.ToString());
                    throw new ApplicationException(ex.ToString());
                }
            }

            System.IO.DirectoryInfo dir = new System.IO.DirectoryInfo(workspacePath);
            IEnumerable<System.IO.FileInfo> fileList = dir.GetFiles("*.*", System.IO.SearchOption.TopDirectoryOnly);
            Regex regex = new Regex(Functions.RegExExpressions.GetPcPlusFilesRegEx(zipFilename));
            var queryMatchingFiles =
                from file in fileList.AsEnumerable()
                where regex.IsMatch(file.Name)
                select file.FullName;
                    
            // Execute the query.
            foreach (var filename in queryMatchingFiles)
            {
                File.Copy(filename, zipFolder + "//" + Path.GetFileName(filename));
            }

            ZipFile.CreateFromDirectory(zipFolder, workspacePath + "\\" + zipFilename + timestamp + ".zip");
            Directory.Delete(zipFolder, true);
            zipFilename = workspacePath + "\\" + zipFilename + timestamp + ".zip";
            successfull = true;
            return successfull;
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
    }
}
