namespace DosBoxLauncher.Functions.UI
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Drawing;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;
    using DosBoxLauncher.Models;

    public static class Helpers
    {
        [Flags]
        public enum ErrorType
        {
            Valid = 0x0,
            IndexNotInteger = 0x1,
            NoSuchDirectory = 0x2,
            DirectoryNotWriteable = 0x4,
            EmptyValues = 0x8,
        }

        public static DataGridView FormatGridColumns(DataGridView dataGridView1)
        {
            DataGridViewTextBoxColumn workspaceIndex = new DataGridViewTextBoxColumn();
            workspaceIndex.HeaderText = "#";
            workspaceIndex.DataPropertyName = "Index";
            workspaceIndex.Name = "Index";
            workspaceIndex.Width = 35;

            DataGridViewLinkColumn folderBrowser = new DataGridViewLinkColumn();
            folderBrowser.HeaderText = "Definer";
            folderBrowser.DataPropertyName = "Define";
            folderBrowser.Name = "Define";
            folderBrowser.Width = 50;
            
            DataGridViewLinkColumn delete = new DataGridViewLinkColumn();
            delete.HeaderText = "Slet";
            delete.DataPropertyName = "Delete";
            delete.Name = "Delete";
            delete.Width = 50;

            DataGridViewTextBoxColumn workspaceOrder = new DataGridViewTextBoxColumn();
            workspaceOrder.HeaderText = "Order";
            workspaceOrder.DataPropertyName = "Order";
            workspaceOrder.Name = "Order";
            workspaceOrder.Width = 35;

            DataGridViewTextBoxColumn workspacePath = new DataGridViewTextBoxColumn();
            workspacePath.HeaderText = "Sti";
            workspacePath.DataPropertyName = "Path";
            workspacePath.Name = "Path";
            workspacePath.Width = 215;

            DataGridViewTextBoxColumn workspaceTitle = new DataGridViewTextBoxColumn();
            workspaceTitle.HeaderText = "Husketekst";
            workspaceTitle.DataPropertyName = "Title";
            workspaceTitle.Name = "Title";
            workspaceTitle.Name = "Title";
            workspaceTitle.Width = 80;

            DataGridViewTextBoxColumn valid = new DataGridViewTextBoxColumn();
            valid.HeaderText = "Valid";
            valid.DataPropertyName = "Valid";
            valid.Name = "Valid";
            valid.Width = 30;

            DataGridViewLinkColumn files = new DataGridViewLinkColumn();
            files.HeaderText = "Browse";
            files.DataPropertyName = "Browse";
            files.Name = "Browse";
            files.Width = 40;

            DataGridViewLinkColumn zipManager = new DataGridViewLinkColumn();
            zipManager.HeaderText = "ZipManager";
            zipManager.DataPropertyName = "ZipManager";
            zipManager.Name = "ZipManager";
            zipManager.Width = 60;

            dataGridView1.Columns.Add(workspaceIndex);
            dataGridView1.Columns.Add(folderBrowser);
            dataGridView1.Columns.Add(delete);
            dataGridView1.Columns.Add(workspaceOrder);
            dataGridView1.Columns.Add(workspacePath);
            dataGridView1.Columns.Add(workspaceTitle);
            dataGridView1.Columns.Add(valid);
            dataGridView1.Columns.Add(files);
            dataGridView1.Columns.Add(zipManager);

            return dataGridView1;
        }

        public static ComboBox PopulateComboLauncher(ComboBox cbLauncherWorspaceSelector, LauncherConfiguration config)
        {
            int comboBox1Index = 0;

            cbLauncherWorspaceSelector.Items.Clear();

            var queryWorkspaces =
                from ws
                in config.Workspaces
                orderby ws.Index
                select ws;
            foreach (Models.Workspace ws in queryWorkspaces)
            {
                cbLauncherWorspaceSelector.Items.Insert(comboBox1Index++, ws);
            }

            return cbLauncherWorspaceSelector;
        }

        public static bool OpenFileDialogSetDefault(string currentValue, string defaultvalue, out string newValue, string filter)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            newValue = null;

            if ((currentValue != defaultvalue) || string.IsNullOrWhiteSpace(currentValue))
            {
                dialog.InitialDirectory = Path.GetDirectoryName(currentValue);
            }
            else
            {
                dialog.InitialDirectory = Path.GetDirectoryName(defaultvalue);
            }

            bool valueChanged = false;
            DialogResult result = dialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                if (currentValue != dialog.FileName.ToString())
                {
                    newValue = dialog.FileName.ToString();

                    valueChanged = true;
                }
                //// else
                //// {
                //// }
            }

            return valueChanged;
        }

        public static bool OpenFolderBrowserDialogSetDefault(string currentValue, string defaultvalue, out string newValue, string filter)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            newValue = null;

            if ((currentValue != defaultvalue) || string.IsNullOrWhiteSpace(currentValue))
            {
                dialog.SelectedPath = currentValue;
            }
            else
            {
                dialog.SelectedPath = defaultvalue;
            }

            bool valueChanged = false;
            DialogResult result = dialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                if (currentValue != dialog.SelectedPath.ToString())
                {
                    newValue = dialog.SelectedPath.ToString();
                   
                    valueChanged = true;
                }
                else
                {
                }
            }

            return valueChanged;
        }
    }
}