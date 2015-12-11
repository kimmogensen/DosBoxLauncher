/// <summary>
/// Workspace form file
/// 
/// Workspace must be validated, and free of errors.
/// Otherwise user must close the form
/// </summary>
namespace DosBoxLauncher
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;
    using DosBoxLauncher.Functions;
    using DosBoxLauncher.Functions.UI;
    using DosBoxLauncher.Models;

    /// <summary>
    /// Form file
    /// </summary>
    public partial class FrmWorkspace : Form
    {
        public Validation.ErrorType ReturnCode;
        public int Index;
        public string OldPath;
        public string OldOrder;
        public string OldTitle;
        public string NewPath;
        public string NewOrder;
        public string NewTitle;
        private DataGridViewRow row;
        private string workspaceRootFolder;

        public FrmWorkspace(DataGridViewRow r, string wsRootFolder, string mode)
        {
            this.InitializeComponent();
            this.row = r;
            this.workspaceRootFolder = wsRootFolder;
            this.Index = (int)r.Cells["Index"].Value;
            this.OldPath = (string)r.Cells["Path"].Value;
            this.OldOrder = (string)r.Cells["Order"].Value;
            this.OldTitle = (string)r.Cells["Title"].Value;
            this.ReturnCode = Validation.ErrorType.Cancel;
            if (mode == "New")
            {
                this.Text = "New Workspace";
            }
            else if (mode == "Update")
            {
                this.Text = "Update Workspace";
            }
            else
            {
                this.Text = "Undefined!";
            }
        }

        private void btnWorkspaceSave_Click(object sender, EventArgs e)
        {
            this.NewPath = this.tbWorkspace.Text;
            this.NewOrder = this.tbOrder.Text;
            this.NewTitle = this.tbTitle.Text;

            Validation.ErrorType errors = Validation.IsRowValid(
                this.tbWorkspace.Text,
                this.tbOrder.Text, 
                this.tbTitle.Text);

            if (((errors & Validation.ErrorType.EmptyValues) != 0) ||
                ((errors & Validation.ErrorType.IndexNotInteger) != 0) ||
                ((errors & Validation.ErrorType.NoSuchDirectory) != 0) ||
                ((errors & Validation.ErrorType.DirectoryNotWriteable) != 0))
            {
                StringBuilder sb = new StringBuilder();
                
                if ((errors & Validation.ErrorType.EmptyValues) != 0)
                {
                    sb.AppendLine("- No empty values");
                }

                if ((errors & Validation.ErrorType.IndexNotInteger) != 0)
                {
                    sb.AppendLine("- Index must be an integer");
                }

                if ((errors & Validation.ErrorType.NoSuchDirectory) != 0)
                {
                    sb.AppendLine("- No such folder");
                }

                if ((errors & Validation.ErrorType.DirectoryNotWriteable) != 0)
                {
                    sb.AppendLine("- Folder not writeable");
                }

                MessageBox.Show(
                    "Ret fejlene og gem igen:" + Environment.NewLine + sb.ToString(),
                    "Validation failed...");                
            }
            else
            {
                this.ReturnCode = Validation.ErrorType.Valid;
                this.Close();
            }
        }

        private void Workspace_Load(object sender, EventArgs e)
        {
            if (this.row.Cells["Index"].Value != null)
            {
                this.tbIndex.Text = this.row.Cells["Index"].Value.ToString();
            }
            
            if (this.row.Cells["Path"].Value != null)
            {
                this.tbWorkspace.Text = this.row.Cells["Path"].Value.ToString();
            }

            if (this.row.Cells["Order"].Value != null)
            {
                this.tbOrder.Text = this.row.Cells["Order"].Value.ToString();
            }

            if (this.row.Cells["Title"].Value != null)
            {
                this.tbTitle.Text = this.row.Cells["Title"].Value.ToString();
            }
        }

        private void btnRootFolderSearch_Click(object sender, EventArgs e)
        {
            string defaultValue = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string currentValue = this.workspaceRootFolder;
            string newValue = string.Empty;
            string filter = string.Empty;
            
            if (Helpers.OpenFolderBrowserDialogSetDefault(currentValue, defaultValue, out newValue, filter))
            {
                this.tbWorkspace.Text = newValue;
            }
        }
    }
}
