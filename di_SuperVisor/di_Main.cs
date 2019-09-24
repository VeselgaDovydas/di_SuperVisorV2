using NETCOM;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace di_SuperVisor
{
    public partial class di_SuperVisor : Form
    {
        ArrayList procList_ = new ArrayList();
        String[] checkboxList;
        DataTable procInfo;
        IList<PictureBox> pics = new List<PictureBox>();
        List<string> ip = new List<string> { "--", "192.168.0.23", "192.168.0.60", "192.168.0.192", "192.168.0.167" };
        List<AgentRelay> ClientList = new List<AgentRelay>();


        int pic = 0;
        readonly Timer mainTimer = new Timer();
        readonly Timer time = new Timer();

        AgentRelay m_chatProvider = new AgentRelay();
        ServerRelay m_serverRelay = new ServerRelay(true);

        private enum eTcpCommands
        {
            InvalidCommand = 0,
            ChatMessage = 1,

            QueryNameRequest = 2,
            QueryNameResponse = 3,
        };

        public di_SuperVisor()
        {
            InitializeComponent();
        }

        private void Di_SuperVisor_Load(object sender, EventArgs e)
        {
            intiateStatusTimer();
            initiateConnection();
            write_log("SuperVisor ready.");

            if (procList_.Count != 0)
                intiateDt(pics);
            if (radioButtonMainOff.Checked)
                mainTimer.Stop();

        }

        private void initiateConnection() {

            m_chatProvider.OnNewPacketReceived += chatProvider_OnNewPacketReceived;
            m_serverRelay.OnNewAgentConnected += m_serverRelay_OnNewAgentConnected;
            m_serverRelay.OnServerFailedToAcceptConnection += m_serverRelay_OnServerFailedToAcceptConnection;
            m_serverRelay.StartServer(null, 1234);
            m_serverRelay.AcceptIncommingConnections = true;


            int id = 0;
            ip.ForEach(delegate (String s)
            {
                comboBoxConnectTo.Items.Add(new HelperClass.ConnectionTo
                    {
                        ID = id.ToString(),
                        IP = s
                    });
                id++;
            });
            comboBoxConnectTo.SelectedIndex = 0;

        }

        private void intiateDt(IList<PictureBox> pics)
        {
            //Local
            pic = 0;
            int draw = 2;
            procInfo = new DataTable();
            procInfo.Columns.Add("Index");
            procInfo.Columns.Add("Name");
            procInfo.Columns.Add("Status");
            procInfo.Columns.Add("Run");
            foreach (object s in procList_)
            {
                listBoxProcList.Invoke((MethodInvoker)(() => listBoxProcList.Items.Add(s.ToString() + ".exe")));

                pics.Add( new PictureBox
                {
                    AccessibleName = s.ToString(),
                    Location = new System.Drawing.Point(140, draw),
                    Size = new System.Drawing.Size(11, 11),
                    BackColor = Color.Red
                });

                draw += 13;
                panelProcessList.Invoke((MethodInvoker)(() => panelProcessList.Controls.Add(pics[pic])));

                DataRow r = procInfo.Rows.Add();
                r[0] = listBoxProcList.Items.Count - 1;
                r[1] = s;
                r[2] = 2;
                r[3] = false ;
                pic++; 
            }
        }

        private void Tick_time(object sender, EventArgs e) {
            toolStripStatusLabelTime.Text = DateTime.Now.ToString("HH:mm:ss    MMM-dd");
        }

        private void Tick(object sender, EventArgs e) {
            
            //Local
            if (ClientList.Count <= 0)
            {
                foreach (DataRow r in procInfo.Rows)
                {
                    r.BeginEdit();
                    r[3] = false;
                    r.EndEdit();
                }
                listBoxProcList.SelectedIndex = -1;
                listBoxProcList.BeginUpdate();

                Process[] localAll = Process.GetProcesses();
                foreach (Process p in localAll)
                {
                    DataRow[] r = procInfo.Select("Name ='" + p.ProcessName + "'");
                    if (r.Length != 0)
                    { //Rado procesa dt
                        r[0].BeginEdit();
                        r[0][2] = p.Responding ? 1 : 0;
                        listBoxProcList.SelectedIndex = Convert.ToInt32(r[0][0].ToString());
                        // status changed
                        pics[listBoxProcList.SelectedIndex].BackColor = (p.Responding ? Color.Green : Color.Orange);
                        r[0][3] = true;
                        r[0].EndEdit();
                    }
                }
                updateStatusImg(procInfo);

                listBoxProcList.SelectedIndex = -1;
                listBoxProcList.EndUpdate();
            }
            else {


            }
        }

        private void updateStatusImg(DataTable dt) {
            foreach (DataRow r in dt.Rows) {
                if (Convert.ToBoolean(r[3].ToString()) == false) 
                    pics[Convert.ToInt32(r[0].ToString())].BackColor = Color.Red;
            }
        }

        private void RadioButtonMainOn_CheckedChanged(object sender, EventArgs e)
        {
                intiateTimer();
        }

        private void RadioButtonMainOff_CheckedChanged(object sender, EventArgs e)
        {


            mainTimer.Stop();
            updateStatusImgTored(procInfo);

        }

        public void updateStatusImgTored(DataTable dt) {

            foreach (DataRow r in dt.Rows) {
                r.BeginEdit();
                r[2] = 2;
                r.EndEdit();
            }
            foreach (PictureBox p in pics) {
                p.BackColor = Color.Red;
            }
        }

        private void intiateStatusTimer()
        {
            string[] Text = Application.ProductVersion.Split('.');
            this.Text = this.Text + " " + Text[0]+"."+Text[2] + "." + Text[3];

            this.listBoxProcList.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.listBox1_DrawItem);
            toolStripStatusLabelTime.Margin = new Padding(this.Width - 140, 0, 0, 0);
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.AllPaintingInWmPaint, true);
            time.Start();
            time.Interval = 1000;
            time.Tick += new EventHandler(Tick_time);
            time.Enabled = true;
        }

        private void intiateTimer()
        {
            mainTimer.Start();
            mainTimer.Interval = 1000;
            mainTimer.Tick += new EventHandler(Tick);
            mainTimer.Enabled = true;
        }

        private void listBox1_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0) return;
            if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
                e = new DrawItemEventArgs(e.Graphics,
                                          e.Font,
                                          e.Bounds,
                                          e.Index,
                                          e.State ^ DrawItemState.Selected,
                                          e.ForeColor,
                                          Color.Transparent);
        }
 
        private void Di_SuperVisor_Resize(object sender, EventArgs e)
        {
            toolStripStatusLabelTime.Margin = new Padding(this.Width - 140, 0, 0, 0);
        }

        private void ButtonFilesBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog od = new OpenFileDialog
            {
                InitialDirectory = @"C:\Users\Dovydas\Desktop\Testas\exeTest",
                Title = "Browse Text Files",

                CheckFileExists = true,
                CheckPathExists = true,

                DefaultExt = "txt",
                Filter = " txt files (*.txt)|*.txt| Executable files (*.exe) | *.exe| All files (*.*)|*.*",
                FilterIndex = 3,
                RestoreDirectory = true,

                ReadOnlyChecked = true,
                ShowReadOnly = true
            };

            if (od.ShowDialog() == DialogResult.OK)
            {
                if (!od.FileName.Contains(".txt")) {
                    string[] a = od.SafeFileName.Split('.');
                    checkedListBoxExe.Items.Add(a[0]);
                }
                else
                {
                    StreamReader sr = new StreamReader(od.FileName);
                    checkboxList = (sr.ReadToEnd()).Split(',');

                    int i = 0;
                    if(checkboxList.Length != 0 || procList_.Count != 0)
                    {
                        foreach (string s in checkboxList) {
                            checkedListBoxExe.Items.Add(s);
                            checkedListBoxExe.SetItemChecked(i, true);
                            i++;
                        }
                    }
                } 
            }
        }

        private void ButtonFileLock_Click(object sender, EventArgs e)
        {
            if (checkedListBoxExe.Enabled)
            {
                checkedListBoxExe.Enabled = false;
                buttonFileLock.Text = "Unlock";

                foreach (string s in checkedListBoxExe.CheckedItems)
                    procList_.Add(s);

                if (checkBoxIsRemote.Checked)
                    intiateDt(pics);
                else
                    SendChatMessage("LOCK:" + string.Join(",", procList_.ToArray()).Trim());
                
            }
            else
            {
                checkedListBoxExe.Enabled = true;
                buttonFileLock.Text = "Lock";
                procList_.Clear();
                listBoxProcList.Items.Clear();
                pic = 0;
                                   
                foreach (PictureBox p in pics) {
                    panelProcessList.Controls.Remove(p);
                    pic ++;
                }
                pics.Clear();
                radioButtonMainOff.Checked = true;
            }
        }

        private void ButtonRemoteConnect_Click(object sender, EventArgs e)
        {
            string ip = ((HelperClass.ConnectionTo)comboBoxConnectTo.SelectedItem).IP;

            try
            {
                m_chatProvider.Connect(ip, 1234);
            }
            catch
            {
                MessageBox.Show("IP Address is invalid or the other side is not accessable!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        public void write_log(string s) {
            string time = DateTime.Now.ToString("HH:mm:ss");
            listBoxLog.Items.Add(time +": "+ s);
        }

        private void chatProvider_OnNewPacketReceived(AgentRelay.Packet packet, AgentRelay agentRelay)
        {

            string command = AgentRelay.MakeStringFromPacketContents(packet);


            if (command.Contains("LOCK:")) {
                string cmd = command.Split(':')[1];
                string[] result = cmd.Split(',');

                foreach (string r in result) {
                    if (!procList_.Contains(r)){
                        procList_.Add(r);
                        checkedListBoxExe.Invoke((MethodInvoker)(() => checkedListBoxExe.Items.Add(r)));

                    }
                    //Already here

                }



            }else
                this.Invoke(new MethodInvoker(() => { listBoxLog.Items.Insert(0, command); }));

        }

        void m_serverRelay_OnNewAgentConnected(AgentRelay agentRelay) {
            //New User 
            ClientList.Add(agentRelay);


            agentRelay.OnNewPacketReceived += chatProvider_OnNewPacketReceived;
            m_chatProvider = agentRelay;
            SendChatMessage("Connected");
            string conIp = (agentRelay.Client.RemoteEndPoint.ToString()).Split(':')[0];
            this.Invoke(new MethodInvoker(() =>{listBoxLog.Items.Add("New agent received: "+ conIp);}));


        }

        public bool SendChatMessage(string txt)
        {
            return m_chatProvider.SendMessage((int)eTcpCommands.ChatMessage, txt);
        }

        public bool SendMessageToAll(string txt)
        {
            bool send = false;
            foreach (AgentRelay a in ClientList) {
                a.SendMessage((int)eTcpCommands.ChatMessage, txt);
                send = true;
            }
            if (ClientList.Count <= 0)
            {
                return m_chatProvider.SendMessage((int)eTcpCommands.ChatMessage, txt);
            }
            else {
                return send = true;
            }
        }


        void m_serverRelay_OnServerFailedToAcceptConnection(Exception ex)
        {
            this.Invoke(new MethodInvoker(() => { listBoxLog.Items.Insert(0, "EXCEPTION in ServerRelay: " + ex.Message); }));
        }

        private void Di_SuperVisor_FormClosed(object sender, FormClosedEventArgs e)
        {
            m_chatProvider.Dispose();
            m_serverRelay.Dispose();        // m_serverRelay.StopServer(true);
        }

        private void CheckBoxIsRemote_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxIsRemote.Checked)
                buttonRemoteConnect.Enabled = false;
            else
                buttonRemoteConnect.Enabled = true;
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            //SendChatMessage(textBox1.Text.Trim());
            SendMessageToAll(textBox1.Text.Trim());
        }
    }
}

