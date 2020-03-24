using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace di_SuperVisor
{
    public partial class frmServerEdit : Form
    {
        public string ip = null;
        public string desc = null;
        public bool adminCmd = false;
        public string login = null;
        public string pass = null;
        //string path = System.AppDomain.CurrentDomain.BaseDirectory + "data.vd";

        private string path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\supervisor.vd";

        public frmServerEdit()
        {
            InitializeComponent();
        }

        private void FrmServerEdit_Load(object sender, EventArgs e)
        {
            textBoxNewIP.Text = ip;
            richTextBoxIPDesc.Text = desc;
            checkBoxAdminCmd.Checked = adminCmd;

            textBoxLogin.Text = login;
            textBoxPassword.Text = pass;
        }

        private void ButtonNewIPSave_Click(object sender, EventArgs e)
        {
            int count = 0;
            int i = 0;
            int srv = 0;

            string line;
            StreamReader file = new System.IO.StreamReader(path);
            while ((line = file.ReadLine()) != null)
            {
                if (line.Contains(ip + "]"))
                {
                    srv = Convert.ToInt32(line.Split('=')[0].Trim().Split('v')[1]);
                    count = i;
                }
                i++;
            }
            file.Close();

            List<string> r = new List<string>();
            r.Add("[Srv" + srv + " = " + textBoxNewIP.Text.Trim() + "]");
            r.Add("Desc =" + richTextBoxIPDesc.Text.Trim() + ";");
            r.Add("AdminCMD =" + checkBoxAdminCmd.Checked.ToString().Trim() + ";");
            r.Add("Login =" + textBoxLogin.Text.Trim() + ";");
            r.Add("Password =" + textBoxPassword.Text.Trim() + ";");

            foreach (string s in r)
            {
                //new di_SuperVisor().confFileUpdate("\t" + s, path, count + 1);
                count++;
            }
            count = 0;
            this.Close();
        }
    }
}