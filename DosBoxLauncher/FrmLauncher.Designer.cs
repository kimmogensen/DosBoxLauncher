//-----------------------------------------------------------------------
// <copyright file="Form1.Designer.cs" company="codeguys.dk">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------

/// <summary>
/// A Windows Form Program which launches DOSBox, by sriting in the DOSBox configuration file,
/// and then execute DOSBox. The work is being done by the [autoexec] part of the DOSBox configuration file
/// </summary>
namespace DosBoxLauncher
{
    /// <summary>
    /// Form1 UI
    /// </summary>
    public partial class FrmLauncher
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
            if (disposing && (this.components != null))
            {
                this.components.Dispose();
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLauncher));
            this.lblLogEntries = new System.Windows.Forms.Label();
            this.tbLogEntries = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lblConfigurationLastUpdateLauncher = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblConfigurationCreatedLauncher = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblInfoShowWorkspaces = new System.Windows.Forms.Label();
            this.cbShowWorkspaces = new System.Windows.Forms.CheckBox();
            this.panelLuncher = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.lblLauncherWorkspace = new System.Windows.Forms.Label();
            this.btnStartPCPlus = new System.Windows.Forms.Button();
            this.cbLauncherWorspaceSelector = new System.Windows.Forms.ComboBox();
            this.lblInfoLauncher = new System.Windows.Forms.Label();
            this.panelWorkspaces = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabLauncher = new System.Windows.Forms.TabControl();
            this.Configuration = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblConfigurationLastUpdateConfig = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblConfigurationCreatedConfig = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblInfoShowDosBoxConfiguration = new System.Windows.Forms.Label();
            this.cbShowDosBoxConfig = new System.Windows.Forms.CheckBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbWorkspaceRootPathValid = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblInfoWorkspaceRootFolder = new System.Windows.Forms.Label();
            this.btnWorkspaceRootFolderSearch = new System.Windows.Forms.Button();
            this.tbWorkspaceRootPath = new System.Windows.Forms.TextBox();
            this.panelDosBoxConfig = new System.Windows.Forms.Panel();
            this.tbDOSBoxConfigValid = new System.Windows.Forms.TextBox();
            this.tbDOSBoxExeValid = new System.Windows.Forms.TextBox();
            this.lblDosBoxConf = new System.Windows.Forms.Label();
            this.btnDosBoxConfigSearch = new System.Windows.Forms.Button();
            this.tbDOSBoxConfig = new System.Windows.Forms.TextBox();
            this.lblDosBoxExe = new System.Windows.Forms.Label();
            this.btnDosBoxExeSearch = new System.Windows.Forms.Button();
            this.tbDOSBoxExe = new System.Windows.Forms.TextBox();
            this.lblInfoDosBoxExeConfig = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.BtnReadMe = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.BtnBasicConfiguration = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.BtnUserManual = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnSystemSetup = new System.Windows.Forms.Button();
            this.lblMessage = new System.Windows.Forms.Label();
            this.tabPage2.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panelLuncher.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panelWorkspaces.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabLauncher.SuspendLayout();
            this.Configuration.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelDosBoxConfig.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel8.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblLogEntries
            // 
            this.lblLogEntries.AutoSize = true;
            this.lblLogEntries.Location = new System.Drawing.Point(3, 10);
            this.lblLogEntries.Name = "lblLogEntries";
            this.lblLogEntries.Size = new System.Drawing.Size(62, 13);
            this.lblLogEntries.TabIndex = 5;
            this.lblLogEntries.Text = "Log entries:";
            // 
            // tbLogEntries
            // 
            this.tbLogEntries.Cursor = System.Windows.Forms.Cursors.UpArrow;
            this.tbLogEntries.Location = new System.Drawing.Point(69, 10);
            this.tbLogEntries.Multiline = true;
            this.tbLogEntries.Name = "tbLogEntries";
            this.tbLogEntries.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbLogEntries.Size = new System.Drawing.Size(576, 127);
            this.tbLogEntries.TabIndex = 4;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Gainsboro;
            this.tabPage2.Controls.Add(this.panel6);
            this.tabPage2.Controls.Add(this.panel4);
            this.tabPage2.Controls.Add(this.panelLuncher);
            this.tabPage2.Controls.Add(this.panelWorkspaces);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(678, 399);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Launcher";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.LightGray;
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.lblConfigurationLastUpdateLauncher);
            this.panel6.Controls.Add(this.label5);
            this.panel6.Controls.Add(this.lblConfigurationCreatedLauncher);
            this.panel6.Controls.Add(this.label7);
            this.panel6.Location = new System.Drawing.Point(366, 90);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(304, 40);
            this.panel6.TabIndex = 14;
            // 
            // lblConfigurationLastUpdateLauncher
            // 
            this.lblConfigurationLastUpdateLauncher.AutoSize = true;
            this.lblConfigurationLastUpdateLauncher.Location = new System.Drawing.Point(181, 6);
            this.lblConfigurationLastUpdateLauncher.Name = "lblConfigurationLastUpdateLauncher";
            this.lblConfigurationLastUpdateLauncher.Size = new System.Drawing.Size(108, 13);
            this.lblConfigurationLastUpdateLauncher.TabIndex = 9;
            this.lblConfigurationLastUpdateLauncher.Text = "yyyy-mm-dd hh:mm:ss";
            this.lblConfigurationLastUpdateLauncher.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(110, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Last Update";
            // 
            // lblConfigurationCreatedLauncher
            // 
            this.lblConfigurationCreatedLauncher.AutoSize = true;
            this.lblConfigurationCreatedLauncher.Location = new System.Drawing.Point(181, 22);
            this.lblConfigurationCreatedLauncher.Name = "lblConfigurationCreatedLauncher";
            this.lblConfigurationCreatedLauncher.Size = new System.Drawing.Size(108, 13);
            this.lblConfigurationCreatedLauncher.TabIndex = 11;
            this.lblConfigurationCreatedLauncher.Text = "yyyy-mm-dd hh:mm:ss";
            this.lblConfigurationCreatedLauncher.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(131, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Created";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.LightGray;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.lblInfoShowWorkspaces);
            this.panel4.Controls.Add(this.cbShowWorkspaces);
            this.panel4.Location = new System.Drawing.Point(10, 90);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(350, 40);
            this.panel4.TabIndex = 9;
            // 
            // lblInfoShowWorkspaces
            // 
            this.lblInfoShowWorkspaces.AutoSize = true;
            this.lblInfoShowWorkspaces.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfoShowWorkspaces.Location = new System.Drawing.Point(20, 24);
            this.lblInfoShowWorkspaces.Name = "lblInfoShowWorkspaces";
            this.lblInfoShowWorkspaces.Size = new System.Drawing.Size(122, 13);
            this.lblInfoShowWorkspaces.TabIndex = 10;
            this.lblInfoShowWorkspaces.Text = "lblInfoShowWorkspaces";
            // 
            // cbShowWorkspaces
            // 
            this.cbShowWorkspaces.AutoSize = true;
            this.cbShowWorkspaces.Location = new System.Drawing.Point(3, 7);
            this.cbShowWorkspaces.Name = "cbShowWorkspaces";
            this.cbShowWorkspaces.Size = new System.Drawing.Size(162, 17);
            this.cbShowWorkspaces.TabIndex = 9;
            this.cbShowWorkspaces.Text = "Vis Workspace konfiguration";
            this.cbShowWorkspaces.UseVisualStyleBackColor = true;
            this.cbShowWorkspaces.CheckedChanged += new System.EventHandler(this.cbShowWorkspaces_CheckedChanged);
            this.cbShowWorkspaces.Click += new System.EventHandler(this.cbShowWorkspaces_Click);
            // 
            // panelLuncher
            // 
            this.panelLuncher.BackColor = System.Drawing.Color.LightGray;
            this.panelLuncher.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelLuncher.Controls.Add(this.panel7);
            this.panelLuncher.Controls.Add(this.lblInfoLauncher);
            this.panelLuncher.Location = new System.Drawing.Point(10, 10);
            this.panelLuncher.Name = "panelLuncher";
            this.panelLuncher.Size = new System.Drawing.Size(660, 75);
            this.panelLuncher.TabIndex = 6;
            // 
            // panel7
            // 
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Controls.Add(this.checkBox1);
            this.panel7.Controls.Add(this.lblLauncherWorkspace);
            this.panel7.Controls.Add(this.btnStartPCPlus);
            this.panel7.Controls.Add(this.cbLauncherWorspaceSelector);
            this.panel7.Location = new System.Drawing.Point(13, 27);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(632, 38);
            this.panel7.TabIndex = 6;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(424, 11);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(77, 17);
            this.checkBox1.TabIndex = 10;
            this.checkBox1.Text = "Full screen";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // lblLauncherWorkspace
            // 
            this.lblLauncherWorkspace.AutoSize = true;
            this.lblLauncherWorkspace.Location = new System.Drawing.Point(15, 7);
            this.lblLauncherWorkspace.Name = "lblLauncherWorkspace";
            this.lblLauncherWorkspace.Size = new System.Drawing.Size(162, 13);
            this.lblLauncherWorkspace.TabIndex = 9;
            this.lblLauncherWorkspace.Text = "Vælg den mappe du vil arbejde i:";
            // 
            // btnStartPCPlus
            // 
            this.btnStartPCPlus.Location = new System.Drawing.Point(542, 4);
            this.btnStartPCPlus.Name = "btnStartPCPlus";
            this.btnStartPCPlus.Size = new System.Drawing.Size(75, 25);
            this.btnStartPCPlus.TabIndex = 0;
            this.btnStartPCPlus.Text = "Start PCPlus";
            this.btnStartPCPlus.UseVisualStyleBackColor = true;
            this.btnStartPCPlus.Click += new System.EventHandler(this.BtnStartPCPlus_Click);
            // 
            // cbLauncherWorspaceSelector
            // 
            this.cbLauncherWorspaceSelector.FormattingEnabled = true;
            this.cbLauncherWorspaceSelector.Location = new System.Drawing.Point(183, 7);
            this.cbLauncherWorspaceSelector.Name = "cbLauncherWorspaceSelector";
            this.cbLauncherWorspaceSelector.Size = new System.Drawing.Size(197, 21);
            this.cbLauncherWorspaceSelector.TabIndex = 8;
            // 
            // lblInfoLauncher
            // 
            this.lblInfoLauncher.AutoSize = true;
            this.lblInfoLauncher.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfoLauncher.Location = new System.Drawing.Point(10, 10);
            this.lblInfoLauncher.Name = "lblInfoLauncher";
            this.lblInfoLauncher.Size = new System.Drawing.Size(80, 13);
            this.lblInfoLauncher.TabIndex = 5;
            this.lblInfoLauncher.Text = "lblInfoLauncher";
            // 
            // panelWorkspaces
            // 
            this.panelWorkspaces.BackColor = System.Drawing.Color.LightGray;
            this.panelWorkspaces.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelWorkspaces.Controls.Add(this.dataGridView1);
            this.panelWorkspaces.Location = new System.Drawing.Point(10, 134);
            this.panelWorkspaces.Name = "panelWorkspaces";
            this.panelWorkspaces.Size = new System.Drawing.Size(660, 265);
            this.panelWorkspaces.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(10, 10);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(635, 248);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
            // 
            // tabLauncher
            // 
            this.tabLauncher.Controls.Add(this.tabPage2);
            this.tabLauncher.Controls.Add(this.Configuration);
            this.tabLauncher.Controls.Add(this.tabPage1);
            this.tabLauncher.Location = new System.Drawing.Point(10, 12);
            this.tabLauncher.Name = "tabLauncher";
            this.tabLauncher.SelectedIndex = 0;
            this.tabLauncher.Size = new System.Drawing.Size(686, 425);
            this.tabLauncher.TabIndex = 6;
            // 
            // Configuration
            // 
            this.Configuration.BackColor = System.Drawing.Color.Gainsboro;
            this.Configuration.Controls.Add(this.panel3);
            this.Configuration.Controls.Add(this.panel5);
            this.Configuration.Controls.Add(this.panel2);
            this.Configuration.Controls.Add(this.panel1);
            this.Configuration.Controls.Add(this.panelDosBoxConfig);
            this.Configuration.Location = new System.Drawing.Point(4, 22);
            this.Configuration.Name = "Configuration";
            this.Configuration.Padding = new System.Windows.Forms.Padding(3);
            this.Configuration.Size = new System.Drawing.Size(678, 399);
            this.Configuration.TabIndex = 3;
            this.Configuration.Text = "Konfiguration";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightGray;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.lblConfigurationLastUpdateConfig);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.lblConfigurationCreatedConfig);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(366, 90);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(304, 40);
            this.panel3.TabIndex = 13;
            // 
            // lblConfigurationLastUpdateConfig
            // 
            this.lblConfigurationLastUpdateConfig.AutoSize = true;
            this.lblConfigurationLastUpdateConfig.Location = new System.Drawing.Point(181, 6);
            this.lblConfigurationLastUpdateConfig.Name = "lblConfigurationLastUpdateConfig";
            this.lblConfigurationLastUpdateConfig.Size = new System.Drawing.Size(108, 13);
            this.lblConfigurationLastUpdateConfig.TabIndex = 9;
            this.lblConfigurationLastUpdateConfig.Text = "yyyy-mm-dd hh:mm:ss";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(110, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Last Update";
            // 
            // lblConfigurationCreatedConfig
            // 
            this.lblConfigurationCreatedConfig.AutoSize = true;
            this.lblConfigurationCreatedConfig.Location = new System.Drawing.Point(181, 22);
            this.lblConfigurationCreatedConfig.Name = "lblConfigurationCreatedConfig";
            this.lblConfigurationCreatedConfig.Size = new System.Drawing.Size(108, 13);
            this.lblConfigurationCreatedConfig.TabIndex = 11;
            this.lblConfigurationCreatedConfig.Text = "yyyy-mm-dd hh:mm:ss";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(131, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Created";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.LightGray;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.lblInfoShowDosBoxConfiguration);
            this.panel5.Controls.Add(this.cbShowDosBoxConfig);
            this.panel5.Location = new System.Drawing.Point(10, 90);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(350, 40);
            this.panel5.TabIndex = 10;
            // 
            // lblInfoShowDosBoxConfiguration
            // 
            this.lblInfoShowDosBoxConfiguration.AutoSize = true;
            this.lblInfoShowDosBoxConfiguration.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfoShowDosBoxConfiguration.Location = new System.Drawing.Point(16, 22);
            this.lblInfoShowDosBoxConfiguration.Name = "lblInfoShowDosBoxConfiguration";
            this.lblInfoShowDosBoxConfiguration.Size = new System.Drawing.Size(161, 13);
            this.lblInfoShowDosBoxConfiguration.TabIndex = 10;
            this.lblInfoShowDosBoxConfiguration.Text = "lblInfoShowDosBoxConfiguration";
            // 
            // cbShowDosBoxConfig
            // 
            this.cbShowDosBoxConfig.AutoSize = true;
            this.cbShowDosBoxConfig.Location = new System.Drawing.Point(3, 3);
            this.cbShowDosBoxConfig.Name = "cbShowDosBoxConfig";
            this.cbShowDosBoxConfig.Size = new System.Drawing.Size(144, 17);
            this.cbShowDosBoxConfig.TabIndex = 9;
            this.cbShowDosBoxConfig.Text = "Vis DosBox konfiguration";
            this.cbShowDosBoxConfig.UseVisualStyleBackColor = true;
            this.cbShowDosBoxConfig.CheckedChanged += new System.EventHandler(this.cbShowDosBoxConfig_CheckedChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightGray;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lblLogEntries);
            this.panel2.Controls.Add(this.tbLogEntries);
            this.panel2.Location = new System.Drawing.Point(10, 253);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(660, 140);
            this.panel2.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.tbWorkspaceRootPathValid);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.lblInfoWorkspaceRootFolder);
            this.panel1.Controls.Add(this.btnWorkspaceRootFolderSearch);
            this.panel1.Controls.Add(this.tbWorkspaceRootPath);
            this.panel1.Location = new System.Drawing.Point(10, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(660, 75);
            this.panel1.TabIndex = 9;
            // 
            // tbWorkspaceRootPathValid
            // 
            this.tbWorkspaceRootPathValid.Location = new System.Drawing.Point(540, 39);
            this.tbWorkspaceRootPathValid.Name = "tbWorkspaceRootPathValid";
            this.tbWorkspaceRootPathValid.Size = new System.Drawing.Size(24, 20);
            this.tbWorkspaceRootPathValid.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(55, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "PCPlus Rodmapper";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblInfoWorkspaceRootFolder
            // 
            this.lblInfoWorkspaceRootFolder.AutoSize = true;
            this.lblInfoWorkspaceRootFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfoWorkspaceRootFolder.Location = new System.Drawing.Point(10, 10);
            this.lblInfoWorkspaceRootFolder.Name = "lblInfoWorkspaceRootFolder";
            this.lblInfoWorkspaceRootFolder.Size = new System.Drawing.Size(142, 13);
            this.lblInfoWorkspaceRootFolder.TabIndex = 2;
            this.lblInfoWorkspaceRootFolder.Text = "lblInfoWorkspaceRootFolder";
            // 
            // btnWorkspaceRootFolderSearch
            // 
            this.btnWorkspaceRootFolderSearch.Location = new System.Drawing.Point(570, 40);
            this.btnWorkspaceRootFolderSearch.Name = "btnWorkspaceRootFolderSearch";
            this.btnWorkspaceRootFolderSearch.Size = new System.Drawing.Size(75, 25);
            this.btnWorkspaceRootFolderSearch.TabIndex = 1;
            this.btnWorkspaceRootFolderSearch.Text = "Søg";
            this.btnWorkspaceRootFolderSearch.UseVisualStyleBackColor = true;
            this.btnWorkspaceRootFolderSearch.Click += new System.EventHandler(this.BtnWorkspaceRootFolderSearch_Click);
            // 
            // tbWorkspaceRootPath
            // 
            this.tbWorkspaceRootPath.Location = new System.Drawing.Point(182, 40);
            this.tbWorkspaceRootPath.Name = "tbWorkspaceRootPath";
            this.tbWorkspaceRootPath.Size = new System.Drawing.Size(352, 20);
            this.tbWorkspaceRootPath.TabIndex = 0;
            // 
            // panelDosBoxConfig
            // 
            this.panelDosBoxConfig.BackColor = System.Drawing.Color.LightGray;
            this.panelDosBoxConfig.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelDosBoxConfig.Controls.Add(this.tbDOSBoxConfigValid);
            this.panelDosBoxConfig.Controls.Add(this.tbDOSBoxExeValid);
            this.panelDosBoxConfig.Controls.Add(this.lblDosBoxConf);
            this.panelDosBoxConfig.Controls.Add(this.btnDosBoxConfigSearch);
            this.panelDosBoxConfig.Controls.Add(this.tbDOSBoxConfig);
            this.panelDosBoxConfig.Controls.Add(this.lblDosBoxExe);
            this.panelDosBoxConfig.Controls.Add(this.btnDosBoxExeSearch);
            this.panelDosBoxConfig.Controls.Add(this.tbDOSBoxExe);
            this.panelDosBoxConfig.Controls.Add(this.lblInfoDosBoxExeConfig);
            this.panelDosBoxConfig.Cursor = System.Windows.Forms.Cursors.Default;
            this.panelDosBoxConfig.Location = new System.Drawing.Point(10, 134);
            this.panelDosBoxConfig.Name = "panelDosBoxConfig";
            this.panelDosBoxConfig.Size = new System.Drawing.Size(660, 113);
            this.panelDosBoxConfig.TabIndex = 7;
            // 
            // tbDOSBoxConfigValid
            // 
            this.tbDOSBoxConfigValid.Location = new System.Drawing.Point(540, 76);
            this.tbDOSBoxConfigValid.Name = "tbDOSBoxConfigValid";
            this.tbDOSBoxConfigValid.Size = new System.Drawing.Size(24, 20);
            this.tbDOSBoxConfigValid.TabIndex = 9;
            // 
            // tbDOSBoxExeValid
            // 
            this.tbDOSBoxExeValid.Location = new System.Drawing.Point(540, 39);
            this.tbDOSBoxExeValid.Name = "tbDOSBoxExeValid";
            this.tbDOSBoxExeValid.Size = new System.Drawing.Size(24, 20);
            this.tbDOSBoxExeValid.TabIndex = 8;
            // 
            // lblDosBoxConf
            // 
            this.lblDosBoxConf.AutoSize = true;
            this.lblDosBoxConf.Location = new System.Drawing.Point(55, 75);
            this.lblDosBoxConf.Name = "lblDosBoxConf";
            this.lblDosBoxConf.Size = new System.Drawing.Size(121, 13);
            this.lblDosBoxConf.TabIndex = 7;
            this.lblDosBoxConf.Text = "\'dosbox-<version>.conf\':";
            // 
            // btnDosBoxConfigSearch
            // 
            this.btnDosBoxConfigSearch.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnDosBoxConfigSearch.Location = new System.Drawing.Point(570, 75);
            this.btnDosBoxConfigSearch.Name = "btnDosBoxConfigSearch";
            this.btnDosBoxConfigSearch.Size = new System.Drawing.Size(75, 25);
            this.btnDosBoxConfigSearch.TabIndex = 6;
            this.btnDosBoxConfigSearch.Text = "Søg";
            this.btnDosBoxConfigSearch.UseVisualStyleBackColor = true;
            this.btnDosBoxConfigSearch.Click += new System.EventHandler(this.BtnDosBoxConfigSearch_Click);
            // 
            // tbDOSBoxConfig
            // 
            this.tbDOSBoxConfig.Location = new System.Drawing.Point(182, 75);
            this.tbDOSBoxConfig.Name = "tbDOSBoxConfig";
            this.tbDOSBoxConfig.Size = new System.Drawing.Size(352, 20);
            this.tbDOSBoxConfig.TabIndex = 5;
            // 
            // lblDosBoxExe
            // 
            this.lblDosBoxExe.AutoSize = true;
            this.lblDosBoxExe.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblDosBoxExe.Location = new System.Drawing.Point(101, 46);
            this.lblDosBoxExe.Name = "lblDosBoxExe";
            this.lblDosBoxExe.Size = new System.Drawing.Size(75, 13);
            this.lblDosBoxExe.TabIndex = 3;
            this.lblDosBoxExe.Text = "\'DOSBox.exe\':";
            // 
            // btnDosBoxExeSearch
            // 
            this.btnDosBoxExeSearch.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnDosBoxExeSearch.Location = new System.Drawing.Point(570, 41);
            this.btnDosBoxExeSearch.Name = "btnDosBoxExeSearch";
            this.btnDosBoxExeSearch.Size = new System.Drawing.Size(75, 25);
            this.btnDosBoxExeSearch.TabIndex = 1;
            this.btnDosBoxExeSearch.Text = "Søg";
            this.btnDosBoxExeSearch.UseVisualStyleBackColor = true;
            this.btnDosBoxExeSearch.Click += new System.EventHandler(this.BtnDosBoxExeSearch_Click);
            // 
            // tbDOSBoxExe
            // 
            this.tbDOSBoxExe.Location = new System.Drawing.Point(182, 41);
            this.tbDOSBoxExe.Name = "tbDOSBoxExe";
            this.tbDOSBoxExe.Size = new System.Drawing.Size(352, 20);
            this.tbDOSBoxExe.TabIndex = 0;
            // 
            // lblInfoDosBoxExeConfig
            // 
            this.lblInfoDosBoxExeConfig.AutoSize = true;
            this.lblInfoDosBoxExeConfig.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfoDosBoxExeConfig.Location = new System.Drawing.Point(15, 15);
            this.lblInfoDosBoxExeConfig.Name = "lblInfoDosBoxExeConfig";
            this.lblInfoDosBoxExeConfig.Size = new System.Drawing.Size(120, 13);
            this.lblInfoDosBoxExeConfig.TabIndex = 2;
            this.lblInfoDosBoxExeConfig.Text = "lblInfoDosBoxExeConfig";
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Gainsboro;
            this.tabPage1.Controls.Add(this.panel8);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(678, 399);
            this.tabPage1.TabIndex = 4;
            this.tabPage1.Text = "Help";
            // 
            // panel8
            // 
            this.panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel8.Controls.Add(this.label9);
            this.panel8.Controls.Add(this.BtnReadMe);
            this.panel8.Controls.Add(this.label8);
            this.panel8.Controls.Add(this.BtnBasicConfiguration);
            this.panel8.Controls.Add(this.label6);
            this.panel8.Controls.Add(this.BtnUserManual);
            this.panel8.Controls.Add(this.label2);
            this.panel8.Controls.Add(this.BtnSystemSetup);
            this.panel8.Location = new System.Drawing.Point(10, 10);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(660, 99);
            this.panel8.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(353, 67);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(127, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "DosBoxLauncher readme";
            // 
            // BtnReadMe
            // 
            this.BtnReadMe.Location = new System.Drawing.Point(555, 61);
            this.BtnReadMe.Name = "BtnReadMe";
            this.BtnReadMe.Size = new System.Drawing.Size(75, 25);
            this.BtnReadMe.TabIndex = 8;
            this.BtnReadMe.Text = "Read me";
            this.BtnReadMe.UseVisualStyleBackColor = true;
            this.BtnReadMe.Click += new System.EventHandler(this.BtnReadMe_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(25, 67);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(183, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "DosBoxLauncher grund konfiguration";
            // 
            // BtnBasicConfiguration
            // 
            this.BtnBasicConfiguration.Location = new System.Drawing.Point(218, 61);
            this.BtnBasicConfiguration.Name = "BtnBasicConfiguration";
            this.BtnBasicConfiguration.Size = new System.Drawing.Size(75, 25);
            this.BtnBasicConfiguration.TabIndex = 6;
            this.BtnBasicConfiguration.Text = "Help";
            this.BtnBasicConfiguration.UseVisualStyleBackColor = true;
            this.BtnBasicConfiguration.Click += new System.EventHandler(this.BtnBasicConfiguration_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(159, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "DosBoxLauncher bruger manual";
            // 
            // BtnUserManual
            // 
            this.BtnUserManual.Location = new System.Drawing.Point(218, 26);
            this.BtnUserManual.Name = "BtnUserManual";
            this.BtnUserManual.Size = new System.Drawing.Size(75, 25);
            this.BtnUserManual.TabIndex = 4;
            this.BtnUserManual.Text = "Help";
            this.BtnUserManual.UseVisualStyleBackColor = true;
            this.BtnUserManual.Click += new System.EventHandler(this.BtnUserManual_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(353, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "DosBoxLauncher system setup";
            // 
            // BtnSystemSetup
            // 
            this.BtnSystemSetup.Location = new System.Drawing.Point(555, 26);
            this.BtnSystemSetup.Name = "BtnSystemSetup";
            this.BtnSystemSetup.Size = new System.Drawing.Size(75, 25);
            this.BtnSystemSetup.TabIndex = 2;
            this.BtnSystemSetup.Text = "Help";
            this.BtnSystemSetup.UseVisualStyleBackColor = true;
            this.BtnSystemSetup.Click += new System.EventHandler(this.BtnSystemSetup_Click);
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(10, 440);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(248, 13);
            this.lblMessage.TabIndex = 9;
            this.lblMessage.Text = "Welcome! Mesages from the tool will appear here...";
            // 
            // FrmLauncher
            // 
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(708, 456);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.tabLauncher);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmLauncher";
            this.Text = "PC Plus 4.3 Årsmappe Manager";
            this.tabPage2.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panelLuncher.ResumeLayout(false);
            this.panelLuncher.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panelWorkspaces.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabLauncher.ResumeLayout(false);
            this.Configuration.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelDosBoxConfig.ResumeLayout(false);
            this.panelDosBoxConfig.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbLogEntries;
        private System.Windows.Forms.Label lblLogEntries;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabControl tabLauncher;
        private System.Windows.Forms.Panel panelWorkspaces;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage Configuration;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblInfoWorkspaceRootFolder;
        private System.Windows.Forms.Button btnWorkspaceRootFolderSearch;
        private System.Windows.Forms.TextBox tbWorkspaceRootPath;
        private System.Windows.Forms.Panel panelDosBoxConfig;
        private System.Windows.Forms.Label lblDosBoxExe;
        private System.Windows.Forms.Button btnDosBoxExeSearch;
        private System.Windows.Forms.TextBox tbDOSBoxExe;
        private System.Windows.Forms.Label lblInfoDosBoxExeConfig;
        private System.Windows.Forms.Panel panelLuncher;
        private System.Windows.Forms.Button btnStartPCPlus;
        private System.Windows.Forms.Label lblDosBoxConf;
        private System.Windows.Forms.Button btnDosBoxConfigSearch;
        private System.Windows.Forms.TextBox tbDOSBoxConfig;
        private System.Windows.Forms.Label lblInfoLauncher;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblInfoShowWorkspaces;
        private System.Windows.Forms.CheckBox cbShowWorkspaces;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lblInfoShowDosBoxConfiguration;
        private System.Windows.Forms.CheckBox cbShowDosBoxConfig;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblConfigurationLastUpdateConfig;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblConfigurationCreatedConfig;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label lblConfigurationLastUpdateLauncher;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblConfigurationCreatedLauncher;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label lblLauncherWorkspace;
        private System.Windows.Forms.ComboBox cbLauncherWorspaceSelector;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.TextBox tbWorkspaceRootPathValid;
        private System.Windows.Forms.TextBox tbDOSBoxConfigValid;
        private System.Windows.Forms.TextBox tbDOSBoxExeValid;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button BtnBasicConfiguration;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button BtnUserManual;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnSystemSetup;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button BtnReadMe;
    }
}
