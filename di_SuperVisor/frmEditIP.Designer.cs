namespace di_SuperVisor
{
    partial class frmServerEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmServerEdit));
            this.groupBoxNewIP = new System.Windows.Forms.GroupBox();
            this.checkBoxAdminCmd = new System.Windows.Forms.CheckBox();
            this.labelNewIPDesc = new System.Windows.Forms.Label();
            this.labelNewIP = new System.Windows.Forms.Label();
            this.buttonNewIPSave = new System.Windows.Forms.Button();
            this.richTextBoxIPDesc = new System.Windows.Forms.RichTextBox();
            this.textBoxNewIP = new System.Windows.Forms.TextBox();
            this.labelLogin = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.groupBoxNewIP.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxNewIP
            // 
            this.groupBoxNewIP.Controls.Add(this.textBoxPassword);
            this.groupBoxNewIP.Controls.Add(this.textBoxLogin);
            this.groupBoxNewIP.Controls.Add(this.labelPassword);
            this.groupBoxNewIP.Controls.Add(this.labelLogin);
            this.groupBoxNewIP.Controls.Add(this.checkBoxAdminCmd);
            this.groupBoxNewIP.Controls.Add(this.labelNewIPDesc);
            this.groupBoxNewIP.Controls.Add(this.labelNewIP);
            this.groupBoxNewIP.Controls.Add(this.buttonNewIPSave);
            this.groupBoxNewIP.Controls.Add(this.richTextBoxIPDesc);
            this.groupBoxNewIP.Controls.Add(this.textBoxNewIP);
            this.groupBoxNewIP.Location = new System.Drawing.Point(12, 12);
            this.groupBoxNewIP.Name = "groupBoxNewIP";
            this.groupBoxNewIP.Size = new System.Drawing.Size(371, 160);
            this.groupBoxNewIP.TabIndex = 1;
            this.groupBoxNewIP.TabStop = false;
            this.groupBoxNewIP.Text = "Edit IP";
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
            this.buttonNewIPSave.Location = new System.Drawing.Point(265, 124);
            this.buttonNewIPSave.Name = "buttonNewIPSave";
            this.buttonNewIPSave.Size = new System.Drawing.Size(93, 30);
            this.buttonNewIPSave.TabIndex = 2;
            this.buttonNewIPSave.Text = "Save";
            this.buttonNewIPSave.UseVisualStyleBackColor = true;
            this.buttonNewIPSave.Click += new System.EventHandler(this.ButtonNewIPSave_Click);
            // 
            // richTextBoxIPDesc
            // 
            this.richTextBoxIPDesc.Location = new System.Drawing.Point(49, 55);
            this.richTextBoxIPDesc.Name = "richTextBoxIPDesc";
            this.richTextBoxIPDesc.Size = new System.Drawing.Size(185, 99);
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
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Location = new System.Drawing.Point(255, 27);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(33, 13);
            this.labelLogin.TabIndex = 6;
            this.labelLogin.Text = "Login";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(255, 67);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(53, 13);
            this.labelPassword.TabIndex = 7;
            this.labelPassword.Text = "Password";
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Location = new System.Drawing.Point(258, 44);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(100, 20);
            this.textBoxLogin.TabIndex = 8;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(258, 83);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(100, 20);
            this.textBoxPassword.TabIndex = 9;
            // 
            // frmServerEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 182);
            this.Controls.Add(this.groupBoxNewIP);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmServerEdit";
            this.Text = "Server Edit";
            this.Load += new System.EventHandler(this.FrmServerEdit_Load);
            this.groupBoxNewIP.ResumeLayout(false);
            this.groupBoxNewIP.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxNewIP;
        private System.Windows.Forms.CheckBox checkBoxAdminCmd;
        private System.Windows.Forms.Label labelNewIPDesc;
        private System.Windows.Forms.Label labelNewIP;
        private System.Windows.Forms.Button buttonNewIPSave;
        private System.Windows.Forms.RichTextBox richTextBoxIPDesc;
        private System.Windows.Forms.TextBox textBoxNewIP;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxLogin;
    }
}