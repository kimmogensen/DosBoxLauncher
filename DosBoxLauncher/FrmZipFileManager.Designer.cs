namespace DosBoxLauncher
{
    partial class FrmZipFileManager
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
            this.lblPcPlusMappe = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.linkLabelPcPlusFolder = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPcPlusMappe
            // 
            this.lblPcPlusMappe.AutoSize = true;
            this.lblPcPlusMappe.Location = new System.Drawing.Point(13, 13);
            this.lblPcPlusMappe.Name = "lblPcPlusMappe";
            this.lblPcPlusMappe.Size = new System.Drawing.Size(74, 13);
            this.lblPcPlusMappe.TabIndex = 0;
            this.lblPcPlusMappe.Text = "Arbejdsmappe";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 48);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(471, 530);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // linkLabelPcPlusFolder
            // 
            this.linkLabelPcPlusFolder.AutoSize = true;
            this.linkLabelPcPlusFolder.Location = new System.Drawing.Point(99, 13);
            this.linkLabelPcPlusFolder.Name = "linkLabelPcPlusFolder";
            this.linkLabelPcPlusFolder.Size = new System.Drawing.Size(55, 13);
            this.linkLabelPcPlusFolder.TabIndex = 4;
            this.linkLabelPcPlusFolder.TabStop = true;
            this.linkLabelPcPlusFolder.Text = "linkLabel1";
            this.linkLabelPcPlusFolder.MouseClick += new System.Windows.Forms.MouseEventHandler(this.linkLabelPcPlusFolder_MouseClick);
            // 
            // FrmZipFileManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 590);
            this.Controls.Add(this.linkLabelPcPlusFolder);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblPcPlusMappe);
            this.Name = "FrmZipFileManager";
            this.Text = "Zip Filemanager";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPcPlusMappe;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.LinkLabel linkLabelPcPlusFolder;
    }
}