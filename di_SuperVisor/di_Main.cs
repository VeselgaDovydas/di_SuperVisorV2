using Microsoft.VisualBasic.Devices;
using NETCOM;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Management;
using System.Net;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace di_SuperVisor
{
    public partial class di_SuperVisor : Form
    {
        #region Variables
        private AgentRelay m_chatProvider = new AgentRelay();
        private ServerRelay m_serverRelay = new ServerRelay(true);
        private string path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\supervisor.vd";
        public List<Executable> executables = new List<Executable>();

        private enum eTcpCommands
        {
            InvalidCommand = 0,
            ChatMessage = 1,
            QueryNameRequest = 2,
            QueryNameResponse = 3,
            DriveInformation = 4,
        };
        public enum StatusInt { 
            NotResponding,
            Responding,
            Off
        };
        #endregion Variables

        public di_SuperVisor()
        {
            InitializeComponent();
        }

        private void Di_SuperVisor_Load(object sender, EventArgs e)
        {
            
 
        }

        private void buttonFilesBrowse_Click(object sender, EventArgs e)
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
                if (!od.FileName.Contains(".txt"))
                {
                    string[] a = od.SafeFileName.Split('.');
                    checkedListBoxExe.Items.Add(a[0]);
                }
                else
                {
                    StreamReader sr = new StreamReader(od.FileName);
                    var allExecutables = (sr.ReadToEnd()).Split(',');

                    //Ikisam visus exe failus i klase
                    foreach (string s in allExecutables) {
                        var exe = new Executable(s.Trim());
                        exe.PictureBoxAddToControl(panelProcessList);
                        executables.Add(exe);
                        checkedListBoxExe.Items.Add(exe._name, true); 
                    } 
                }
            }
        }

        private void buttonFileLock_Click(object sender, EventArgs e)
        {
            //Clearing already existing ones
            if (listBoxProcList.Items.Count != 0)
            {
                listBoxProcList.Items.Clear();

                foreach (Executable exe in executables)
                {
                    exe.ShowPictureBox(false);
                    exe._idInList = -1;
                }

            }

            // Setting executables to listBoxProcList.Items.Add(exe._name);
            foreach (Executable exe in executables.AsEnumerable().Where(x => x._isCheckedByUser == true))
            {
                listBoxProcList.Items.Add(exe._name);
                exe._idInList = listBoxProcList.Items.Count;
                exe.ShowPictureBox(true);
            }


        }

        private void checkedListBoxExe_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (executables.Count > 0) {
                Executable exe = executables[e.Index];
                exe._isCheckedByUser = e.NewValue.ToString() == "Checked"? true : false;
            }
        }
    }
}