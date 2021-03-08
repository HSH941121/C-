using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimerEx
{
    public partial class Form1 : Form
    {
        Stopwatch myWatch;
        TimeSpan myTimespan;
        Timer StopWatchTimer;
        public Form1()
        {
            InitializeComponent();
        }

        private string getCurrentTime(int input)
        {
            DateTime curTime = DateTime.Now;
            int hour = curTime.Hour;
            int minite = curTime.Minute;
            int sec = curTime.Second;
            int milsec = curTime.Millisecond;

            DateTime NYTime = curTime - new TimeSpan(13, 0, 0);

            string result; 
            if(input == 0)
            {
                result = curTime.ToLongTimeString(); //string.Format("{0:00} {1:00} {2:00} {3:0000}", hour, minite, sec, milsec);
            }
            else
            {
                result = NYTime.ToLongTimeString();
            }
            return result;
            
        }

        private void timerNow_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = getCurrentTime(0);
            labelClock.Text = getCurrentTime(0);
            labelNewyork.Text = getCurrentTime(1);
        }

        private void StopWatchTimer_Tick(object sender, EventArgs e)
        {
            labelStop.Text = myWatch.Elapsed.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.StopWatchTimer = new Timer(this.components);
            StopWatchTimer.Interval = 50;
            this.StopWatchTimer.Tick += new System.EventHandler(this.StopWatchTimer_Tick);


            timerNow.Interval = 10;
            timerNow.Start();
            myWatch = new Stopwatch();
        }

        private void btStart_Click(object sender, EventArgs e)
        {
            myWatch.Start();
            StopWatchTimer.Start();
        }

        private void btPause_Click(object sender, EventArgs e)
        {
            myWatch.Stop();
        }

        private void btStop_Click(object sender, EventArgs e)
        {
            myWatch.Reset();
         
        }
    }
}
