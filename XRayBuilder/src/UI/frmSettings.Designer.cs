﻿namespace XRayBuilderGUI.UI
{
    partial class frmSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSettings));
            this.btnSupport = new System.Windows.Forms.Button();
            this.btnClearLogs = new System.Windows.Forms.Button();
            this.btnLogs = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblSeperator = new System.Windows.Forms.Label();
            this.tabSettings = new System.Windows.Forms.TabControl();
            this.tabPgGeneral = new System.Windows.Forms.TabPage();
            this.gbProcess = new System.Windows.Forms.GroupBox();
            this.chkPageCount = new System.Windows.Forms.CheckBox();
            this.gbUnpack = new System.Windows.Forms.GroupBox();
            this.chkRaw = new System.Windows.Forms.CheckBox();
            this.gbGeneral = new System.Windows.Forms.GroupBox();
            this.chkSound = new System.Windows.Forms.CheckBox();
            this.tabPgDirectories = new System.Windows.Forms.TabPage();
            this.gbDirectories = new System.Windows.Forms.GroupBox();
            this.chkUseSidecar = new System.Windows.Forms.CheckBox();
            this.chkSubDirectories = new System.Windows.Forms.CheckBox();
            this.txtOut = new System.Windows.Forms.TextBox();
            this.btnBrowseOut = new System.Windows.Forms.Button();
            this.tabPgXray = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbSecondaryDataSource = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.chkSoftHyphen = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMinClipLen = new System.Windows.Forms.TextBox();
            this.chkSkipNoLikes = new System.Windows.Forms.CheckBox();
            this.gbXray = new System.Windows.Forms.GroupBox();
            this.chkAndroid = new System.Windows.Forms.CheckBox();
            this.chkUseNew = new System.Windows.Forms.CheckBox();
            this.tabPgExtras = new System.Windows.Forms.TabPage();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.chkAutoBuildAP = new System.Windows.Forms.CheckBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.chkOverwriteSA = new System.Windows.Forms.CheckBox();
            this.chkOverwriteEA = new System.Windows.Forms.CheckBox();
            this.chkChapters = new System.Windows.Forms.CheckBox();
            this.chkAlias = new System.Windows.Forms.CheckBox();
            this.chkOverwriteAP = new System.Windows.Forms.CheckBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.chkDownloadAliases = new System.Windows.Forms.CheckBox();
            this.chkSplitAliases = new System.Windows.Forms.CheckBox();
            this.chkEnableEdit = new System.Windows.Forms.CheckBox();
            this.tabPgAmazon = new System.Windows.Forms.TabPage();
            this.gbAmazonPrefs = new System.Windows.Forms.GroupBox();
            this.chkEditBiography = new System.Windows.Forms.CheckBox();
            this.chkPromptAsin = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbRegion = new System.Windows.Forms.ComboBox();
            this.chkSaveBio = new System.Windows.Forms.CheckBox();
            this.gbDetails = new System.Windows.Forms.GroupBox();
            this.lblReal = new System.Windows.Forms.Label();
            this.txtReal = new System.Windows.Forms.TextBox();
            this.txtPen = new System.Windows.Forms.TextBox();
            this.lblPen = new System.Windows.Forms.Label();
            this.tabPgRoentgen = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbRoentgenRegion = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.chkIncludeTopics = new System.Windows.Forms.CheckBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.chkRoentgenAuthorProfile = new System.Windows.Forms.CheckBox();
            this.chkRoentgenEndActions = new System.Windows.Forms.CheckBox();
            this.chkRoentgenStartActions = new System.Windows.Forms.CheckBox();
            this.listSettings = new System.Windows.Forms.ListBox();
            this.cbLanguage = new System.Windows.Forms.GroupBox();
            this.cmbLanguage = new System.Windows.Forms.ComboBox();
            this.tabSettings.SuspendLayout();
            this.tabPgGeneral.SuspendLayout();
            this.gbProcess.SuspendLayout();
            this.gbUnpack.SuspendLayout();
            this.gbGeneral.SuspendLayout();
            this.tabPgDirectories.SuspendLayout();
            this.gbDirectories.SuspendLayout();
            this.tabPgXray.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.gbXray.SuspendLayout();
            this.tabPgExtras.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.tabPgAmazon.SuspendLayout();
            this.gbAmazonPrefs.SuspendLayout();
            this.gbDetails.SuspendLayout();
            this.tabPgRoentgen.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox2)).BeginInit();
            this.cbLanguage.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSupport
            // 
            this.btnSupport.Location = new System.Drawing.Point(328, 290);
            this.btnSupport.Name = "btnSupport";
            this.btnSupport.Size = new System.Drawing.Size(99, 30);
            this.btnSupport.TabIndex = 41;
            this.btnSupport.Text = "Forum";
            this.btnSupport.UseVisualStyleBackColor = true;
            this.btnSupport.Click += new System.EventHandler(this.btnSupport_Click);
            // 
            // btnClearLogs
            // 
            this.btnClearLogs.Location = new System.Drawing.Point(117, 290);
            this.btnClearLogs.Name = "btnClearLogs";
            this.btnClearLogs.Size = new System.Drawing.Size(99, 30);
            this.btnClearLogs.TabIndex = 39;
            this.btnClearLogs.Text = "Clear Logs";
            this.btnClearLogs.UseVisualStyleBackColor = true;
            this.btnClearLogs.Click += new System.EventHandler(this.btnClearLogs_Click);
            // 
            // btnLogs
            // 
            this.btnLogs.Location = new System.Drawing.Point(12, 290);
            this.btnLogs.Name = "btnLogs";
            this.btnLogs.Size = new System.Drawing.Size(99, 30);
            this.btnLogs.TabIndex = 38;
            this.btnLogs.Text = "Logs";
            this.btnLogs.UseVisualStyleBackColor = true;
            this.btnLogs.Click += new System.EventHandler(this.btnLogs_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(433, 290);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(99, 30);
            this.btnSave.TabIndex = 37;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblSeperator
            // 
            this.lblSeperator.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSeperator.Location = new System.Drawing.Point(0, 277);
            this.lblSeperator.Name = "lblSeperator";
            this.lblSeperator.Size = new System.Drawing.Size(546, 2);
            this.lblSeperator.TabIndex = 42;
            this.lblSeperator.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tabSettings
            // 
            this.tabSettings.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabSettings.Controls.Add(this.tabPgGeneral);
            this.tabSettings.Controls.Add(this.tabPgDirectories);
            this.tabSettings.Controls.Add(this.tabPgXray);
            this.tabSettings.Controls.Add(this.tabPgExtras);
            this.tabSettings.Controls.Add(this.tabPgAmazon);
            this.tabSettings.Controls.Add(this.tabPgRoentgen);
            this.tabSettings.ItemSize = new System.Drawing.Size(0, 1);
            this.tabSettings.Location = new System.Drawing.Point(144, 1);
            this.tabSettings.Name = "tabSettings";
            this.tabSettings.SelectedIndex = 0;
            this.tabSettings.Size = new System.Drawing.Size(398, 268);
            this.tabSettings.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabSettings.TabIndex = 43;
            // 
            // tabPgGeneral
            // 
            this.tabPgGeneral.Controls.Add(this.cbLanguage);
            this.tabPgGeneral.Controls.Add(this.gbProcess);
            this.tabPgGeneral.Controls.Add(this.gbUnpack);
            this.tabPgGeneral.Controls.Add(this.gbGeneral);
            this.tabPgGeneral.Location = new System.Drawing.Point(4, 5);
            this.tabPgGeneral.Name = "tabPgGeneral";
            this.tabPgGeneral.Padding = new System.Windows.Forms.Padding(3);
            this.tabPgGeneral.Size = new System.Drawing.Size(390, 259);
            this.tabPgGeneral.TabIndex = 0;
            this.tabPgGeneral.Text = "tabPage1";
            this.tabPgGeneral.UseVisualStyleBackColor = true;
            // 
            // gbProcess
            // 
            this.gbProcess.Controls.Add(this.chkPageCount);
            this.gbProcess.Location = new System.Drawing.Point(6, 116);
            this.gbProcess.Name = "gbProcess";
            this.gbProcess.Size = new System.Drawing.Size(378, 48);
            this.gbProcess.TabIndex = 38;
            this.gbProcess.TabStop = false;
            this.gbProcess.Text = "eBook Processing";
            // 
            // chkPageCount
            // 
            this.chkPageCount.AutoSize = true;
            this.chkPageCount.Location = new System.Drawing.Point(14, 19);
            this.chkPageCount.Name = "chkPageCount";
            this.chkPageCount.Size = new System.Drawing.Size(125, 17);
            this.chkPageCount.TabIndex = 34;
            this.chkPageCount.Text = "Estimate Page Count";
            this.chkPageCount.UseVisualStyleBackColor = true;
            // 
            // gbUnpack
            // 
            this.gbUnpack.Controls.Add(this.chkRaw);
            this.gbUnpack.Location = new System.Drawing.Point(6, 66);
            this.gbUnpack.Name = "gbUnpack";
            this.gbUnpack.Size = new System.Drawing.Size(378, 44);
            this.gbUnpack.TabIndex = 37;
            this.gbUnpack.TabStop = false;
            this.gbUnpack.Text = "eBook Unpacking";
            // 
            // chkRaw
            // 
            this.chkRaw.AutoSize = true;
            this.chkRaw.Location = new System.Drawing.Point(14, 19);
            this.chkRaw.Name = "chkRaw";
            this.chkRaw.Size = new System.Drawing.Size(81, 17);
            this.chkRaw.TabIndex = 32;
            this.chkRaw.Text = "Save rawml";
            this.chkRaw.UseVisualStyleBackColor = true;
            // 
            // gbGeneral
            // 
            this.gbGeneral.Controls.Add(this.chkSound);
            this.gbGeneral.Location = new System.Drawing.Point(6, 12);
            this.gbGeneral.Name = "gbGeneral";
            this.gbGeneral.Size = new System.Drawing.Size(378, 48);
            this.gbGeneral.TabIndex = 36;
            this.gbGeneral.TabStop = false;
            this.gbGeneral.Text = "Sounds";
            // 
            // chkSound
            // 
            this.chkSound.AutoSize = true;
            this.chkSound.Location = new System.Drawing.Point(14, 19);
            this.chkSound.Name = "chkSound";
            this.chkSound.Size = new System.Drawing.Size(216, 17);
            this.chkSound.TabIndex = 30;
            this.chkSound.Text = "Play a sound when a process completes";
            this.chkSound.UseVisualStyleBackColor = true;
            // 
            // tabPgDirectories
            // 
            this.tabPgDirectories.Controls.Add(this.gbDirectories);
            this.tabPgDirectories.Location = new System.Drawing.Point(4, 5);
            this.tabPgDirectories.Name = "tabPgDirectories";
            this.tabPgDirectories.Padding = new System.Windows.Forms.Padding(3);
            this.tabPgDirectories.Size = new System.Drawing.Size(390, 259);
            this.tabPgDirectories.TabIndex = 1;
            this.tabPgDirectories.Text = "tabPage2";
            this.tabPgDirectories.UseVisualStyleBackColor = true;
            // 
            // gbDirectories
            // 
            this.gbDirectories.Controls.Add(this.chkUseSidecar);
            this.gbDirectories.Controls.Add(this.chkSubDirectories);
            this.gbDirectories.Controls.Add(this.txtOut);
            this.gbDirectories.Controls.Add(this.btnBrowseOut);
            this.gbDirectories.Location = new System.Drawing.Point(6, 12);
            this.gbDirectories.Name = "gbDirectories";
            this.gbDirectories.Size = new System.Drawing.Size(378, 81);
            this.gbDirectories.TabIndex = 39;
            this.gbDirectories.TabStop = false;
            this.gbDirectories.Text = "Output Directory";
            // 
            // chkUseSidecar
            // 
            this.chkUseSidecar.AutoSize = true;
            this.chkUseSidecar.Location = new System.Drawing.Point(133, 52);
            this.chkUseSidecar.Name = "chkUseSidecar";
            this.chkUseSidecar.Size = new System.Drawing.Size(125, 17);
            this.chkUseSidecar.TabIndex = 27;
            this.chkUseSidecar.Text = "Use sidecar directory";
            this.chkUseSidecar.UseVisualStyleBackColor = true;
            // 
            // chkSubDirectories
            // 
            this.chkSubDirectories.AutoSize = true;
            this.chkSubDirectories.Location = new System.Drawing.Point(14, 52);
            this.chkSubDirectories.Name = "chkSubDirectories";
            this.chkSubDirectories.Size = new System.Drawing.Size(113, 17);
            this.chkSubDirectories.TabIndex = 26;
            this.chkSubDirectories.Text = "Use subdirectories";
            this.chkSubDirectories.UseVisualStyleBackColor = true;
            // 
            // txtOut
            // 
            this.txtOut.Location = new System.Drawing.Point(14, 20);
            this.txtOut.Name = "txtOut";
            this.txtOut.Size = new System.Drawing.Size(308, 20);
            this.txtOut.TabIndex = 12;
            // 
            // btnBrowseOut
            // 
            this.btnBrowseOut.Location = new System.Drawing.Point(331, 19);
            this.btnBrowseOut.Name = "btnBrowseOut";
            this.btnBrowseOut.Size = new System.Drawing.Size(34, 22);
            this.btnBrowseOut.TabIndex = 13;
            this.btnBrowseOut.Text = "...";
            this.btnBrowseOut.UseVisualStyleBackColor = true;
            this.btnBrowseOut.Click += new System.EventHandler(this.btnBrowseOut_Click);
            // 
            // tabPgXray
            // 
            this.tabPgXray.Controls.Add(this.groupBox2);
            this.tabPgXray.Controls.Add(this.groupBox4);
            this.tabPgXray.Controls.Add(this.groupBox3);
            this.tabPgXray.Controls.Add(this.gbXray);
            this.tabPgXray.Location = new System.Drawing.Point(4, 5);
            this.tabPgXray.Name = "tabPgXray";
            this.tabPgXray.Padding = new System.Windows.Forms.Padding(3);
            this.tabPgXray.Size = new System.Drawing.Size(390, 259);
            this.tabPgXray.TabIndex = 2;
            this.tabPgXray.Text = "tabPage3";
            this.tabPgXray.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmbSecondaryDataSource);
            this.groupBox2.Location = new System.Drawing.Point(202, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(182, 74);
            this.groupBox2.TabIndex = 27;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Data Provider";
            // 
            // cmbSecondaryDataSource
            // 
            this.cmbSecondaryDataSource.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSecondaryDataSource.FormattingEnabled = true;
            this.cmbSecondaryDataSource.Items.AddRange(new object[] {"Goodreads", "Shelfari", "LibraryThing"});
            this.cmbSecondaryDataSource.Location = new System.Drawing.Point(6, 31);
            this.cmbSecondaryDataSource.Name = "cmbSecondaryDataSource";
            this.cmbSecondaryDataSource.Size = new System.Drawing.Size(170, 21);
            this.cmbSecondaryDataSource.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.chkSoftHyphen);
            this.groupBox4.Location = new System.Drawing.Point(6, 146);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(378, 107);
            this.groupBox4.TabIndex = 28;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Preferences";
            // 
            // chkSoftHyphen
            // 
            this.chkSoftHyphen.AutoSize = true;
            this.chkSoftHyphen.Location = new System.Drawing.Point(14, 19);
            this.chkSoftHyphen.Name = "chkSoftHyphen";
            this.chkSoftHyphen.Size = new System.Drawing.Size(123, 17);
            this.chkSoftHyphen.TabIndex = 21;
            this.chkSoftHyphen.Text = "Ignore Soft Hyphens";
            this.chkSoftHyphen.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.txtMinClipLen);
            this.groupBox3.Controls.Add(this.chkSkipNoLikes);
            this.groupBox3.Location = new System.Drawing.Point(6, 92);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(378, 48);
            this.groupBox3.TabIndex = 27;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Notable Clips";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label2.Location = new System.Drawing.Point(168, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Minimum length:";
            // 
            // txtMinClipLen
            // 
            this.txtMinClipLen.Location = new System.Drawing.Point(257, 17);
            this.txtMinClipLen.Name = "txtMinClipLen";
            this.txtMinClipLen.Size = new System.Drawing.Size(47, 20);
            this.txtMinClipLen.TabIndex = 27;
            // 
            // chkSkipNoLikes
            // 
            this.chkSkipNoLikes.AutoSize = true;
            this.chkSkipNoLikes.Location = new System.Drawing.Point(14, 19);
            this.chkSkipNoLikes.Name = "chkSkipNoLikes";
            this.chkSkipNoLikes.Size = new System.Drawing.Size(129, 17);
            this.chkSkipNoLikes.TabIndex = 25;
            this.chkSkipNoLikes.Text = "Ignore clips w/ 0 likes";
            this.chkSkipNoLikes.UseVisualStyleBackColor = true;
            // 
            // gbXray
            // 
            this.gbXray.Controls.Add(this.chkAndroid);
            this.gbXray.Controls.Add(this.chkUseNew);
            this.gbXray.Location = new System.Drawing.Point(6, 12);
            this.gbXray.Name = "gbXray";
            this.gbXray.Size = new System.Drawing.Size(183, 74);
            this.gbXray.TabIndex = 26;
            this.gbXray.TabStop = false;
            this.gbXray.Text = "Format";
            // 
            // chkAndroid
            // 
            this.chkAndroid.AutoSize = true;
            this.chkAndroid.Location = new System.Drawing.Point(14, 45);
            this.chkAndroid.Name = "chkAndroid";
            this.chkAndroid.Size = new System.Drawing.Size(103, 17);
            this.chkAndroid.TabIndex = 23;
            this.chkAndroid.Text = "Build for Android";
            this.chkAndroid.UseVisualStyleBackColor = true;
            this.chkAndroid.CheckedChanged += new System.EventHandler(this.chkAndroid_CheckedChanged);
            // 
            // chkUseNew
            // 
            this.chkUseNew.AutoSize = true;
            this.chkUseNew.Location = new System.Drawing.Point(14, 19);
            this.chkUseNew.Name = "chkUseNew";
            this.chkUseNew.Size = new System.Drawing.Size(137, 17);
            this.chkUseNew.TabIndex = 22;
            this.chkUseNew.Text = "Use New X-Ray Format";
            this.chkUseNew.UseVisualStyleBackColor = true;
            // 
            // tabPgExtras
            // 
            this.tabPgExtras.Controls.Add(this.groupBox8);
            this.tabPgExtras.Controls.Add(this.groupBox6);
            this.tabPgExtras.Controls.Add(this.groupBox5);
            this.tabPgExtras.Location = new System.Drawing.Point(4, 5);
            this.tabPgExtras.Name = "tabPgExtras";
            this.tabPgExtras.Padding = new System.Windows.Forms.Padding(3);
            this.tabPgExtras.Size = new System.Drawing.Size(390, 259);
            this.tabPgExtras.TabIndex = 3;
            this.tabPgExtras.Text = "tabPage4";
            this.tabPgExtras.UseVisualStyleBackColor = true;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.chkAutoBuildAP);
            this.groupBox8.Location = new System.Drawing.Point(180, 12);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(204, 100);
            this.groupBox8.TabIndex = 32;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Author Profile";
            // 
            // chkAutoBuildAP
            // 
            this.chkAutoBuildAP.Location = new System.Drawing.Point(14, 19);
            this.chkAutoBuildAP.Name = "chkAutoBuildAP";
            this.chkAutoBuildAP.Size = new System.Drawing.Size(184, 31);
            this.chkAutoBuildAP.TabIndex = 24;
            this.chkAutoBuildAP.Text = "Build from downloaded End Actions when one is available";
            this.chkAutoBuildAP.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.chkOverwriteSA);
            this.groupBox6.Controls.Add(this.chkOverwriteEA);
            this.groupBox6.Controls.Add(this.chkChapters);
            this.groupBox6.Controls.Add(this.chkAlias);
            this.groupBox6.Controls.Add(this.chkOverwriteAP);
            this.groupBox6.Location = new System.Drawing.Point(6, 118);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(378, 100);
            this.groupBox6.TabIndex = 31;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Overwrite Options";
            // 
            // chkOverwriteSA
            // 
            this.chkOverwriteSA.AutoSize = true;
            this.chkOverwriteSA.Location = new System.Drawing.Point(120, 45);
            this.chkOverwriteSA.Name = "chkOverwriteSA";
            this.chkOverwriteSA.Size = new System.Drawing.Size(86, 17);
            this.chkOverwriteSA.TabIndex = 32;
            this.chkOverwriteSA.Text = "Start Actions";
            this.chkOverwriteSA.UseVisualStyleBackColor = true;
            // 
            // chkOverwriteEA
            // 
            this.chkOverwriteEA.AutoSize = true;
            this.chkOverwriteEA.Location = new System.Drawing.Point(120, 19);
            this.chkOverwriteEA.Name = "chkOverwriteEA";
            this.chkOverwriteEA.Size = new System.Drawing.Size(83, 17);
            this.chkOverwriteEA.TabIndex = 31;
            this.chkOverwriteEA.Text = "End Actions";
            this.chkOverwriteEA.UseVisualStyleBackColor = true;
            // 
            // chkChapters
            // 
            this.chkChapters.AutoSize = true;
            this.chkChapters.Location = new System.Drawing.Point(14, 71);
            this.chkChapters.Name = "chkChapters";
            this.chkChapters.Size = new System.Drawing.Size(68, 17);
            this.chkChapters.TabIndex = 23;
            this.chkChapters.Text = "Chapters";
            this.chkChapters.UseVisualStyleBackColor = true;
            // 
            // chkAlias
            // 
            this.chkAlias.AutoSize = true;
            this.chkAlias.Location = new System.Drawing.Point(14, 45);
            this.chkAlias.Name = "chkAlias";
            this.chkAlias.Size = new System.Drawing.Size(59, 17);
            this.chkAlias.TabIndex = 30;
            this.chkAlias.Text = "Aliases";
            this.chkAlias.UseVisualStyleBackColor = true;
            // 
            // chkOverwriteAP
            // 
            this.chkOverwriteAP.AutoSize = true;
            this.chkOverwriteAP.Location = new System.Drawing.Point(14, 19);
            this.chkOverwriteAP.Name = "chkOverwriteAP";
            this.chkOverwriteAP.Size = new System.Drawing.Size(89, 17);
            this.chkOverwriteAP.TabIndex = 26;
            this.chkOverwriteAP.Text = "Author Profile";
            this.chkOverwriteAP.UseVisualStyleBackColor = true;
            this.chkOverwriteAP.CheckedChanged += new System.EventHandler(this.chkOverwrite_CheckedChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.chkDownloadAliases);
            this.groupBox5.Controls.Add(this.chkSplitAliases);
            this.groupBox5.Controls.Add(this.chkEnableEdit);
            this.groupBox5.Location = new System.Drawing.Point(6, 12);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(162, 100);
            this.groupBox5.TabIndex = 26;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Aliases Options";
            // 
            // chkDownloadAliases
            // 
            this.chkDownloadAliases.AutoSize = true;
            this.chkDownloadAliases.Location = new System.Drawing.Point(14, 71);
            this.chkDownloadAliases.Name = "chkDownloadAliases";
            this.chkDownloadAliases.Size = new System.Drawing.Size(109, 17);
            this.chkDownloadAliases.TabIndex = 33;
            this.chkDownloadAliases.Text = "Download aliases";
            this.chkDownloadAliases.UseVisualStyleBackColor = true;
            this.chkDownloadAliases.Visible = false;
            this.chkDownloadAliases.CheckedChanged += new System.EventHandler(this.chkDownloadAliases_CheckedChanged);
            // 
            // chkSplitAliases
            // 
            this.chkSplitAliases.AutoSize = true;
            this.chkSplitAliases.Location = new System.Drawing.Point(14, 45);
            this.chkSplitAliases.Name = "chkSplitAliases";
            this.chkSplitAliases.Size = new System.Drawing.Size(144, 17);
            this.chkSplitAliases.TabIndex = 29;
            this.chkSplitAliases.Text = "Automatically split aliases";
            this.chkSplitAliases.UseVisualStyleBackColor = true;
            // 
            // chkEnableEdit
            // 
            this.chkEnableEdit.AutoSize = true;
            this.chkEnableEdit.Location = new System.Drawing.Point(14, 19);
            this.chkEnableEdit.Name = "chkEnableEdit";
            this.chkEnableEdit.Size = new System.Drawing.Size(140, 17);
            this.chkEnableEdit.TabIndex = 24;
            this.chkEnableEdit.Text = "Enable editing of aliases";
            this.chkEnableEdit.UseVisualStyleBackColor = true;
            // 
            // tabPgAmazon
            // 
            this.tabPgAmazon.Controls.Add(this.gbAmazonPrefs);
            this.tabPgAmazon.Controls.Add(this.gbDetails);
            this.tabPgAmazon.Location = new System.Drawing.Point(4, 5);
            this.tabPgAmazon.Name = "tabPgAmazon";
            this.tabPgAmazon.Padding = new System.Windows.Forms.Padding(3);
            this.tabPgAmazon.Size = new System.Drawing.Size(390, 259);
            this.tabPgAmazon.TabIndex = 4;
            this.tabPgAmazon.Text = "tabPage5";
            this.tabPgAmazon.UseVisualStyleBackColor = true;
            // 
            // gbAmazonPrefs
            // 
            this.gbAmazonPrefs.Controls.Add(this.chkEditBiography);
            this.gbAmazonPrefs.Controls.Add(this.chkPromptAsin);
            this.gbAmazonPrefs.Controls.Add(this.label1);
            this.gbAmazonPrefs.Controls.Add(this.cmbRegion);
            this.gbAmazonPrefs.Controls.Add(this.chkSaveBio);
            this.gbAmazonPrefs.Location = new System.Drawing.Point(6, 106);
            this.gbAmazonPrefs.Name = "gbAmazonPrefs";
            this.gbAmazonPrefs.Size = new System.Drawing.Size(378, 147);
            this.gbAmazonPrefs.TabIndex = 29;
            this.gbAmazonPrefs.TabStop = false;
            this.gbAmazonPrefs.Text = "Preferences";
            // 
            // chkEditBiography
            // 
            this.chkEditBiography.AutoSize = true;
            this.chkEditBiography.Location = new System.Drawing.Point(153, 45);
            this.chkEditBiography.Name = "chkEditBiography";
            this.chkEditBiography.Size = new System.Drawing.Size(126, 17);
            this.chkEditBiography.TabIndex = 29;
            this.chkEditBiography.Text = "Edit author biography";
            this.chkEditBiography.UseVisualStyleBackColor = true;
            // 
            // chkPromptAsin
            // 
            this.chkPromptAsin.AutoSize = true;
            this.chkPromptAsin.Location = new System.Drawing.Point(14, 19);
            this.chkPromptAsin.Name = "chkPromptAsin";
            this.chkPromptAsin.Size = new System.Drawing.Size(116, 17);
            this.chkPromptAsin.TabIndex = 27;
            this.chkPromptAsin.Text = "Show ASIN prompt";
            this.chkPromptAsin.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label1.Location = new System.Drawing.Point(12, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Region:";
            // 
            // cmbRegion
            // 
            this.cmbRegion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRegion.FormattingEnabled = true;
            this.cmbRegion.Location = new System.Drawing.Point(62, 71);
            this.cmbRegion.Name = "cmbRegion";
            this.cmbRegion.Size = new System.Drawing.Size(78, 21);
            this.cmbRegion.TabIndex = 25;
            // 
            // chkSaveBio
            // 
            this.chkSaveBio.AutoSize = true;
            this.chkSaveBio.Location = new System.Drawing.Point(14, 45);
            this.chkSaveBio.Name = "chkSaveBio";
            this.chkSaveBio.Size = new System.Drawing.Size(133, 17);
            this.chkSaveBio.TabIndex = 24;
            this.chkSaveBio.Text = "Save author biography";
            this.chkSaveBio.UseVisualStyleBackColor = true;
            // 
            // gbDetails
            // 
            this.gbDetails.Controls.Add(this.lblReal);
            this.gbDetails.Controls.Add(this.txtReal);
            this.gbDetails.Controls.Add(this.txtPen);
            this.gbDetails.Controls.Add(this.lblPen);
            this.gbDetails.Location = new System.Drawing.Point(6, 12);
            this.gbDetails.Name = "gbDetails";
            this.gbDetails.Size = new System.Drawing.Size(378, 88);
            this.gbDetails.TabIndex = 27;
            this.gbDetails.TabStop = false;
            this.gbDetails.Text = "Amazon Customer Details";
            // 
            // lblReal
            // 
            this.lblReal.AutoSize = true;
            this.lblReal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblReal.Location = new System.Drawing.Point(12, 23);
            this.lblReal.Name = "lblReal";
            this.lblReal.Size = new System.Drawing.Size(63, 13);
            this.lblReal.TabIndex = 17;
            this.lblReal.Text = "Real Name:";
            // 
            // txtReal
            // 
            this.txtReal.Location = new System.Drawing.Point(81, 20);
            this.txtReal.Name = "txtReal";
            this.txtReal.Size = new System.Drawing.Size(283, 20);
            this.txtReal.TabIndex = 18;
            // 
            // txtPen
            // 
            this.txtPen.Location = new System.Drawing.Point(81, 53);
            this.txtPen.Name = "txtPen";
            this.txtPen.Size = new System.Drawing.Size(283, 20);
            this.txtPen.TabIndex = 20;
            // 
            // lblPen
            // 
            this.lblPen.AutoSize = true;
            this.lblPen.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblPen.Location = new System.Drawing.Point(15, 56);
            this.lblPen.Name = "lblPen";
            this.lblPen.Size = new System.Drawing.Size(60, 13);
            this.lblPen.TabIndex = 19;
            this.lblPen.Text = "Pen Name:";
            // 
            // tabPgRoentgen
            // 
            this.tabPgRoentgen.Controls.Add(this.label5);
            this.tabPgRoentgen.Controls.Add(this.cmbRoentgenRegion);
            this.tabPgRoentgen.Controls.Add(this.label4);
            this.tabPgRoentgen.Controls.Add(this.groupBox9);
            this.tabPgRoentgen.Controls.Add(this.groupBox7);
            this.tabPgRoentgen.Location = new System.Drawing.Point(4, 5);
            this.tabPgRoentgen.Name = "tabPgRoentgen";
            this.tabPgRoentgen.Padding = new System.Windows.Forms.Padding(3);
            this.tabPgRoentgen.Size = new System.Drawing.Size(390, 259);
            this.tabPgRoentgen.TabIndex = 5;
            this.tabPgRoentgen.Text = "tabPgRoentgen";
            this.tabPgRoentgen.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label5.Location = new System.Drawing.Point(9, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(199, 32);
            this.label5.TabIndex = 40;
            this.label5.Text = "Files will be downloaded in the language of the selected region, when possible.";
            // 
            // cmbRoentgenRegion
            // 
            this.cmbRoentgenRegion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRoentgenRegion.FormattingEnabled = true;
            this.cmbRoentgenRegion.Location = new System.Drawing.Point(59, 142);
            this.cmbRoentgenRegion.Name = "cmbRoentgenRegion";
            this.cmbRoentgenRegion.Size = new System.Drawing.Size(149, 21);
            this.cmbRoentgenRegion.TabIndex = 38;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label4.Location = new System.Drawing.Point(9, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 39;
            this.label4.Text = "Region:";
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.chkIncludeTopics);
            this.groupBox9.Location = new System.Drawing.Point(8, 87);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(200, 49);
            this.groupBox9.TabIndex = 28;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Terms Download";
            // 
            // chkIncludeTopics
            // 
            this.chkIncludeTopics.AutoSize = true;
            this.chkIncludeTopics.Location = new System.Drawing.Point(14, 21);
            this.chkIncludeTopics.Name = "chkIncludeTopics";
            this.chkIncludeTopics.Size = new System.Drawing.Size(157, 17);
            this.chkIncludeTopics.TabIndex = 25;
            this.chkIncludeTopics.Text = "Include topic/location terms";
            this.chkIncludeTopics.UseVisualStyleBackColor = true;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.pictureBox2);
            this.groupBox7.Controls.Add(this.label3);
            this.groupBox7.Controls.Add(this.chkRoentgenAuthorProfile);
            this.groupBox7.Controls.Add(this.chkRoentgenEndActions);
            this.groupBox7.Controls.Add(this.chkRoentgenStartActions);
            this.groupBox7.Location = new System.Drawing.Point(6, 7);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(378, 74);
            this.groupBox7.TabIndex = 27;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Pre-built Downloads";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image) (resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(123, 25);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(14, 14);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 37;
            this.pictureBox2.TabStop = false;
            // 
            // label3
            // 
            this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Location = new System.Drawing.Point(143, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(229, 48);
            this.label3.TabIndex = 36;
            this.label3.Text = "When these settings are enabled, pre-built versions of the files will be download" + "ed if they are available. Requires a valid ASIN.";
            // 
            // chkRoentgenAuthorProfile
            // 
            this.chkRoentgenAuthorProfile.AutoSize = true;
            this.chkRoentgenAuthorProfile.Location = new System.Drawing.Point(106, 54);
            this.chkRoentgenAuthorProfile.Name = "chkRoentgenAuthorProfile";
            this.chkRoentgenAuthorProfile.Size = new System.Drawing.Size(89, 17);
            this.chkRoentgenAuthorProfile.TabIndex = 33;
            this.chkRoentgenAuthorProfile.Text = "Author Profile";
            this.chkRoentgenAuthorProfile.UseVisualStyleBackColor = true;
            this.chkRoentgenAuthorProfile.Visible = false;
            // 
            // chkRoentgenEndActions
            // 
            this.chkRoentgenEndActions.AutoSize = true;
            this.chkRoentgenEndActions.Location = new System.Drawing.Point(14, 24);
            this.chkRoentgenEndActions.Name = "chkRoentgenEndActions";
            this.chkRoentgenEndActions.Size = new System.Drawing.Size(83, 17);
            this.chkRoentgenEndActions.TabIndex = 29;
            this.chkRoentgenEndActions.Text = "End Actions";
            this.chkRoentgenEndActions.UseVisualStyleBackColor = true;
            // 
            // chkRoentgenStartActions
            // 
            this.chkRoentgenStartActions.AutoSize = true;
            this.chkRoentgenStartActions.Location = new System.Drawing.Point(14, 47);
            this.chkRoentgenStartActions.Name = "chkRoentgenStartActions";
            this.chkRoentgenStartActions.Size = new System.Drawing.Size(86, 17);
            this.chkRoentgenStartActions.TabIndex = 24;
            this.chkRoentgenStartActions.Text = "Start Actions";
            this.chkRoentgenStartActions.UseVisualStyleBackColor = true;
            // 
            // listSettings
            // 
            this.listSettings.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.listSettings.FormattingEnabled = true;
            this.listSettings.IntegralHeight = false;
            this.listSettings.ItemHeight = 20;
            this.listSettings.Items.AddRange(new object[] {"General", "Directories", "X-Ray", "Extras", "Amazon", "Roentgen"});
            this.listSettings.Location = new System.Drawing.Point(12, 12);
            this.listSettings.Name = "listSettings";
            this.listSettings.Size = new System.Drawing.Size(130, 253);
            this.listSettings.TabIndex = 38;
            this.listSettings.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.listSettings_DrawItem);
            this.listSettings.MeasureItem += new System.Windows.Forms.MeasureItemEventHandler(this.listSettings_MeasureItem);
            this.listSettings.SelectedIndexChanged += new System.EventHandler(this.listSettings_SelectedIndexChanged);
            // 
            // cbLanguage
            // 
            this.cbLanguage.Controls.Add(this.cmbLanguage);
            this.cbLanguage.Location = new System.Drawing.Point(6, 171);
            this.cbLanguage.Name = "cbLanguage";
            this.cbLanguage.Size = new System.Drawing.Size(377, 55);
            this.cbLanguage.TabIndex = 39;
            this.cbLanguage.TabStop = false;
            this.cbLanguage.Text = "Language";
            // 
            // cmbLanguage
            // 
            this.cmbLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLanguage.FormattingEnabled = true;
            this.cmbLanguage.Location = new System.Drawing.Point(6, 19);
            this.cmbLanguage.Name = "cmbLanguage";
            this.cmbLanguage.Size = new System.Drawing.Size(160, 21);
            this.cmbLanguage.TabIndex = 0;
            // 
            // frmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 331);
            this.Controls.Add(this.listSettings);
            this.Controls.Add(this.tabSettings);
            this.Controls.Add(this.lblSeperator);
            this.Controls.Add(this.btnSupport);
            this.Controls.Add(this.btnClearLogs);
            this.Controls.Add(this.btnLogs);
            this.Controls.Add(this.btnSave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon) (resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSettings";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.frmSettingsNew_Load);
            this.tabSettings.ResumeLayout(false);
            this.tabPgGeneral.ResumeLayout(false);
            this.gbProcess.ResumeLayout(false);
            this.gbProcess.PerformLayout();
            this.gbUnpack.ResumeLayout(false);
            this.gbUnpack.PerformLayout();
            this.gbGeneral.ResumeLayout(false);
            this.gbGeneral.PerformLayout();
            this.tabPgDirectories.ResumeLayout(false);
            this.gbDirectories.ResumeLayout(false);
            this.gbDirectories.PerformLayout();
            this.tabPgXray.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.gbXray.ResumeLayout(false);
            this.gbXray.PerformLayout();
            this.tabPgExtras.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.tabPgAmazon.ResumeLayout(false);
            this.gbAmazonPrefs.ResumeLayout(false);
            this.gbAmazonPrefs.PerformLayout();
            this.gbDetails.ResumeLayout(false);
            this.gbDetails.PerformLayout();
            this.tabPgRoentgen.ResumeLayout(false);
            this.tabPgRoentgen.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox2)).EndInit();
            this.cbLanguage.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.GroupBox cbLanguage;
        private System.Windows.Forms.ComboBox cmbLanguage;

        private System.Windows.Forms.Button btnBrowseOut;
        private System.Windows.Forms.Button btnClearLogs;
        private System.Windows.Forms.Button btnLogs;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnSupport;
        private System.Windows.Forms.CheckBox chkAlias;
        private System.Windows.Forms.CheckBox chkAndroid;
        private System.Windows.Forms.CheckBox chkAutoBuildAP;
        private System.Windows.Forms.CheckBox chkChapters;
        private System.Windows.Forms.CheckBox chkDownloadAliases;
        private System.Windows.Forms.CheckBox chkEditBiography;
        private System.Windows.Forms.CheckBox chkEnableEdit;
        private System.Windows.Forms.CheckBox chkIncludeTopics;
        private System.Windows.Forms.CheckBox chkOverwriteAP;
        private System.Windows.Forms.CheckBox chkOverwriteEA;
        private System.Windows.Forms.CheckBox chkOverwriteSA;
        private System.Windows.Forms.CheckBox chkPageCount;
        private System.Windows.Forms.CheckBox chkPromptAsin;
        private System.Windows.Forms.CheckBox chkRaw;
        private System.Windows.Forms.CheckBox chkRoentgenAuthorProfile;
        private System.Windows.Forms.CheckBox chkRoentgenEndActions;
        private System.Windows.Forms.CheckBox chkRoentgenStartActions;
        private System.Windows.Forms.CheckBox chkSaveBio;
        private System.Windows.Forms.CheckBox chkSkipNoLikes;
        private System.Windows.Forms.CheckBox chkSoftHyphen;
        private System.Windows.Forms.CheckBox chkSound;
        private System.Windows.Forms.CheckBox chkSplitAliases;
        private System.Windows.Forms.CheckBox chkSubDirectories;
        private System.Windows.Forms.CheckBox chkUseNew;
        private System.Windows.Forms.CheckBox chkUseSidecar;
        private System.Windows.Forms.ComboBox cmbRegion;
        private System.Windows.Forms.ComboBox cmbRoentgenRegion;
        private System.Windows.Forms.GroupBox gbAmazonPrefs;
        private System.Windows.Forms.GroupBox gbDetails;
        private System.Windows.Forms.GroupBox gbDirectories;
        private System.Windows.Forms.GroupBox gbGeneral;
        private System.Windows.Forms.GroupBox gbProcess;
        private System.Windows.Forms.GroupBox gbUnpack;
        private System.Windows.Forms.GroupBox gbXray;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblPen;
        private System.Windows.Forms.Label lblReal;
        private System.Windows.Forms.Label lblSeperator;
        private System.Windows.Forms.ListBox listSettings;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TabPage tabPgAmazon;
        private System.Windows.Forms.TabPage tabPgDirectories;
        private System.Windows.Forms.TabPage tabPgExtras;
        private System.Windows.Forms.TabPage tabPgGeneral;
        private System.Windows.Forms.TabPage tabPgRoentgen;
        private System.Windows.Forms.TabPage tabPgXray;
        private System.Windows.Forms.TabControl tabSettings;
        private System.Windows.Forms.TextBox txtMinClipLen;
        private System.Windows.Forms.TextBox txtOut;
        private System.Windows.Forms.TextBox txtPen;
        private System.Windows.Forms.TextBox txtReal;

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbSecondaryDataSource;
    }
}