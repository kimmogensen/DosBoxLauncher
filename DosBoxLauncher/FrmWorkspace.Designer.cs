namespace DosBoxLauncher
{
    partial class FrmWorkspace
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnWorkspaceSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbWorkspace = new System.Windows.Forms.TextBox();
            this.tbOrder = new System.Windows.Forms.TextBox();
            this.lblOrder = new System.Windows.Forms.Label();
            this.tbTitle = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnRootFolderSearch = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.tbIndex = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnWorkspaceSave
            // 
            this.btnWorkspaceSave.Location = new System.Drawing.Point(267, 148);
            this.btnWorkspaceSave.Name = "btnWorkspaceSave";
            this.btnWorkspaceSave.Size = new System.Drawing.Size(75, 23);
            this.btnWorkspaceSave.TabIndex = 0;
            this.btnWorkspaceSave.Text = "Save";
            this.btnWorkspaceSave.UseVisualStyleBackColor = true;
            this.btnWorkspaceSave.Click += new System.EventHandler(this.btnWorkspaceSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 1;
            // 
            // tbWorkspace
            // 
            this.tbWorkspace.Location = new System.Drawing.Point(102, 37);
            this.tbWorkspace.Name = "tbWorkspace";
            this.tbWorkspace.Size = new System.Drawing.Size(217, 20);
            this.tbWorkspace.TabIndex = 2;
            // 
            // tbOrder
            // 
            this.tbOrder.Location = new System.Drawing.Point(102, 63);
            this.tbOrder.Name = "tbOrder";
            this.tbOrder.Size = new System.Drawing.Size(42, 20);
            this.tbOrder.TabIndex = 4;
            // 
            // lblOrder
            // 
            this.lblOrder.AutoSize = true;
            this.lblOrder.Location = new System.Drawing.Point(50, 68);
            this.lblOrder.Name = "lblOrder";
            this.lblOrder.Size = new System.Drawing.Size(33, 13);
            this.lblOrder.TabIndex = 3;
            this.lblOrder.Text = "Order";
            // 
            // tbTitle
            // 
            this.tbTitle.Location = new System.Drawing.Point(102, 89);
            this.tbTitle.Name = "tbTitle";
            this.tbTitle.Size = new System.Drawing.Size(118, 20);
            this.tbTitle.TabIndex = 6;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(31, 93);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(61, 13);
            this.lblTitle.TabIndex = 5;
            this.lblTitle.Text = "Husketekst";
            // 
            // btnRootFolderSearch
            // 
            this.btnRootFolderSearch.Location = new System.Drawing.Point(17, 36);
            this.btnRootFolderSearch.Name = "btnRootFolderSearch";
            this.btnRootFolderSearch.Size = new System.Drawing.Size(75, 23);
            this.btnRootFolderSearch.TabIndex = 8;
            this.btnRootFolderSearch.Text = "Filmappe";
            this.btnRootFolderSearch.UseVisualStyleBackColor = true;
            this.btnRootFolderSearch.Click += new System.EventHandler(this.btnRootFolderSearch_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.tbIndex);
            this.panel1.Controls.Add(this.btnRootFolderSearch);
            this.panel1.Controls.Add(this.tbWorkspace);
            this.panel1.Controls.Add(this.lblOrder);
            this.panel1.Controls.Add(this.tbTitle);
            this.panel1.Controls.Add(this.tbOrder);
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Location = new System.Drawing.Point(10, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(332, 132);
            this.panel1.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Indeks";
            // 
            // tbIndex
            // 
            this.tbIndex.Enabled = false;
            this.tbIndex.Location = new System.Drawing.Point(102, 11);
            this.tbIndex.Name = "tbIndex";
            this.tbIndex.Size = new System.Drawing.Size(42, 20);
            this.tbIndex.TabIndex = 10;
            // 
            // FrmWorkspace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 183);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnWorkspaceSave);
            this.Name = "FrmWorkspace";
            this.Load += new System.EventHandler(this.Workspace_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnWorkspaceSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbWorkspace;
        private System.Windows.Forms.TextBox tbOrder;
        private System.Windows.Forms.Label lblOrder;
        private System.Windows.Forms.TextBox tbTitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnRootFolderSearch;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbIndex;
    }
}