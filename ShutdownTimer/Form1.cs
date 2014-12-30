using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace ShutdownTimer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void shutdownButton_Click(object sender, EventArgs e)
        {
            String force = "";
            String time = "";
            double seconds = 0;
            double minutes = 0;
            double hours = 0;
            Boolean canceled = false;

            if (secondBox.Text == "" && minuteBox.Text == "" && hourBox.Text == "")
            {
                canceled = true;
            }
            else
            {

                //set seconds
                time = secondBox.Text;
                if (time != "")
                {
                    seconds = double.Parse(time);
                }

                //set minutes

                time = minuteBox.Text;
                if (time != "")
                {
                    minutes = double.Parse(time);
                }

                //set hours
                time = hourBox.Text;
                if (time != "")
                {
                    hours = double.Parse(time);
                }

            }
            double shutdownMinutes = minutes;
            double shutdownSeconds = seconds;
            //Calc to seconds
            shutdownMinutes += hours * 60;
            shutdownSeconds += minutes * 60;

            if (checkForce.Checked)
            {
                force = " /f";
            }
            if (!canceled)
            {
                Process.Start("shutdown", " /s /t " + shutdownSeconds + force);
                stateLabel.Text = "Successful Timer set to: " + hours + "h " + minutes + "m " + seconds + "s";
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Process.Start("shutdown", " /a");
            stateLabel.Text = "Canceled";
        }

        private void shutdownNowButton_Click(object sender, EventArgs e)
        {
            String force = "";
            if (checkForce.Checked)
            {
                force = " /f";
            }
            Process.Start("shutdown", " /s /t 0 " + force);

        }

    }
}
