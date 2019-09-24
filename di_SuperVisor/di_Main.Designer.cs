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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(di_SuperVisor));
            this.listBoxProcList = new System.Windows.Forms.ListBox();
            this.panelProcessList = new System.Windows.Forms.Panel();
            this.labelStatusInd = new System.Windows.Forms.Label();
            this.panelMain = new System.Windows.Forms.Panel();
            this.groupBoxProcess = new System.Windows.Forms.GroupBox();
            this.statusStripMain = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabPageProcesses = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBoxLog = new System.Windows.Forms.GroupBox();
            this.listBoxLog = new System.Windows.Forms.ListBox();
            this.groupBoxExecutables = new System.Windows.Forms.GroupBox();
            this.buttonFileLock = new System.Windows.Forms.Button();
            this.labelFilesIsActive = new System.Windows.Forms.Label();
            this.checkedListBoxExe = new System.Windows.Forms.CheckedListBox();
            this.buttonFilesBrowse = new System.Windows.Forms.Button();
            this.groupBoxRemote = new System.Windows.Forms.GroupBox();
            this.buttonRemoteConnect = new System.Windows.Forms.Button();
            this.checkBoxIsRemote = new System.Windows.Forms.CheckBox();
            this.comboBoxConnectTo = new System.Windows.Forms.ComboBox();
            this.labelConnectInfo = new System.Windows.Forms.Label();
            this.groupBoxMainStatus = new System.Windows.Forms.GroupBox();
            this.radioButtonMainOff = new System.Windows.Forms.RadioButton();
            this.radioButtonMainOn = new System.Windows.Forms.RadioButton();
            this.tabPageProcessesSettings = new System.Windows.Forms.TabPage();
            this.openFileDialogExecutables = new System.Windows.Forms.OpenFileDialog();
            this.panelProcessList.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.groupBoxProcess.SuspendLayout();
            this.statusStripMain.SuspendLayout();
            this.tabControlMain.SuspendLayout();
            this.tabPageProcesses.SuspendLayout();
            this.groupBoxLog.SuspendLayout();
            this.groupBoxExecutables.SuspendLayout();
            this.groupBoxRemote.SuspendLayout();
            this.groupBoxMainStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxProcList
            // 
            this.listBoxProcList.Dock = System.Windows.Forms.DockStyle.Left;
            this.listBoxProcList.FormattingEnabled = true;
            this.listBoxProcList.Location = new System.Drawing.Point(0, 0);
            this.listBoxProcList.Name = "listBoxProcList";
            this.listBoxProcList.Size = new System.Drawing.Size(136, 313);
            this.listBoxProcList.TabIndex = 0;
            // 
            // panelProcessList
            // 
            this.panelProcessList.Controls.Add(this.listBoxProcList);
            this.panelProcessList.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelProcessList.Location = new System.Drawing.Point(3, 16);
            this.panelProcessList.Name = "panelProcessList";
            this.panelProcessList.Size = new System.Drawing.Size(169, 313);
            this.panelProcessList.TabIndex = 1;
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
            // panelMain
            // 
            this.panelMain.Controls.Add(this.groupBoxProcess);
            this.panelMain.Location = new System.Drawing.Point(8, 57);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(187, 332);
            this.panelMain.TabIndex = 4;
            // 
            // groupBoxProcess
            // 
            this.groupBoxProcess.Controls.Add(this.panelProcessList);
            this.groupBoxProcess.Controls.Add(this.labelStatusInd);
            this.groupBoxProcess.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxProcess.Location = new System.Drawing.Point(0, 0);
            this.groupBoxProcess.Name = "groupBoxProcess";
            this.groupBoxProcess.Size = new System.Drawing.Size(187, 332);
            this.groupBoxProcess.TabIndex = 4;
            this.groupBoxProcess.TabStop = false;
            this.groupBoxProcess.Text = "Process list";
            // 
            // statusStripMain
            // 
            this.statusStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelTime});
            this.statusStripMain.Location = new System.Drawing.Point(0, 424);
            this.statusStripMain.Name = "statusStripMain";
            this.statusStripMain.Size = new System.Drawing.Size(736, 22);
            this.statusStripMain.TabIndex = 5;
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
            this.tabControlMain.Controls.Add(this.tabPageProcessesSettings);
            this.tabControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlMain.Location = new System.Drawing.Point(0, 0);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(736, 424);
            this.tabControlMain.TabIndex = 6;
            // 
            // tabPageProcesses
            // 
            this.tabPageProcesses.BackColor = System.Drawing.SystemColors.Control;
            this.tabPageProcesses.Controls.Add(this.textBox1);
            this.tabPageProcesses.Controls.Add(this.button1);
            this.tabPageProcesses.Controls.Add(this.groupBoxLog);
            this.tabPageProcesses.Controls.Add(this.groupBoxExecutables);
            this.tabPageProcesses.Controls.Add(this.groupBoxRemote);
            this.tabPageProcesses.Controls.Add(this.groupBoxMainStatus);
            this.tabPageProcesses.Controls.Add(this.panelMain);
            this.tabPageProcesses.Location = new System.Drawing.Point(4, 22);
            this.tabPageProcesses.Name = "tabPageProcesses";
            this.tabPageProcesses.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageProcesses.Size = new System.Drawing.Size(728, 398);
            this.tabPageProcesses.TabIndex = 0;
            this.tabPageProcesses.Text = "Processes";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(402, 369);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(240, 20);
            this.textBox1.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(648, 367);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Send all";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click_1);
            // 
            // groupBoxLog
            // 
            this.groupBoxLog.Controls.Add(this.listBoxLog);
            this.groupBoxLog.Location = new System.Drawing.Point(402, 6);
            this.groupBoxLog.Name = "groupBoxLog";
            this.groupBoxLog.Size = new System.Drawing.Size(323, 355);
            this.groupBoxLog.TabIndex = 11;
            this.groupBoxLog.TabStop = false;
            this.groupBoxLog.Text = "Log/Chart";
            // 
            // listBoxLog
            // 
            this.listBoxLog.Dock = System.Windows.Forms.DockStyle.Left;
            this.listBoxLog.FormattingEnabled = true;
            this.listBoxLog.Location = new System.Drawing.Point(3, 16);
            this.listBoxLog.Name = "listBoxLog";
            this.listBoxLog.Size = new System.Drawing.Size(317, 336);
            this.listBoxLog.TabIndex = 0;
            // 
            // groupBoxExecutables
            // 
            this.groupBoxExecutables.Controls.Add(this.buttonFileLock);
            this.groupBoxExecutables.Controls.Add(this.labelFilesIsActive);
            this.groupBoxExecutables.Controls.Add(this.checkedListBoxExe);
            this.groupBoxExecutables.Controls.Add(this.buttonFilesBrowse);
            this.groupBoxExecutables.Location = new System.Drawing.Point(199, 76);
            this.groupBoxExecutables.Name = "groupBoxExecutables";
            this.groupBoxExecutables.Size = new System.Drawing.Size(197, 313);
            this.groupBoxExecutables.TabIndex = 10;
            this.groupBoxExecutables.TabStop = false;
            this.groupBoxExecutables.Text = "Files/Executables";
            // 
            // buttonFileLock
            // 
            this.buttonFileLock.Location = new System.Drawing.Point(133, 19);
            this.buttonFileLock.Name = "buttonFileLock";
            this.buttonFileLock.Size = new System.Drawing.Size(58, 26);
            this.buttonFileLock.TabIndex = 3;
            this.buttonFileLock.Text = "Lock";
            this.buttonFileLock.UseVisualStyleBackColor = true;
            this.buttonFileLock.Click += new System.EventHandler(this.ButtonFileLock_Click);
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
            this.checkedListBoxExe.Size = new System.Drawing.Size(180, 244);
            this.checkedListBoxExe.TabIndex = 1;
            // 
            // buttonFilesBrowse
            // 
            this.buttonFilesBrowse.Location = new System.Drawing.Point(70, 19);
            this.buttonFilesBrowse.Name = "buttonFilesBrowse";
            this.buttonFilesBrowse.Size = new System.Drawing.Size(57, 26);
            this.buttonFilesBrowse.TabIndex = 0;
            this.buttonFilesBrowse.Text = "Browse";
            this.buttonFilesBrowse.UseVisualStyleBackColor = true;
            this.buttonFilesBrowse.Click += new System.EventHandler(this.ButtonFilesBrowse_Click);
            // 
            // groupBoxRemote
            // 
            this.groupBoxRemote.Controls.Add(this.buttonRemoteConnect);
            this.groupBoxRemote.Controls.Add(this.checkBoxIsRemote);
            this.groupBoxRemote.Controls.Add(this.comboBoxConnectTo);
            this.groupBoxRemote.Controls.Add(this.labelConnectInfo);
            this.groupBoxRemote.Location = new System.Drawing.Point(199, 6);
            this.groupBoxRemote.Name = "groupBoxRemote";
            this.groupBoxRemote.Size = new System.Drawing.Size(197, 64);
            this.groupBoxRemote.TabIndex = 9;
            this.groupBoxRemote.TabStop = false;
            this.groupBoxRemote.Text = "Remote configuration";
            // 
            // buttonRemoteConnect
            // 
            this.buttonRemoteConnect.Enabled = false;
            this.buttonRemoteConnect.Location = new System.Drawing.Point(132, 34);
            this.buttonRemoteConnect.Name = "buttonRemoteConnect";
            this.buttonRemoteConnect.Size = new System.Drawing.Size(58, 23);
            this.buttonRemoteConnect.TabIndex = 6;
            this.buttonRemoteConnect.Text = "Connect";
            this.buttonRemoteConnect.UseVisualStyleBackColor = true;
            this.buttonRemoteConnect.Click += new System.EventHandler(this.ButtonRemoteConnect_Click);
            // 
            // checkBoxIsRemote
            // 
            this.checkBoxIsRemote.AutoSize = true;
            this.checkBoxIsRemote.Checked = true;
            this.checkBoxIsRemote.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxIsRemote.Location = new System.Drawing.Point(11, 19);
            this.checkBoxIsRemote.Name = "checkBoxIsRemote";
            this.checkBoxIsRemote.Size = new System.Drawing.Size(52, 17);
            this.checkBoxIsRemote.TabIndex = 5;
            this.checkBoxIsRemote.Text = "Local";
            this.checkBoxIsRemote.UseVisualStyleBackColor = true;
            this.checkBoxIsRemote.CheckedChanged += new System.EventHandler(this.CheckBoxIsRemote_CheckedChanged);
            // 
            // comboBoxConnectTo
            // 
            this.comboBoxConnectTo.FormattingEnabled = true;
            this.comboBoxConnectTo.Location = new System.Drawing.Point(76, 36);
            this.comboBoxConnectTo.Name = "comboBoxConnectTo";
            this.comboBoxConnectTo.Size = new System.Drawing.Size(47, 21);
            this.comboBoxConnectTo.TabIndex = 3;
            // 
            // labelConnectInfo
            // 
            this.labelConnectInfo.AutoSize = true;
            this.labelConnectInfo.Location = new System.Drawing.Point(8, 39);
            this.labelConnectInfo.Name = "labelConnectInfo";
            this.labelConnectInfo.Size = new System.Drawing.Size(62, 13);
            this.labelConnectInfo.TabIndex = 2;
            this.labelConnectInfo.Text = "Connect to:";
            // 
            // groupBoxMainStatus
            // 
            this.groupBoxMainStatus.Controls.Add(this.radioButtonMainOff);
            this.groupBoxMainStatus.Controls.Add(this.radioButtonMainOn);
            this.groupBoxMainStatus.Location = new System.Drawing.Point(11, 8);
            this.groupBoxMainStatus.Name = "groupBoxMainStatus";
            this.groupBoxMainStatus.Size = new System.Drawing.Size(106, 40);
            this.groupBoxMainStatus.TabIndex = 5;
            this.groupBoxMainStatus.TabStop = false;
            this.groupBoxMainStatus.Text = "SuperVisor";
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
            this.radioButtonMainOff.CheckedChanged += new System.EventHandler(this.RadioButtonMainOff_CheckedChanged);
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
            this.radioButtonMainOn.CheckedChanged += new System.EventHandler(this.RadioButtonMainOn_CheckedChanged);
            // 
            // tabPageProcessesSettings
            // 
            this.tabPageProcessesSettings.Location = new System.Drawing.Point(4, 22);
            this.tabPageProcessesSettings.Name = "tabPageProcessesSettings";
            this.tabPageProcessesSettings.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageProcessesSettings.Size = new System.Drawing.Size(728, 398);
            this.tabPageProcessesSettings.TabIndex = 1;
            this.tabPageProcessesSettings.Text = "Settings";
            this.tabPageProcessesSettings.UseVisualStyleBackColor = true;
            // 
            // openFileDialogExecutables
            // 
            this.openFileDialogExecutables.FileName = "openFileDialogExecutables";
            // 
            // di_SuperVisor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 446);
            this.Controls.Add(this.tabControlMain);
            this.Controls.Add(this.statusStripMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "di_SuperVisor";
            this.Text = "SuperVisor";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Di_SuperVisor_FormClosed);
            this.Load += new System.EventHandler(this.Di_SuperVisor_Load);
            this.Resize += new System.EventHandler(this.Di_SuperVisor_Resize);
            this.panelProcessList.ResumeLayout(false);
            this.panelMain.ResumeLayout(false);
            this.groupBoxProcess.ResumeLayout(false);
            this.groupBoxProcess.PerformLayout();
            this.statusStripMain.ResumeLayout(false);
            this.statusStripMain.PerformLayout();
            this.tabControlMain.ResumeLayout(false);
            this.tabPageProcesses.ResumeLayout(false);
            this.tabPageProcesses.PerformLayout();
            this.groupBoxLog.ResumeLayout(false);
            this.groupBoxExecutables.ResumeLayout(false);
            this.groupBoxExecutables.PerformLayout();
            this.groupBoxRemote.ResumeLayout(false);
            this.groupBoxRemote.PerformLayout();
            this.groupBoxMainStatus.ResumeLayout(false);
            this.groupBoxMainStatus.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxProcList;
        private System.Windows.Forms.Panel panelProcessList;
        private System.Windows.Forms.Label labelStatusInd;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.GroupBox groupBoxProcess;
        private System.Windows.Forms.StatusStrip statusStripMain;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelTime;
        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabPageProcesses;
        private System.Windows.Forms.TabPage tabPageProcessesSettings;
        private System.Windows.Forms.GroupBox groupBoxMainStatus;
        private System.Windows.Forms.RadioButton radioButtonMainOff;
        private System.Windows.Forms.RadioButton radioButtonMainOn;
        private System.Windows.Forms.GroupBox groupBoxRemote;
        private System.Windows.Forms.ComboBox comboBoxConnectTo;
        private System.Windows.Forms.Label labelConnectInfo;
        private System.Windows.Forms.GroupBox groupBoxExecutables;
        private System.Windows.Forms.Button buttonRemoteConnect;
        private System.Windows.Forms.CheckBox checkBoxIsRemote;
        private System.Windows.Forms.OpenFileDialog openFileDialogExecutables;
        private System.Windows.Forms.Button buttonFilesBrowse;
        private System.Windows.Forms.Label labelFilesIsActive;
        private System.Windows.Forms.CheckedListBox checkedListBoxExe;
        private System.Windows.Forms.Button buttonFileLock;
        private System.Windows.Forms.GroupBox groupBoxLog;
        private System.Windows.Forms.ListBox listBoxLog;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
    }
}

