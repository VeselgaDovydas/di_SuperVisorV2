using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Threading;
using System.Timers;
using System.Windows.Forms;

namespace di_SuperVisor
{
    public class Executable
    {
        public Dictionary<int,Color> _statusColors = new Dictionary<int, Color>() {
            {0,Color.Red},
            {1,Color.Green},
            {2,Color.Yellow}
        };

        private System.Windows.Forms.Timer _timer = new System.Windows.Forms.Timer(); 
        private PictureBox _pictureBox = new PictureBox();
        public readonly int _id;
        private static int _idCounter = 0;
        public bool _isCheckedByUser = true;
        public int _idInList { get; set; }
        public int _timerInterval { get;private set; }
        public string _name { get;private set; }
        public int _status { get; private set; }
         
        public Executable(string name)
        {
            this._name = name;
            this._id = ++_idCounter;
            this._status = 0;
            this._pictureBox.Location = new Point(140, 2+(this._id - 1) * 13);
            this._pictureBox.Size = new Size(20, 11);
            this._pictureBox.AccessibleName = name;
            this._pictureBox.BackColor = _statusColors[this._status];
            this._pictureBox.Visible = false;
            this._timer.Interval = 5000; // Default 5 secs
            this._timer.Tick += new EventHandler(CheckProcess);
            this._timer.Start();
        }
        public void SetIdInList(int idInList) {
            this._idInList = idInList; 
        }
        public void SetTimerInterval(int timerInterval) {
            this._timerInterval = timerInterval;
            this._timer.Stop();
            this._timer.Interval = this._timerInterval;
            this._timer.Start();
        }

        public void TimerStatus(bool processTimerStatus) {
            if (processTimerStatus)
                this._timer.Start();
            else
                this._timer.Stop();
        }

        public void ShowPictureBox(bool visible = true) {
            this._pictureBox.Location = new Point(140, 2 + (this._idInList - 1) * 13);
            this._pictureBox.Visible = visible;
        }

        public int GetId() { return _id; }
        public void PictureBoxAddToControl(Control control)
        {
            try
            {
                control.Controls.Add(this._pictureBox);
            }
            catch (Exception e ){
                throw new System.ArgumentException("Parameter cannot be null.", "control " + e.Message);
            }
        }
        public void CheckProcess(object sender, EventArgs e) {
            var process = Process.GetProcessesByName(this._name); // Pagal ideja turim gauti tik viena procesa, jei daugiau tai dublis su juo veliau kazka sugalvosiu

            if (process.Length == 0)
                this._status = 0;
            else if (process[0].Responding)
                this._status = 1;
            else
                this._status = 2;

            this._pictureBox.BackColor = _statusColors[this._status];
        }
    }
}