/*
 string splitCmd;
            if (command.Contains("LOCK:"))
            {
                splitCmd = command.Split(':')[1];
                string[] a = splitCmd.Split(',');
                foreach (object n in a)
                {
                    procList_.Add(n.ToString());
                }

                intiateDt(pics);
            }else if(command.Contains("PROCINFO:"))
            {
                splitCmd = command.Split(':')[1];
                string[] a = splitCmd.Split(',');

                if (procInfo == null || procInfo.Rows.Count <= 0) {
                    intiateDt(pics);
                }

                DataRow[] r1 = procInfo.Select("Name = '" + a[1].ToString()+"'");
                r1[0].BeginEdit();
                r1[0][0] = a[0].ToString();
                r1[0][1] = a[1].ToString();
                r1[0][2] = a[2].ToString();
                r1[0][3] = a[3].ToString();
                r1[0].EndEdit();

                //pics[listBoxProcList.SelectedIndex].BackColor = (Convert.ToBoolean(r1[0][2].ToString()) ? Color.Green : Color.Orange);

                panelProcessList.Invoke((MethodInvoker)(() => pics[Convert.ToInt32(r1[0][0].ToString())].BackColor = (r1[0][2].ToString() == "1") ? Color.Green : Color.Orange));


                updateStatusImg(procInfo);


            }
            else
 */
