namespace di_SuperVisor
{
    partial class di_SuperVisor
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
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(di_SuperVisor));
            this.statusStripMain = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelRefreshRate = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelUsersCon = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabPageProcesses = new System.Windows.Forms.TabPage();
            this.label_ = new System.Windows.Forms.Label();
            this.buttonClearLogs = new System.Windows.Forms.Button();
            this.textBoxCommand = new System.Windows.Forms.TextBox();
            this.buttonSend = new System.Windows.Forms.Button();
            this.groupBoxLog = new System.Windows.Forms.GroupBox();
            this.labelClientList = new System.Windows.Forms.Label();
            this.listBoxClientList = new System.Windows.Forms.ListBox();
            this.listBoxLog = new System.Windows.Forms.ListBox();
            this.groupBoxExecutables = new System.Windows.Forms.GroupBox();
            this.buttonClearExe = new System.Windows.Forms.Button();
            this.buttonFileLock = new System.Windows.Forms.Button();
            this.labelFilesIsActive = new System.Windows.Forms.Label();
            this.checkedListBoxExe = new System.Windows.Forms.CheckedListBox();
            this.buttonFilesBrowse = new System.Windows.Forms.Button();
            this.groupBoxRemote = new System.Windows.Forms.GroupBox();
            this.groupBoxConnection = new System.Windows.Forms.GroupBox();
            this.buttonLogOff = new System.Windows.Forms.Button();
            this.labelConnectInfo = new System.Windows.Forms.Label();
            this.buttonRemoteConnect = new System.Windows.Forms.Button();
            this.comboBoxConnectTo = new System.Windows.Forms.ComboBox();
            this.checkBoxIsRemote = new System.Windows.Forms.CheckBox();
            this.panelMain = new System.Windows.Forms.Panel();
            this.groupBoxProcess = new System.Windows.Forms.GroupBox();
            this.panelProcessList = new System.Windows.Forms.Panel();
            this.listBoxProcList = new System.Windows.Forms.ListBox();
            this.labelStatusInd = new System.Windows.Forms.Label();
            this.tabPageInformation = new System.Windows.Forms.TabPage();
            this.panelMainInformation = new System.Windows.Forms.Panel();
            this.groupBoxComputerInfo = new System.Windows.Forms.GroupBox();
            this.labelCpuCores = new System.Windows.Forms.Label();
            this.labelCpuSpeed = new System.Windows.Forms.Label();
            this.labelToralRAM = new System.Windows.Forms.Label();
            this.groupBoxRAMContainer = new System.Windows.Forms.GroupBox();
            this.labelRamBottom = new System.Windows.Forms.Label();
            this.labelRamTop = new System.Windows.Forms.Label();
            this.labelRAM = new System.Windows.Forms.Label();
            this.chartRAM = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBoxCPUContainer = new System.Windows.Forms.GroupBox();
            this.labelCpuMiddle = new System.Windows.Forms.Label();
            this.labelCpuBottom = new System.Windows.Forms.Label();
            this.labelCpuTop = new System.Windows.Forms.Label();
            this.chartCPU = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.labelCPU = new System.Windows.Forms.Label();
            this.panelDriveInformation = new System.Windows.Forms.Panel();
            this.groupBoxDrive = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanelDrive = new System.Windows.Forms.FlowLayoutPanel();
            this.panelToolStripInformation = new System.Windows.Forms.Panel();
            this.labelDriveRefreshTimer = new System.Windows.Forms.Label();
            this.labelPerformanceTicPer10 = new System.Windows.Forms.Label();
            this.textBoxPerformanceTicRate = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.buttonDriveTest = new System.Windows.Forms.Button();
            this.buttonPerformanceTest = new System.Windows.Forms.Button();
            this.tabPageProcessesSettings = new System.Windows.Forms.TabPage();
            this.panelConfigMain = new System.Windows.Forms.Panel();
            this.groupBoxControll = new System.Windows.Forms.GroupBox();
            this.radioButtonMainOff = new System.Windows.Forms.RadioButton();
            this.radioButtonMainOn = new System.Windows.Forms.RadioButton();
            this.groupBoxIPList = new System.Windows.Forms.GroupBox();
            this.listBoxIPList = new System.Windows.Forms.ListBox();
            this.groupBoxNewIP = new System.Windows.Forms.GroupBox();
            this.checkBoxAdminCmd = new System.Windows.Forms.CheckBox();
            this.labelNewIPDesc = new System.Windows.Forms.Label();
            this.labelNewIP = new System.Windows.Forms.Label();
            this.buttonNewIPSave = new System.Windows.Forms.Button();
            this.richTextBoxIPDesc = new System.Windows.Forms.RichTextBox();
            this.textBoxNewIP = new System.Windows.Forms.TextBox();
            this.panelConfigMinor = new System.Windows.Forms.Panel();
            this.buttonCustomSettingsApply = new System.Windows.Forms.Button();
            this.groupBoxButtonSettings = new System.Windows.Forms.GroupBox();
            this.checkBoxIsRemoteSetting = new System.Windows.Forms.CheckBox();
            this.groupBoxTimerSettings = new System.Windows.Forms.GroupBox();
            this.labelTimerSetting = new System.Windows.Forms.Label();
            this.numericUpDownTimer = new System.Windows.Forms.NumericUpDown();
            this.groupBoxCMDLineSettings = new System.Windows.Forms.GroupBox();
            this.checkBoxCMDDisplay = new System.Windows.Forms.CheckBox();
            this.tabPageAbout = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.labelProductName = new System.Windows.Forms.Label();
            this.labelVersion = new System.Windows.Forms.Label();
            this.labelCopyright = new System.Windows.Forms.Label();
            this.labelCompanyName = new System.Windows.Forms.Label();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.okButton = new System.Windows.Forms.Button();
            this.tabPageTesting = new System.Windows.Forms.TabPage();
            this.panelTEST = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.labelTest = new System.Windows.Forms.Label();
            this.buttonTest = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.panelIndDrive = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelDriveTop1 = new System.Windows.Forms.Label();
            this.labelDriveBot1 = new System.Windows.Forms.Label();
            this.openFileDialogExecutables = new System.Windows.Forms.OpenFileDialog();
            this.labelConnectedTo = new System.Windows.Forms.Label();
            this.labelConnectedToRes = new System.Windows.Forms.Label();
            this.statusStripMain.SuspendLayout();
            this.tabControlMain.SuspendLayout();
            this.tabPageProcesses.SuspendLayout();
            this.groupBoxLog.SuspendLayout();
            this.groupBoxExecutables.SuspendLayout();
            this.groupBoxRemote.SuspendLayout();
            this.groupBoxConnection.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.groupBoxProcess.SuspendLayout();
            this.panelProcessList.SuspendLayout();
            this.tabPageInformation.SuspendLayout();
            this.panelMainInformation.SuspendLayout();
            this.groupBoxComputerInfo.SuspendLayout();
            this.groupBoxRAMContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartRAM)).BeginInit();
            this.groupBoxCPUContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartCPU)).BeginInit();
            this.panelDriveInformation.SuspendLayout();
            this.groupBoxDrive.SuspendLayout();
            this.panelToolStripInformation.SuspendLayout();
            this.tabPageProcessesSettings.SuspendLayout();
            this.panelConfigMain.SuspendLayout();
            this.groupBoxControll.SuspendLayout();
            this.groupBoxIPList.SuspendLayout();
            this.groupBoxNewIP.SuspendLayout();
            this.panelConfigMinor.SuspendLayout();
            this.groupBoxButtonSettings.SuspendLayout();
            this.groupBoxTimerSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTimer)).BeginInit();
            this.groupBoxCMDLineSettings.SuspendLayout();
            this.tabPageAbout.SuspendLayout();
            this.tableLayoutPanel.SuspendLayout();
            this.tabPageTesting.SuspendLayout();
            this.panelTEST.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panel1.SuspendLayout();
            this.panelIndDrive.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStripMain
            // 
            this.statusStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelRefreshRate,
            this.toolStripStatusLabelUsersCon,
            this.toolStripStatusLabelTime});
            this.statusStripMain.Location = new System.Drawing.Point(0, 512);
            this.statusStripMain.Name = "statusStripMain";
            this.statusStripMain.Size = new System.Drawing.Size(846, 22);
            this.statusStripMain.TabIndex = 5;
            // 
            // toolStripStatusLabelRefreshRate
            // 
            this.toolStripStatusLabelRefreshRate.Name = "toolStripStatusLabelRefreshRate";
            this.toolStripStatusLabelRefreshRate.Size = new System.Drawing.Size(82, 17);
            this.toolStripStatusLabelRefreshRate.Text = "*Refresh Rate*";
            // 
            // toolStripStatusLabelUsersCon
            // 
            this.toolStripStatusLabelUsersCon.Name = "toolStripStatusLabelUsersCon";
            this.toolStripStatusLabelUsersCon.Size = new System.Drawing.Size(70, 17);
            this.toolStripStatusLabelUsersCon.Text = "*Users Con*";
            // 
            // toolStripStatusLabelTime
            // 
            this.toolStripStatusLabelTime.Name = "toolStripStatusLabelTime";
            this.toolStripStatusLabelTime.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.toolStripStatusLabelTime.Size = new System.Drawing.Size(44, 17);
            this.toolStripStatusLabelTime.Text = "*Time*";
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabPageProcesses);
            this.tabControlMain.Controls.Add(this.tabPageInformation);
            this.tabControlMain.Controls.Add(this.tabPageProcessesSettings);
            this.tabControlMain.Controls.Add(this.tabPageAbout);
            this.tabControlMain.Controls.Add(this.tabPageTesting);
            this.tabControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlMain.Location = new System.Drawing.Point(0, 0);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(846, 512);
            this.tabControlMain.TabIndex = 6;
            // 
            // tabPageProcesses
            // 
            this.tabPageProcesses.BackColor = System.Drawing.SystemColors.Control;
            this.tabPageProcesses.Controls.Add(this.label_);
            this.tabPageProcesses.Controls.Add(this.buttonClearLogs);
            this.tabPageProcesses.Controls.Add(this.textBoxCommand);
            this.tabPageProcesses.Controls.Add(this.buttonSend);
            this.tabPageProcesses.Controls.Add(this.groupBoxLog);
            this.tabPageProcesses.Controls.Add(this.groupBoxExecutables);
            this.tabPageProcesses.Controls.Add(this.groupBoxRemote);
            this.tabPageProcesses.Controls.Add(this.panelMain);
            this.tabPageProcesses.Location = new System.Drawing.Point(4, 22);
            this.tabPageProcesses.Name = "tabPageProcesses";
            this.tabPageProcesses.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageProcesses.Size = new System.Drawing.Size(838, 486);
            this.tabPageProcesses.TabIndex = 0;
            this.tabPageProcesses.Text = "Processes";
            // 
            // label_
            // 
            this.label_.AutoSize = true;
            this.label_.Location = new System.Drawing.Point(302, 42);
            this.label_.Name = "label_";
            this.label_.Size = new System.Drawing.Size(35, 13);
            this.label_.TabIndex = 12;
            this.label_.Text = "label3";
            // 
            // buttonClearLogs
            // 
            this.buttonClearLogs.Location = new System.Drawing.Point(788, 441);
            this.buttonClearLogs.Name = "buttonClearLogs";
            this.buttonClearLogs.Size = new System.Drawing.Size(44, 23);
            this.buttonClearLogs.TabIndex = 1;
            this.buttonClearLogs.Text = "Clear";
            this.buttonClearLogs.UseVisualStyleBackColor = true;
            // 
            // textBoxCommand
            // 
            this.textBoxCommand.Location = new System.Drawing.Point(402, 445);
            this.textBoxCommand.Name = "textBoxCommand";
            this.textBoxCommand.Size = new System.Drawing.Size(299, 20);
            this.textBoxCommand.TabIndex = 5;
            // 
            // buttonSend
            // 
            this.buttonSend.Location = new System.Drawing.Point(707, 441);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(64, 24);
            this.buttonSend.TabIndex = 4;
            this.buttonSend.Text = "Send";
            this.buttonSend.UseVisualStyleBackColor = true;
            // 
            // groupBoxLog
            // 
            this.groupBoxLog.Controls.Add(this.labelClientList);
            this.groupBoxLog.Controls.Add(this.listBoxClientList);
            this.groupBoxLog.Controls.Add(this.listBoxLog);
            this.groupBoxLog.Location = new System.Drawing.Point(402, 6);
            this.groupBoxLog.Name = "groupBoxLog";
            this.groupBoxLog.Size = new System.Drawing.Size(432, 433);
            this.groupBoxLog.TabIndex = 11;
            this.groupBoxLog.TabStop = false;
            this.groupBoxLog.Text = "Log";
            // 
            // labelClientList
            // 
            this.labelClientList.AutoSize = true;
            this.labelClientList.Location = new System.Drawing.Point(332, 0);
            this.labelClientList.Name = "labelClientList";
            this.labelClientList.Size = new System.Drawing.Size(52, 13);
            this.labelClientList.TabIndex = 7;
            this.labelClientList.Text = "Client List";
            // 
            // listBoxClientList
            // 
            this.listBoxClientList.Dock = System.Windows.Forms.DockStyle.Right;
            this.listBoxClientList.FormattingEnabled = true;
            this.listBoxClientList.Location = new System.Drawing.Point(326, 16);
            this.listBoxClientList.Name = "listBoxClientList";
            this.listBoxClientList.Size = new System.Drawing.Size(103, 414);
            this.listBoxClientList.TabIndex = 1;
            // 
            // listBoxLog
            // 
            this.listBoxLog.Dock = System.Windows.Forms.DockStyle.Left;
            this.listBoxLog.FormattingEnabled = true;
            this.listBoxLog.Location = new System.Drawing.Point(3, 16);
            this.listBoxLog.Name = "listBoxLog";
            this.listBoxLog.Size = new System.Drawing.Size(317, 414);
            this.listBoxLog.TabIndex = 0;
            // 
            // groupBoxExecutables
            // 
            this.groupBoxExecutables.Controls.Add(this.buttonClearExe);
            this.groupBoxExecutables.Controls.Add(this.buttonFileLock);
            this.groupBoxExecutables.Controls.Add(this.labelFilesIsActive);
            this.groupBoxExecutables.Controls.Add(this.checkedListBoxExe);
            this.groupBoxExecutables.Controls.Add(this.buttonFilesBrowse);
            this.groupBoxExecutables.Location = new System.Drawing.Point(199, 89);
            this.groupBoxExecutables.Name = "groupBoxExecutables";
            this.groupBoxExecutables.Size = new System.Drawing.Size(197, 376);
            this.groupBoxExecutables.TabIndex = 10;
            this.groupBoxExecutables.TabStop = false;
            this.groupBoxExecutables.Text = "Files/Executables";
            // 
            // buttonClearExe
            // 
            this.buttonClearExe.Location = new System.Drawing.Point(6, 347);
            this.buttonClearExe.Name = "buttonClearExe";
            this.buttonClearExe.Size = new System.Drawing.Size(75, 23);
            this.buttonClearExe.TabIndex = 4;
            this.buttonClearExe.Text = "Clear";
            this.buttonClearExe.UseVisualStyleBackColor = true;
            // 
            // buttonFileLock
            // 
            this.buttonFileLock.Location = new System.Drawing.Point(133, 19);
            this.buttonFileLock.Name = "buttonFileLock";
            this.buttonFileLock.Size = new System.Drawing.Size(58, 26);
            this.buttonFileLock.TabIndex = 3;
            this.buttonFileLock.Text = "Lock";
            this.buttonFileLock.UseVisualStyleBackColor = true;
            this.buttonFileLock.Click += new System.EventHandler(this.buttonFileLock_Click);
            // 
            // labelFilesIsActive
            // 
            this.labelFilesIsActive.AutoSize = true;
            this.labelFilesIsActive.Location = new System.Drawing.Point(8, 35);
            this.labelFilesIsActive.Name = "labelFilesIsActive";
            this.labelFilesIsActive.Size = new System.Drawing.Size(37, 13);
            this.labelFilesIsActive.TabIndex = 2;
            this.labelFilesIsActive.Text = "Active";
            // 
            // checkedListBoxExe
            // 
            this.checkedListBoxExe.FormattingEnabled = true;
            this.checkedListBoxExe.Location = new System.Drawing.Point(11, 52);
            this.checkedListBoxExe.Name = "checkedListBoxExe";
            this.checkedListBoxExe.Size = new System.Drawing.Size(180, 289);
            this.checkedListBoxExe.TabIndex = 1;
            this.checkedListBoxExe.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkedListBoxExe_ItemCheck);
            // 
            // buttonFilesBrowse
            // 
            this.buttonFilesBrowse.Location = new System.Drawing.Point(70, 19);
            this.buttonFilesBrowse.Name = "buttonFilesBrowse";
            this.buttonFilesBrowse.Size = new System.Drawing.Size(57, 26);
            this.buttonFilesBrowse.TabIndex = 0;
            this.buttonFilesBrowse.Text = "Browse";
            this.buttonFilesBrowse.UseVisualStyleBackColor = true;
            this.buttonFilesBrowse.Click += new System.EventHandler(this.buttonFilesBrowse_Click);
            // 
            // groupBoxRemote
            // 
            this.groupBoxRemote.Controls.Add(this.groupBoxConnection);
            this.groupBoxRemote.Controls.Add(this.checkBoxIsRemote);
            this.groupBoxRemote.Location = new System.Drawing.Point(6, 6);
            this.groupBoxRemote.Name = "groupBoxRemote";
            this.groupBoxRemote.Size = new System.Drawing.Size(266, 83);
            this.groupBoxRemote.TabIndex = 9;
            this.groupBoxRemote.TabStop = false;
            this.groupBoxRemote.Text = "Remote configuration";
            // 
            // groupBoxConnection
            // 
            this.groupBoxConnection.Controls.Add(this.buttonLogOff);
            this.groupBoxConnection.Controls.Add(this.labelConnectInfo);
            this.groupBoxConnection.Controls.Add(this.buttonRemoteConnect);
            this.groupBoxConnection.Controls.Add(this.comboBoxConnectTo);
            this.groupBoxConnection.Location = new System.Drawing.Point(6, 30);
            this.groupBoxConnection.Name = "groupBoxConnection";
            this.groupBoxConnection.Size = new System.Drawing.Size(255, 47);
            this.groupBoxConnection.TabIndex = 10;
            this.groupBoxConnection.TabStop = false;
            // 
            // buttonLogOff
            // 
            this.buttonLogOff.Location = new System.Drawing.Point(191, 13);
            this.buttonLogOff.Name = "buttonLogOff";
            this.buttonLogOff.Size = new System.Drawing.Size(58, 23);
            this.buttonLogOff.TabIndex = 7;
            this.buttonLogOff.Text = "Log off";
            this.buttonLogOff.UseVisualStyleBackColor = true;
            // 
            // labelConnectInfo
            // 
            this.labelConnectInfo.AutoSize = true;
            this.labelConnectInfo.Location = new System.Drawing.Point(6, 16);
            this.labelConnectInfo.Name = "labelConnectInfo";
            this.labelConnectInfo.Size = new System.Drawing.Size(62, 13);
            this.labelConnectInfo.TabIndex = 2;
            this.labelConnectInfo.Text = "Connect to:";
            // 
            // buttonRemoteConnect
            // 
            this.buttonRemoteConnect.Location = new System.Drawing.Point(127, 13);
            this.buttonRemoteConnect.Name = "buttonRemoteConnect";
            this.buttonRemoteConnect.Size = new System.Drawing.Size(58, 23);
            this.buttonRemoteConnect.TabIndex = 6;
            this.buttonRemoteConnect.Text = "Connect";
            this.buttonRemoteConnect.UseVisualStyleBackColor = true;
            // 
            // comboBoxConnectTo
            // 
            this.comboBoxConnectTo.FormattingEnabled = true;
            this.comboBoxConnectTo.Location = new System.Drawing.Point(74, 13);
            this.comboBoxConnectTo.Name = "comboBoxConnectTo";
            this.comboBoxConnectTo.Size = new System.Drawing.Size(47, 21);
            this.comboBoxConnectTo.TabIndex = 3;
            // 
            // checkBoxIsRemote
            // 
            this.checkBoxIsRemote.AutoSize = true;
            this.checkBoxIsRemote.Location = new System.Drawing.Point(6, 15);
            this.checkBoxIsRemote.Name = "checkBoxIsRemote";
            this.checkBoxIsRemote.Size = new System.Drawing.Size(52, 17);
            this.checkBoxIsRemote.TabIndex = 5;
            this.checkBoxIsRemote.Text = "Local";
            this.checkBoxIsRemote.UseVisualStyleBackColor = true;
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.groupBoxProcess);
            this.panelMain.Location = new System.Drawing.Point(6, 89);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(187, 376);
            this.panelMain.TabIndex = 4;
            // 
            // groupBoxProcess
            // 
            this.groupBoxProcess.Controls.Add(this.panelProcessList);
            this.groupBoxProcess.Controls.Add(this.labelStatusInd);
            this.groupBoxProcess.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxProcess.Location = new System.Drawing.Point(0, 0);
            this.groupBoxProcess.Name = "groupBoxProcess";
            this.groupBoxProcess.Size = new System.Drawing.Size(187, 376);
            this.groupBoxProcess.TabIndex = 4;
            this.groupBoxProcess.TabStop = false;
            this.groupBoxProcess.Text = "Process list";
            // 
            // panelProcessList
            // 
            this.panelProcessList.Controls.Add(this.listBoxProcList);
            this.panelProcessList.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelProcessList.Location = new System.Drawing.Point(3, 16);
            this.panelProcessList.Name = "panelProcessList";
            this.panelProcessList.Size = new System.Drawing.Size(169, 357);
            this.panelProcessList.TabIndex = 1;
            // 
            // listBoxProcList
            // 
            this.listBoxProcList.Dock = System.Windows.Forms.DockStyle.Left;
            this.listBoxProcList.FormattingEnabled = true;
            this.listBoxProcList.Location = new System.Drawing.Point(0, 0);
            this.listBoxProcList.Margin = new System.Windows.Forms.Padding(0);
            this.listBoxProcList.Name = "listBoxProcList";
            this.listBoxProcList.Size = new System.Drawing.Size(136, 357);
            this.listBoxProcList.TabIndex = 0;
            // 
            // labelStatusInd
            // 
            this.labelStatusInd.AutoSize = true;
            this.labelStatusInd.Location = new System.Drawing.Point(138, 0);
            this.labelStatusInd.Name = "labelStatusInd";
            this.labelStatusInd.Size = new System.Drawing.Size(37, 13);
            this.labelStatusInd.TabIndex = 3;
            this.labelStatusInd.Text = "Status";
            // 
            // tabPageInformation
            // 
            this.tabPageInformation.Controls.Add(this.panelMainInformation);
            this.tabPageInformation.Controls.Add(this.panelToolStripInformation);
            this.tabPageInformation.Location = new System.Drawing.Point(4, 22);
            this.tabPageInformation.Name = "tabPageInformation";
            this.tabPageInformation.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageInformation.Size = new System.Drawing.Size(838, 486);
            this.tabPageInformation.TabIndex = 3;
            this.tabPageInformation.Text = "Information";
            this.tabPageInformation.UseVisualStyleBackColor = true;
            // 
            // panelMainInformation
            // 
            this.panelMainInformation.Controls.Add(this.groupBoxComputerInfo);
            this.panelMainInformation.Controls.Add(this.groupBoxRAMContainer);
            this.panelMainInformation.Controls.Add(this.groupBoxCPUContainer);
            this.panelMainInformation.Controls.Add(this.panelDriveInformation);
            this.panelMainInformation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMainInformation.Location = new System.Drawing.Point(3, 35);
            this.panelMainInformation.Name = "panelMainInformation";
            this.panelMainInformation.Size = new System.Drawing.Size(832, 448);
            this.panelMainInformation.TabIndex = 16;
            // 
            // groupBoxComputerInfo
            // 
            this.groupBoxComputerInfo.Controls.Add(this.labelCpuCores);
            this.groupBoxComputerInfo.Controls.Add(this.labelCpuSpeed);
            this.groupBoxComputerInfo.Controls.Add(this.labelToralRAM);
            this.groupBoxComputerInfo.Location = new System.Drawing.Point(317, 6);
            this.groupBoxComputerInfo.Name = "groupBoxComputerInfo";
            this.groupBoxComputerInfo.Size = new System.Drawing.Size(115, 98);
            this.groupBoxComputerInfo.TabIndex = 10;
            this.groupBoxComputerInfo.TabStop = false;
            this.groupBoxComputerInfo.Text = "PC - Info";
            this.groupBoxComputerInfo.Visible = false;
            // 
            // labelCpuCores
            // 
            this.labelCpuCores.AutoSize = true;
            this.labelCpuCores.Location = new System.Drawing.Point(6, 28);
            this.labelCpuCores.Name = "labelCpuCores";
            this.labelCpuCores.Size = new System.Drawing.Size(42, 13);
            this.labelCpuCores.TabIndex = 5;
            this.labelCpuCores.Text = "*Cores*";
            // 
            // labelCpuSpeed
            // 
            this.labelCpuSpeed.AutoSize = true;
            this.labelCpuSpeed.Location = new System.Drawing.Point(6, 52);
            this.labelCpuSpeed.Name = "labelCpuSpeed";
            this.labelCpuSpeed.Size = new System.Drawing.Size(90, 13);
            this.labelCpuSpeed.TabIndex = 6;
            this.labelCpuSpeed.Text = "*CPU Frequency*";
            // 
            // labelToralRAM
            // 
            this.labelToralRAM.AutoSize = true;
            this.labelToralRAM.Location = new System.Drawing.Point(6, 74);
            this.labelToralRAM.Name = "labelToralRAM";
            this.labelToralRAM.Size = new System.Drawing.Size(77, 13);
            this.labelToralRAM.TabIndex = 7;
            this.labelToralRAM.Text = "labelTotalRAM";
            // 
            // groupBoxRAMContainer
            // 
            this.groupBoxRAMContainer.Controls.Add(this.labelRamBottom);
            this.groupBoxRAMContainer.Controls.Add(this.labelRamTop);
            this.groupBoxRAMContainer.Controls.Add(this.labelRAM);
            this.groupBoxRAMContainer.Controls.Add(this.chartRAM);
            this.groupBoxRAMContainer.Location = new System.Drawing.Point(438, 213);
            this.groupBoxRAMContainer.Name = "groupBoxRAMContainer";
            this.groupBoxRAMContainer.Size = new System.Drawing.Size(391, 214);
            this.groupBoxRAMContainer.TabIndex = 9;
            this.groupBoxRAMContainer.TabStop = false;
            this.groupBoxRAMContainer.Text = "RAM";
            // 
            // labelRamBottom
            // 
            this.labelRamBottom.AutoSize = true;
            this.labelRamBottom.BackColor = System.Drawing.Color.Black;
            this.labelRamBottom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.labelRamBottom.Location = new System.Drawing.Point(352, 186);
            this.labelRamBottom.Name = "labelRamBottom";
            this.labelRamBottom.Size = new System.Drawing.Size(21, 13);
            this.labelRamBottom.TabIndex = 8;
            this.labelRamBottom.Text = "0%";
            // 
            // labelRamTop
            // 
            this.labelRamTop.AutoSize = true;
            this.labelRamTop.BackColor = System.Drawing.Color.Black;
            this.labelRamTop.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.labelRamTop.Location = new System.Drawing.Point(340, 30);
            this.labelRamTop.Name = "labelRamTop";
            this.labelRamTop.Size = new System.Drawing.Size(33, 13);
            this.labelRamTop.TabIndex = 7;
            this.labelRamTop.Text = "100%";
            // 
            // labelRAM
            // 
            this.labelRAM.AutoSize = true;
            this.labelRAM.Location = new System.Drawing.Point(24, 186);
            this.labelRAM.Name = "labelRAM";
            this.labelRAM.Size = new System.Drawing.Size(53, 13);
            this.labelRAM.TabIndex = 2;
            this.labelRAM.Text = "labelRAM";
            // 
            // chartRAM
            // 
            this.chartRAM.BorderlineColor = System.Drawing.Color.Black;
            this.chartRAM.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            this.chartRAM.Location = new System.Drawing.Point(85, 19);
            this.chartRAM.Name = "chartRAM";
            series1.Name = "Series1";
            this.chartRAM.Series.Add(series1);
            this.chartRAM.Size = new System.Drawing.Size(300, 189);
            this.chartRAM.TabIndex = 4;
            this.chartRAM.Text = "chart2";
            // 
            // groupBoxCPUContainer
            // 
            this.groupBoxCPUContainer.Controls.Add(this.labelCpuMiddle);
            this.groupBoxCPUContainer.Controls.Add(this.labelCpuBottom);
            this.groupBoxCPUContainer.Controls.Add(this.labelCpuTop);
            this.groupBoxCPUContainer.Controls.Add(this.chartCPU);
            this.groupBoxCPUContainer.Controls.Add(this.labelCPU);
            this.groupBoxCPUContainer.Location = new System.Drawing.Point(438, 3);
            this.groupBoxCPUContainer.Name = "groupBoxCPUContainer";
            this.groupBoxCPUContainer.Size = new System.Drawing.Size(391, 204);
            this.groupBoxCPUContainer.TabIndex = 8;
            this.groupBoxCPUContainer.TabStop = false;
            this.groupBoxCPUContainer.Text = "CPU";
            // 
            // labelCpuMiddle
            // 
            this.labelCpuMiddle.AutoSize = true;
            this.labelCpuMiddle.BackColor = System.Drawing.Color.Black;
            this.labelCpuMiddle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.labelCpuMiddle.Location = new System.Drawing.Point(346, 97);
            this.labelCpuMiddle.Name = "labelCpuMiddle";
            this.labelCpuMiddle.Size = new System.Drawing.Size(27, 13);
            this.labelCpuMiddle.TabIndex = 6;
            this.labelCpuMiddle.Text = "50%";
            // 
            // labelCpuBottom
            // 
            this.labelCpuBottom.AutoSize = true;
            this.labelCpuBottom.BackColor = System.Drawing.Color.Black;
            this.labelCpuBottom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.labelCpuBottom.Location = new System.Drawing.Point(352, 176);
            this.labelCpuBottom.Name = "labelCpuBottom";
            this.labelCpuBottom.Size = new System.Drawing.Size(21, 13);
            this.labelCpuBottom.TabIndex = 5;
            this.labelCpuBottom.Text = "0%";
            // 
            // labelCpuTop
            // 
            this.labelCpuTop.AutoSize = true;
            this.labelCpuTop.BackColor = System.Drawing.Color.Black;
            this.labelCpuTop.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.labelCpuTop.Location = new System.Drawing.Point(340, 16);
            this.labelCpuTop.Name = "labelCpuTop";
            this.labelCpuTop.Size = new System.Drawing.Size(33, 13);
            this.labelCpuTop.TabIndex = 4;
            this.labelCpuTop.Text = "100%";
            // 
            // chartCPU
            // 
            this.chartCPU.BorderlineColor = System.Drawing.Color.Black;
            this.chartCPU.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            this.chartCPU.Location = new System.Drawing.Point(85, 9);
            this.chartCPU.Name = "chartCPU";
            series2.Name = "Series1";
            this.chartCPU.Series.Add(series2);
            this.chartCPU.Size = new System.Drawing.Size(300, 189);
            this.chartCPU.TabIndex = 3;
            this.chartCPU.Text = "chart1";
            this.chartCPU.TextAntiAliasingQuality = System.Windows.Forms.DataVisualization.Charting.TextAntiAliasingQuality.Normal;
            // 
            // labelCPU
            // 
            this.labelCPU.AutoSize = true;
            this.labelCPU.Location = new System.Drawing.Point(28, 185);
            this.labelCPU.Name = "labelCPU";
            this.labelCPU.Size = new System.Drawing.Size(51, 13);
            this.labelCPU.TabIndex = 1;
            this.labelCPU.Text = "labelCPU";
            this.labelCPU.Visible = false;
            // 
            // panelDriveInformation
            // 
            this.panelDriveInformation.Controls.Add(this.groupBoxDrive);
            this.panelDriveInformation.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelDriveInformation.Location = new System.Drawing.Point(0, 0);
            this.panelDriveInformation.Name = "panelDriveInformation";
            this.panelDriveInformation.Size = new System.Drawing.Size(317, 448);
            this.panelDriveInformation.TabIndex = 0;
            // 
            // groupBoxDrive
            // 
            this.groupBoxDrive.Controls.Add(this.flowLayoutPanelDrive);
            this.groupBoxDrive.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxDrive.Location = new System.Drawing.Point(0, 0);
            this.groupBoxDrive.Name = "groupBoxDrive";
            this.groupBoxDrive.Size = new System.Drawing.Size(317, 448);
            this.groupBoxDrive.TabIndex = 0;
            this.groupBoxDrive.TabStop = false;
            this.groupBoxDrive.Text = "Drives";
            // 
            // flowLayoutPanelDrive
            // 
            this.flowLayoutPanelDrive.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelDrive.Location = new System.Drawing.Point(3, 16);
            this.flowLayoutPanelDrive.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanelDrive.Name = "flowLayoutPanelDrive";
            this.flowLayoutPanelDrive.Size = new System.Drawing.Size(311, 429);
            this.flowLayoutPanelDrive.TabIndex = 0;
            // 
            // panelToolStripInformation
            // 
            this.panelToolStripInformation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelToolStripInformation.Controls.Add(this.labelDriveRefreshTimer);
            this.panelToolStripInformation.Controls.Add(this.labelPerformanceTicPer10);
            this.panelToolStripInformation.Controls.Add(this.textBoxPerformanceTicRate);
            this.panelToolStripInformation.Controls.Add(this.label8);
            this.panelToolStripInformation.Controls.Add(this.buttonDriveTest);
            this.panelToolStripInformation.Controls.Add(this.buttonPerformanceTest);
            this.panelToolStripInformation.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelToolStripInformation.Location = new System.Drawing.Point(3, 3);
            this.panelToolStripInformation.Name = "panelToolStripInformation";
            this.panelToolStripInformation.Size = new System.Drawing.Size(832, 32);
            this.panelToolStripInformation.TabIndex = 15;
            // 
            // labelDriveRefreshTimer
            // 
            this.labelDriveRefreshTimer.AutoSize = true;
            this.labelDriveRefreshTimer.Location = new System.Drawing.Point(97, 9);
            this.labelDriveRefreshTimer.Name = "labelDriveRefreshTimer";
            this.labelDriveRefreshTimer.Size = new System.Drawing.Size(86, 13);
            this.labelDriveRefreshTimer.TabIndex = 18;
            this.labelDriveRefreshTimer.Text = "Next Refresh in :";
            // 
            // labelPerformanceTicPer10
            // 
            this.labelPerformanceTicPer10.AutoSize = true;
            this.labelPerformanceTicPer10.Location = new System.Drawing.Point(640, 9);
            this.labelPerformanceTicPer10.Name = "labelPerformanceTicPer10";
            this.labelPerformanceTicPer10.Size = new System.Drawing.Size(29, 13);
            this.labelPerformanceTicPer10.TabIndex = 17;
            this.labelPerformanceTicPer10.Text = "/10s";
            // 
            // textBoxPerformanceTicRate
            // 
            this.textBoxPerformanceTicRate.Location = new System.Drawing.Point(600, 6);
            this.textBoxPerformanceTicRate.MaxLength = 2;
            this.textBoxPerformanceTicRate.Name = "textBoxPerformanceTicRate";
            this.textBoxPerformanceTicRate.Size = new System.Drawing.Size(34, 20);
            this.textBoxPerformanceTicRate.TabIndex = 16;
            this.textBoxPerformanceTicRate.Text = "2";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(557, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Refresh:";
            // 
            // buttonDriveTest
            // 
            this.buttonDriveTest.Location = new System.Drawing.Point(4, 4);
            this.buttonDriveTest.Name = "buttonDriveTest";
            this.buttonDriveTest.Size = new System.Drawing.Size(75, 23);
            this.buttonDriveTest.TabIndex = 13;
            this.buttonDriveTest.Text = "Drive";
            this.buttonDriveTest.UseVisualStyleBackColor = true;
            // 
            // buttonPerformanceTest
            // 
            this.buttonPerformanceTest.Location = new System.Drawing.Point(437, 4);
            this.buttonPerformanceTest.Name = "buttonPerformanceTest";
            this.buttonPerformanceTest.Size = new System.Drawing.Size(103, 23);
            this.buttonPerformanceTest.TabIndex = 14;
            this.buttonPerformanceTest.Text = "Performance";
            this.buttonPerformanceTest.UseVisualStyleBackColor = true;
            // 
            // tabPageProcessesSettings
            // 
            this.tabPageProcessesSettings.Controls.Add(this.panelConfigMain);
            this.tabPageProcessesSettings.Controls.Add(this.panelConfigMinor);
            this.tabPageProcessesSettings.Location = new System.Drawing.Point(4, 22);
            this.tabPageProcessesSettings.Name = "tabPageProcessesSettings";
            this.tabPageProcessesSettings.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageProcessesSettings.Size = new System.Drawing.Size(838, 486);
            this.tabPageProcessesSettings.TabIndex = 1;
            this.tabPageProcessesSettings.Text = "Settings";
            this.tabPageProcessesSettings.UseVisualStyleBackColor = true;
            // 
            // panelConfigMain
            // 
            this.panelConfigMain.Controls.Add(this.groupBoxControll);
            this.panelConfigMain.Controls.Add(this.groupBoxIPList);
            this.panelConfigMain.Controls.Add(this.groupBoxNewIP);
            this.panelConfigMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelConfigMain.Location = new System.Drawing.Point(181, 3);
            this.panelConfigMain.Name = "panelConfigMain";
            this.panelConfigMain.Size = new System.Drawing.Size(654, 480);
            this.panelConfigMain.TabIndex = 4;
            // 
            // groupBoxControll
            // 
            this.groupBoxControll.Controls.Add(this.radioButtonMainOff);
            this.groupBoxControll.Controls.Add(this.radioButtonMainOn);
            this.groupBoxControll.Location = new System.Drawing.Point(255, 6);
            this.groupBoxControll.Name = "groupBoxControll";
            this.groupBoxControll.Size = new System.Drawing.Size(106, 40);
            this.groupBoxControll.TabIndex = 6;
            this.groupBoxControll.TabStop = false;
            this.groupBoxControll.Text = "SuperVisor";
            // 
            // radioButtonMainOff
            // 
            this.radioButtonMainOff.AutoSize = true;
            this.radioButtonMainOff.Checked = true;
            this.radioButtonMainOff.Location = new System.Drawing.Point(60, 19);
            this.radioButtonMainOff.Name = "radioButtonMainOff";
            this.radioButtonMainOff.Size = new System.Drawing.Size(39, 17);
            this.radioButtonMainOff.TabIndex = 1;
            this.radioButtonMainOff.TabStop = true;
            this.radioButtonMainOff.Text = "Off";
            this.radioButtonMainOff.UseVisualStyleBackColor = true;
            // 
            // radioButtonMainOn
            // 
            this.radioButtonMainOn.AutoSize = true;
            this.radioButtonMainOn.Location = new System.Drawing.Point(15, 19);
            this.radioButtonMainOn.Name = "radioButtonMainOn";
            this.radioButtonMainOn.Size = new System.Drawing.Size(39, 17);
            this.radioButtonMainOn.TabIndex = 0;
            this.radioButtonMainOn.Text = "On";
            this.radioButtonMainOn.UseVisualStyleBackColor = true;
            // 
            // groupBoxIPList
            // 
            this.groupBoxIPList.Controls.Add(this.listBoxIPList);
            this.groupBoxIPList.Location = new System.Drawing.Point(6, 166);
            this.groupBoxIPList.Name = "groupBoxIPList";
            this.groupBoxIPList.Size = new System.Drawing.Size(246, 212);
            this.groupBoxIPList.TabIndex = 1;
            this.groupBoxIPList.TabStop = false;
            this.groupBoxIPList.Text = "IP List";
            // 
            // listBoxIPList
            // 
            this.listBoxIPList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxIPList.FormattingEnabled = true;
            this.listBoxIPList.Location = new System.Drawing.Point(3, 16);
            this.listBoxIPList.Name = "listBoxIPList";
            this.listBoxIPList.Size = new System.Drawing.Size(240, 193);
            this.listBoxIPList.TabIndex = 0;
            // 
            // groupBoxNewIP
            // 
            this.groupBoxNewIP.Controls.Add(this.checkBoxAdminCmd);
            this.groupBoxNewIP.Controls.Add(this.labelNewIPDesc);
            this.groupBoxNewIP.Controls.Add(this.labelNewIP);
            this.groupBoxNewIP.Controls.Add(this.buttonNewIPSave);
            this.groupBoxNewIP.Controls.Add(this.richTextBoxIPDesc);
            this.groupBoxNewIP.Controls.Add(this.textBoxNewIP);
            this.groupBoxNewIP.Location = new System.Drawing.Point(6, 3);
            this.groupBoxNewIP.Name = "groupBoxNewIP";
            this.groupBoxNewIP.Size = new System.Drawing.Size(243, 160);
            this.groupBoxNewIP.TabIndex = 0;
            this.groupBoxNewIP.TabStop = false;
            this.groupBoxNewIP.Text = "New IP Configuration";
            // 
            // checkBoxAdminCmd
            // 
            this.checkBoxAdminCmd.AutoSize = true;
            this.checkBoxAdminCmd.Location = new System.Drawing.Point(152, 26);
            this.checkBoxAdminCmd.Name = "checkBoxAdminCmd";
            this.checkBoxAdminCmd.Size = new System.Drawing.Size(82, 17);
            this.checkBoxAdminCmd.TabIndex = 5;
            this.checkBoxAdminCmd.Text = "Admin CMD";
            this.checkBoxAdminCmd.UseVisualStyleBackColor = true;
            // 
            // labelNewIPDesc
            // 
            this.labelNewIPDesc.AutoSize = true;
            this.labelNewIPDesc.Location = new System.Drawing.Point(8, 58);
            this.labelNewIPDesc.Name = "labelNewIPDesc";
            this.labelNewIPDesc.Size = new System.Drawing.Size(35, 13);
            this.labelNewIPDesc.TabIndex = 4;
            this.labelNewIPDesc.Text = "Desc:";
            // 
            // labelNewIP
            // 
            this.labelNewIP.AutoSize = true;
            this.labelNewIP.Location = new System.Drawing.Point(23, 30);
            this.labelNewIP.Name = "labelNewIP";
            this.labelNewIP.Size = new System.Drawing.Size(20, 13);
            this.labelNewIP.TabIndex = 3;
            this.labelNewIP.Text = "IP:";
            // 
            // buttonNewIPSave
            // 
            this.buttonNewIPSave.Location = new System.Drawing.Point(85, 123);
            this.buttonNewIPSave.Name = "buttonNewIPSave";
            this.buttonNewIPSave.Size = new System.Drawing.Size(93, 30);
            this.buttonNewIPSave.TabIndex = 2;
            this.buttonNewIPSave.Text = "Save";
            this.buttonNewIPSave.UseVisualStyleBackColor = true;
            // 
            // richTextBoxIPDesc
            // 
            this.richTextBoxIPDesc.Location = new System.Drawing.Point(49, 55);
            this.richTextBoxIPDesc.Name = "richTextBoxIPDesc";
            this.richTextBoxIPDesc.Size = new System.Drawing.Size(188, 62);
            this.richTextBoxIPDesc.TabIndex = 1;
            this.richTextBoxIPDesc.Text = "";
            // 
            // textBoxNewIP
            // 
            this.textBoxNewIP.Location = new System.Drawing.Point(49, 27);
            this.textBoxNewIP.Name = "textBoxNewIP";
            this.textBoxNewIP.Size = new System.Drawing.Size(97, 20);
            this.textBoxNewIP.TabIndex = 0;
            // 
            // panelConfigMinor
            // 
            this.panelConfigMinor.Controls.Add(this.buttonCustomSettingsApply);
            this.panelConfigMinor.Controls.Add(this.groupBoxButtonSettings);
            this.panelConfigMinor.Controls.Add(this.groupBoxTimerSettings);
            this.panelConfigMinor.Controls.Add(this.groupBoxCMDLineSettings);
            this.panelConfigMinor.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelConfigMinor.Location = new System.Drawing.Point(3, 3);
            this.panelConfigMinor.Name = "panelConfigMinor";
            this.panelConfigMinor.Size = new System.Drawing.Size(178, 480);
            this.panelConfigMinor.TabIndex = 3;
            // 
            // buttonCustomSettingsApply
            // 
            this.buttonCustomSettingsApply.Location = new System.Drawing.Point(45, 166);
            this.buttonCustomSettingsApply.Name = "buttonCustomSettingsApply";
            this.buttonCustomSettingsApply.Size = new System.Drawing.Size(75, 23);
            this.buttonCustomSettingsApply.TabIndex = 2;
            this.buttonCustomSettingsApply.Text = "Apply";
            this.buttonCustomSettingsApply.UseVisualStyleBackColor = true;
            // 
            // groupBoxButtonSettings
            // 
            this.groupBoxButtonSettings.Controls.Add(this.checkBoxIsRemoteSetting);
            this.groupBoxButtonSettings.Location = new System.Drawing.Point(9, 107);
            this.groupBoxButtonSettings.Name = "groupBoxButtonSettings";
            this.groupBoxButtonSettings.Size = new System.Drawing.Size(160, 49);
            this.groupBoxButtonSettings.TabIndex = 2;
            this.groupBoxButtonSettings.TabStop = false;
            this.groupBoxButtonSettings.Text = "Button Settings";
            // 
            // checkBoxIsRemoteSetting
            // 
            this.checkBoxIsRemoteSetting.AutoSize = true;
            this.checkBoxIsRemoteSetting.Location = new System.Drawing.Point(6, 19);
            this.checkBoxIsRemoteSetting.Name = "checkBoxIsRemoteSetting";
            this.checkBoxIsRemoteSetting.Size = new System.Drawing.Size(140, 17);
            this.checkBoxIsRemoteSetting.TabIndex = 0;
            this.checkBoxIsRemoteSetting.Text = "\"Local\" status at launch";
            this.checkBoxIsRemoteSetting.UseVisualStyleBackColor = true;
            // 
            // groupBoxTimerSettings
            // 
            this.groupBoxTimerSettings.Controls.Add(this.labelTimerSetting);
            this.groupBoxTimerSettings.Controls.Add(this.numericUpDownTimer);
            this.groupBoxTimerSettings.Location = new System.Drawing.Point(9, 3);
            this.groupBoxTimerSettings.Name = "groupBoxTimerSettings";
            this.groupBoxTimerSettings.Size = new System.Drawing.Size(163, 49);
            this.groupBoxTimerSettings.TabIndex = 0;
            this.groupBoxTimerSettings.TabStop = false;
            this.groupBoxTimerSettings.Text = "Refresh rate";
            // 
            // labelTimerSetting
            // 
            this.labelTimerSetting.AutoSize = true;
            this.labelTimerSetting.Location = new System.Drawing.Point(50, 21);
            this.labelTimerSetting.Name = "labelTimerSetting";
            this.labelTimerSetting.Size = new System.Drawing.Size(26, 13);
            this.labelTimerSetting.TabIndex = 1;
            this.labelTimerSetting.Text = "Sec";
            // 
            // numericUpDownTimer
            // 
            this.numericUpDownTimer.Location = new System.Drawing.Point(6, 19);
            this.numericUpDownTimer.Name = "numericUpDownTimer";
            this.numericUpDownTimer.Size = new System.Drawing.Size(38, 20);
            this.numericUpDownTimer.TabIndex = 0;
            this.numericUpDownTimer.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // groupBoxCMDLineSettings
            // 
            this.groupBoxCMDLineSettings.Controls.Add(this.checkBoxCMDDisplay);
            this.groupBoxCMDLineSettings.Location = new System.Drawing.Point(9, 58);
            this.groupBoxCMDLineSettings.Name = "groupBoxCMDLineSettings";
            this.groupBoxCMDLineSettings.Size = new System.Drawing.Size(160, 43);
            this.groupBoxCMDLineSettings.TabIndex = 1;
            this.groupBoxCMDLineSettings.TabStop = false;
            this.groupBoxCMDLineSettings.Text = "Command line Settings";
            // 
            // checkBoxCMDDisplay
            // 
            this.checkBoxCMDDisplay.AutoSize = true;
            this.checkBoxCMDDisplay.Location = new System.Drawing.Point(6, 19);
            this.checkBoxCMDDisplay.Name = "checkBoxCMDDisplay";
            this.checkBoxCMDDisplay.Size = new System.Drawing.Size(131, 17);
            this.checkBoxCMDDisplay.TabIndex = 0;
            this.checkBoxCMDDisplay.Text = "Display recieved CMD";
            this.checkBoxCMDDisplay.UseVisualStyleBackColor = true;
            // 
            // tabPageAbout
            // 
            this.tabPageAbout.Controls.Add(this.tableLayoutPanel);
            this.tabPageAbout.Location = new System.Drawing.Point(4, 22);
            this.tabPageAbout.Name = "tabPageAbout";
            this.tabPageAbout.Size = new System.Drawing.Size(838, 486);
            this.tabPageAbout.TabIndex = 2;
            this.tabPageAbout.Text = "About";
            this.tabPageAbout.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 2;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.75623F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 78.24377F));
            this.tableLayoutPanel.Controls.Add(this.labelProductName, 1, 0);
            this.tableLayoutPanel.Controls.Add(this.labelVersion, 1, 1);
            this.tableLayoutPanel.Controls.Add(this.labelCopyright, 1, 2);
            this.tableLayoutPanel.Controls.Add(this.labelCompanyName, 1, 3);
            this.tableLayoutPanel.Controls.Add(this.textBoxDescription, 1, 4);
            this.tableLayoutPanel.Controls.Add(this.okButton, 1, 5);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 6;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(838, 486);
            this.tableLayoutPanel.TabIndex = 1;
            // 
            // labelProductName
            // 
            this.labelProductName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelProductName.Location = new System.Drawing.Point(188, 0);
            this.labelProductName.Margin = new System.Windows.Forms.Padding(6, 0, 3, 0);
            this.labelProductName.MaximumSize = new System.Drawing.Size(0, 17);
            this.labelProductName.Name = "labelProductName";
            this.labelProductName.Size = new System.Drawing.Size(647, 17);
            this.labelProductName.TabIndex = 19;
            this.labelProductName.Text = "Product Name";
            this.labelProductName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelVersion
            // 
            this.labelVersion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelVersion.Location = new System.Drawing.Point(188, 48);
            this.labelVersion.Margin = new System.Windows.Forms.Padding(6, 0, 3, 0);
            this.labelVersion.MaximumSize = new System.Drawing.Size(0, 17);
            this.labelVersion.Name = "labelVersion";
            this.labelVersion.Size = new System.Drawing.Size(647, 17);
            this.labelVersion.TabIndex = 0;
            this.labelVersion.Text = "Version";
            this.labelVersion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelCopyright
            // 
            this.labelCopyright.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelCopyright.Location = new System.Drawing.Point(188, 96);
            this.labelCopyright.Margin = new System.Windows.Forms.Padding(6, 0, 3, 0);
            this.labelCopyright.MaximumSize = new System.Drawing.Size(0, 17);
            this.labelCopyright.Name = "labelCopyright";
            this.labelCopyright.Size = new System.Drawing.Size(647, 17);
            this.labelCopyright.TabIndex = 21;
            this.labelCopyright.Text = "Copyright";
            this.labelCopyright.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelCompanyName
            // 
            this.labelCompanyName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelCompanyName.Location = new System.Drawing.Point(188, 144);
            this.labelCompanyName.Margin = new System.Windows.Forms.Padding(6, 0, 3, 0);
            this.labelCompanyName.MaximumSize = new System.Drawing.Size(0, 17);
            this.labelCompanyName.Name = "labelCompanyName";
            this.labelCompanyName.Size = new System.Drawing.Size(647, 17);
            this.labelCompanyName.TabIndex = 22;
            this.labelCompanyName.Text = "Company Name";
            this.labelCompanyName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxDescription.Location = new System.Drawing.Point(188, 195);
            this.textBoxDescription.Margin = new System.Windows.Forms.Padding(6, 3, 3, 3);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.ReadOnly = true;
            this.textBoxDescription.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxDescription.Size = new System.Drawing.Size(647, 237);
            this.textBoxDescription.TabIndex = 23;
            this.textBoxDescription.TabStop = false;
            this.textBoxDescription.Text = "Description";
            // 
            // okButton
            // 
            this.okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.okButton.Location = new System.Drawing.Point(760, 460);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 24;
            this.okButton.Text = "&OK";
            // 
            // tabPageTesting
            // 
            this.tabPageTesting.Controls.Add(this.panelTEST);
            this.tabPageTesting.Controls.Add(this.labelTest);
            this.tabPageTesting.Controls.Add(this.buttonTest);
            this.tabPageTesting.Controls.Add(this.panel1);
            this.tabPageTesting.Controls.Add(this.panelIndDrive);
            this.tabPageTesting.Location = new System.Drawing.Point(4, 22);
            this.tabPageTesting.Name = "tabPageTesting";
            this.tabPageTesting.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTesting.Size = new System.Drawing.Size(838, 486);
            this.tabPageTesting.TabIndex = 4;
            this.tabPageTesting.Text = "Testing tab";
            this.tabPageTesting.UseVisualStyleBackColor = true;
            // 
            // panelTEST
            // 
            this.panelTEST.Controls.Add(this.pictureBox3);
            this.panelTEST.Controls.Add(this.pictureBox4);
            this.panelTEST.Location = new System.Drawing.Point(9, 122);
            this.panelTEST.Name = "panelTEST";
            this.panelTEST.Size = new System.Drawing.Size(50, 172);
            this.panelTEST.TabIndex = 23;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(0, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(50, 42);
            this.pictureBox3.TabIndex = 10;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Location = new System.Drawing.Point(0, 152);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(50, 20);
            this.pictureBox4.TabIndex = 11;
            this.pictureBox4.TabStop = false;
            // 
            // labelTest
            // 
            this.labelTest.AutoSize = true;
            this.labelTest.Location = new System.Drawing.Point(152, 45);
            this.labelTest.Name = "labelTest";
            this.labelTest.Size = new System.Drawing.Size(32, 13);
            this.labelTest.TabIndex = 22;
            this.labelTest.Text = "*test*";
            // 
            // buttonTest
            // 
            this.buttonTest.Location = new System.Drawing.Point(152, 75);
            this.buttonTest.Name = "buttonTest";
            this.buttonTest.Size = new System.Drawing.Size(75, 23);
            this.buttonTest.TabIndex = 21;
            this.buttonTest.Text = "Test";
            this.buttonTest.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.progressBar2);
            this.panel1.Location = new System.Drawing.Point(6, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(140, 52);
            this.panel1.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "label31asdasdasdas";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(0, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "10 Gb free of 104,75 Gb";
            // 
            // progressBar2
            // 
            this.progressBar2.Location = new System.Drawing.Point(0, 16);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(105, 18);
            this.progressBar2.TabIndex = 14;
            this.progressBar2.Value = 50;
            // 
            // panelIndDrive
            // 
            this.panelIndDrive.Controls.Add(this.pictureBox2);
            this.panelIndDrive.Controls.Add(this.pictureBox1);
            this.panelIndDrive.Controls.Add(this.labelDriveTop1);
            this.panelIndDrive.Controls.Add(this.labelDriveBot1);
            this.panelIndDrive.Location = new System.Drawing.Point(6, 6);
            this.panelIndDrive.Name = "panelIndDrive";
            this.panelIndDrive.Size = new System.Drawing.Size(140, 52);
            this.panelIndDrive.TabIndex = 19;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Location = new System.Drawing.Point(72, 15);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(40, 19);
            this.pictureBox2.TabIndex = 19;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.MediumAquamarine;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(3, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(72, 19);
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // labelDriveTop1
            // 
            this.labelDriveTop1.AutoSize = true;
            this.labelDriveTop1.Location = new System.Drawing.Point(0, 0);
            this.labelDriveTop1.Name = "labelDriveTop1";
            this.labelDriveTop1.Size = new System.Drawing.Size(103, 13);
            this.labelDriveTop1.TabIndex = 15;
            this.labelDriveTop1.Text = "label31asdasdasdas";
            // 
            // labelDriveBot1
            // 
            this.labelDriveBot1.Location = new System.Drawing.Point(0, 37);
            this.labelDriveBot1.Name = "labelDriveBot1";
            this.labelDriveBot1.Size = new System.Drawing.Size(140, 13);
            this.labelDriveBot1.TabIndex = 16;
            this.labelDriveBot1.Text = "10 Gb free of 104,75 Gb";
            // 
            // openFileDialogExecutables
            // 
            this.openFileDialogExecutables.FileName = "openFileDialogExecutables";
            // 
            // labelConnectedTo
            // 
            this.labelConnectedTo.AutoSize = true;
            this.labelConnectedTo.Location = new System.Drawing.Point(309, 497);
            this.labelConnectedTo.Name = "labelConnectedTo";
            this.labelConnectedTo.Size = new System.Drawing.Size(74, 13);
            this.labelConnectedTo.TabIndex = 8;
            this.labelConnectedTo.Text = "Connected to:";
            this.labelConnectedTo.Visible = false;
            // 
            // labelConnectedToRes
            // 
            this.labelConnectedToRes.AutoSize = true;
            this.labelConnectedToRes.Location = new System.Drawing.Point(389, 497);
            this.labelConnectedToRes.Name = "labelConnectedToRes";
            this.labelConnectedToRes.Size = new System.Drawing.Size(25, 13);
            this.labelConnectedToRes.TabIndex = 9;
            this.labelConnectedToRes.Text = "*IP*";
            this.labelConnectedToRes.Visible = false;
            // 
            // di_SuperVisor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 534);
            this.Controls.Add(this.labelConnectedTo);
            this.Controls.Add(this.labelConnectedToRes);
            this.Controls.Add(this.tabControlMain);
            this.Controls.Add(this.statusStripMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(787, 477);
            this.Name = "di_SuperVisor";
            this.Text = "SuperVisorV2";
            this.Load += new System.EventHandler(this.Di_SuperVisor_Load);
            this.statusStripMain.ResumeLayout(false);
            this.statusStripMain.PerformLayout();
            this.tabControlMain.ResumeLayout(false);
            this.tabPageProcesses.ResumeLayout(false);
            this.tabPageProcesses.PerformLayout();
            this.groupBoxLog.ResumeLayout(false);
            this.groupBoxLog.PerformLayout();
            this.groupBoxExecutables.ResumeLayout(false);
            this.groupBoxExecutables.PerformLayout();
            this.groupBoxRemote.ResumeLayout(false);
            this.groupBoxRemote.PerformLayout();
            this.groupBoxConnection.ResumeLayout(false);
            this.groupBoxConnection.PerformLayout();
            this.panelMain.ResumeLayout(false);
            this.groupBoxProcess.ResumeLayout(false);
            this.groupBoxProcess.PerformLayout();
            this.panelProcessList.ResumeLayout(false);
            this.tabPageInformation.ResumeLayout(false);
            this.panelMainInformation.ResumeLayout(false);
            this.groupBoxComputerInfo.ResumeLayout(false);
            this.groupBoxComputerInfo.PerformLayout();
            this.groupBoxRAMContainer.ResumeLayout(false);
            this.groupBoxRAMContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartRAM)).EndInit();
            this.groupBoxCPUContainer.ResumeLayout(false);
            this.groupBoxCPUContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartCPU)).EndInit();
            this.panelDriveInformation.ResumeLayout(false);
            this.groupBoxDrive.ResumeLayout(false);
            this.panelToolStripInformation.ResumeLayout(false);
            this.panelToolStripInformation.PerformLayout();
            this.tabPageProcessesSettings.ResumeLayout(false);
            this.panelConfigMain.ResumeLayout(false);
            this.groupBoxControll.ResumeLayout(false);
            this.groupBoxControll.PerformLayout();
            this.groupBoxIPList.ResumeLayout(false);
            this.groupBoxNewIP.ResumeLayout(false);
            this.groupBoxNewIP.PerformLayout();
            this.panelConfigMinor.ResumeLayout(false);
            this.groupBoxButtonSettings.ResumeLayout(false);
            this.groupBoxButtonSettings.PerformLayout();
            this.groupBoxTimerSettings.ResumeLayout(false);
            this.groupBoxTimerSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTimer)).EndInit();
            this.groupBoxCMDLineSettings.ResumeLayout(false);
            this.groupBoxCMDLineSettings.PerformLayout();
            this.tabPageAbout.ResumeLayout(false);
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            this.tabPageTesting.ResumeLayout(false);
            this.tabPageTesting.PerformLayout();
            this.panelTEST.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelIndDrive.ResumeLayout(false);
            this.panelIndDrive.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip statusStripMain;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelTime;
        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabPageProcessesSettings;
        private System.Windows.Forms.OpenFileDialog openFileDialogExecutables;
        private System.Windows.Forms.GroupBox groupBoxTimerSettings;
        private System.Windows.Forms.Button buttonCustomSettingsApply;
        private System.Windows.Forms.Label labelTimerSetting;
        private System.Windows.Forms.NumericUpDown numericUpDownTimer;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelRefreshRate;
        private System.Windows.Forms.GroupBox groupBoxCMDLineSettings;
        private System.Windows.Forms.CheckBox checkBoxCMDDisplay;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelUsersCon;
        private System.Windows.Forms.GroupBox groupBoxButtonSettings;
        private System.Windows.Forms.CheckBox checkBoxIsRemoteSetting;
        private System.Windows.Forms.Panel panelConfigMain;
        private System.Windows.Forms.GroupBox groupBoxNewIP;
        private System.Windows.Forms.Label labelNewIPDesc;
        private System.Windows.Forms.Label labelNewIP;
        private System.Windows.Forms.Button buttonNewIPSave;
        private System.Windows.Forms.RichTextBox richTextBoxIPDesc;
        private System.Windows.Forms.TextBox textBoxNewIP;
        private System.Windows.Forms.Panel panelConfigMinor;
        private System.Windows.Forms.GroupBox groupBoxIPList;
        private System.Windows.Forms.ListBox listBoxIPList;
        private System.Windows.Forms.CheckBox checkBoxAdminCmd;
        private System.Windows.Forms.GroupBox groupBoxControll;
        private System.Windows.Forms.RadioButton radioButtonMainOff;
        private System.Windows.Forms.RadioButton radioButtonMainOn;
        private System.Windows.Forms.TabPage tabPageAbout;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.Label labelProductName;
        private System.Windows.Forms.Label labelVersion;
        private System.Windows.Forms.Label labelCopyright;
        private System.Windows.Forms.Label labelCompanyName;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.TabPage tabPageProcesses;
        private System.Windows.Forms.Button buttonClearLogs;
        private System.Windows.Forms.TextBox textBoxCommand;
        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.GroupBox groupBoxLog;
        private System.Windows.Forms.Label labelClientList;
        private System.Windows.Forms.ListBox listBoxClientList;
        private System.Windows.Forms.ListBox listBoxLog;
        private System.Windows.Forms.GroupBox groupBoxExecutables;
        private System.Windows.Forms.Button buttonClearExe;
        private System.Windows.Forms.Button buttonFileLock;
        private System.Windows.Forms.Label labelFilesIsActive;
        private System.Windows.Forms.CheckedListBox checkedListBoxExe;
        private System.Windows.Forms.Button buttonFilesBrowse;
        private System.Windows.Forms.GroupBox groupBoxRemote;
        private System.Windows.Forms.GroupBox groupBoxConnection;
        private System.Windows.Forms.Button buttonLogOff;
        private System.Windows.Forms.Label labelConnectInfo;
        private System.Windows.Forms.Button buttonRemoteConnect;
        private System.Windows.Forms.ComboBox comboBoxConnectTo;
        private System.Windows.Forms.CheckBox checkBoxIsRemote;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.GroupBox groupBoxProcess;
        private System.Windows.Forms.Panel panelProcessList;
        private System.Windows.Forms.ListBox listBoxProcList;
        private System.Windows.Forms.Label labelStatusInd;
        private System.Windows.Forms.Label labelConnectedTo;
        private System.Windows.Forms.Label labelConnectedToRes;
        private System.Windows.Forms.TabPage tabPageInformation;
        private System.Windows.Forms.Panel panelDriveInformation;
        private System.Windows.Forms.GroupBox groupBoxDrive;
        private System.Windows.Forms.Button buttonDriveTest;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelDrive;
        private System.Windows.Forms.TabPage tabPageTesting;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.Panel panelIndDrive;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelDriveTop1;
        private System.Windows.Forms.Label labelDriveBot1;
        private System.Windows.Forms.Button buttonPerformanceTest;
        private System.Windows.Forms.Panel panelMainInformation;
        private System.Windows.Forms.Panel panelToolStripInformation;
        private System.Windows.Forms.Label labelRAM;
        private System.Windows.Forms.Label labelCPU;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartRAM;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartCPU;
        private System.Windows.Forms.Label labelCpuSpeed;
        private System.Windows.Forms.Label labelCpuCores;
        private System.Windows.Forms.Label labelToralRAM;
        private System.Windows.Forms.GroupBox groupBoxRAMContainer;
        private System.Windows.Forms.GroupBox groupBoxCPUContainer;
        private System.Windows.Forms.Button buttonTest;
        private System.Windows.Forms.Label labelTest;
        private System.Windows.Forms.Panel panelTEST;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.GroupBox groupBoxComputerInfo;
        private System.Windows.Forms.Label labelCpuMiddle;
        private System.Windows.Forms.Label labelCpuBottom;
        private System.Windows.Forms.Label labelCpuTop;
        private System.Windows.Forms.Label labelRamBottom;
        private System.Windows.Forms.Label labelRamTop;
        private System.Windows.Forms.TextBox textBoxPerformanceTicRate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label labelPerformanceTicPer10;
        private System.Windows.Forms.Label label_;
        private System.Windows.Forms.Label labelDriveRefreshTimer;
    }
}

