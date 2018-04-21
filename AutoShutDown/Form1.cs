using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace AutoShutDown
{
    public partial class Form1 : Form
    {
        DateTime datetime = DateTime.MinValue;
        string Hour = "";
        string Minute = "";
        string Second = "";

        public Form1()
        {   
            InitializeComponent();
            cmbHour.SelectedIndex = 0;
            timer1.Interval = 1000;
            timer1.Start();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            datetime = dtp1.Value;
            Hour = cmbHour.SelectedItem.ToString();
            Minute = nudMinute.Value.ToString().PadLeft(2, '0');
            Second = nudSecond.Value.ToString().PadLeft(2, '0');
            lblResult.Text = "您的電腦將於" + datetime + " " + Hour + "時 " + Minute + "分 " + Second + "秒關機";
            lblResult.Refresh();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (System.DateTime.Now.ToString("yyyyMMddHHmmss") == datetime.ToString("yyyyMMdd") + Hour + Minute + Second)
            {
                string FileLink = @"C:\WINDOWS\system32\shutdown.exe";
                Process ShutDown = new Process();
                ShutDown.StartInfo.FileName = FileLink;
                ShutDown.StartInfo.Arguments = "-s -t 0";
                ShutDown.Start();
            }
        }
    }
}
