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

namespace AutoShutdown
{
    public partial class Form1 : Form
    {
        private short Hours, Minutes, Seconds, Mile;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text != "")
            {
                timer1.Enabled = true;
                timer1.Start();
                button1.Enabled = false;
            }
            else
            {
                MessageBox.Show("Select time !", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (comboBox1.Text == "Custom")
            {
                if (htxt.Text == "" && mtxt.Text == "" && stxt.Text == "")
                {
                    timer1.Stop();
                    timer1.Enabled = false;
                    button1.Enabled = true;
                    htxt.Clear();
                    mtxt.Clear();
                    stxt.Clear();

                    MessageBox.Show("Select time !", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    if (htxt.Text != "")
                    {
                        Hours = short.Parse(htxt.Text);
                    }else
                    {
                        Hours = 0;
                    }

                    if (mtxt.Text != "")
                    {
                        Minutes = short.Parse(mtxt.Text);
                    }
                    else
                    {
                        Minutes = 0;
                    }

                    if (stxt.Text != "")
                    {
                        Seconds = short.Parse(stxt.Text);
                    }
                    else
                    {
                        Seconds = 0;
                    }

                    htxt.Visible = false;
                    mtxt.Visible = false;
                    stxt.Visible = false;

                    timer1.Enabled = true;
                    timer1.Start();
                    button1.Enabled = false;
                }
            }
          
            if (Hours >= 1)
            {
                progressBar1.Maximum = Hours * 60;

            }
            else
            {
                progressBar1.Maximum = Minutes;

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            mileCount();
            showtime();

            if(hourstxt.Text == "00" && minutetxt.Text == "00" && secondtxt.Text == "00")
            {
                timer1.Stop();
                timer1.Enabled = false;
                button1.Enabled = true;
                htxt.Clear();
                mtxt.Clear();
                stxt.Clear();

                Hours = 00;
                Minutes = 00;
                Seconds = 00;

                hourstxt.Text = Hours.ToString("00");
                minutetxt.Text = Minutes.ToString("00");
                secondtxt.Text = Seconds.ToString("00");

                progressBar1.Value = 0;

                int i = 0;

                if (i == 0)
                {
                    var proc1 = new ProcessStartInfo();
                    string anyCommand = "shutdown /s";
                    proc1.UseShellExecute = true;

                    proc1.WorkingDirectory = @"C:\Windows\System32";

                    proc1.FileName = @"C:\Windows\System32\cmd.exe";
                    proc1.Verb = "runas";
                    proc1.Arguments = "/c " + anyCommand;
                    proc1.WindowStyle = ProcessWindowStyle.Hidden;
                    Process.Start(proc1);
                }
                button1.Enabled = true;
            }

        }
        private void mileCount()
        {
            if (Mile == 0)
            {
                Mile = 59;
                secondsCount();
            }
            else
            {
                Mile--;
            }
        }


        private void secondsCount()
        {
            if(Seconds == 0)
            {
                Seconds = 59;
                bar();
                minutesCount();
               
            }
            else
            {
                Seconds--;
            }
        }

        private void minutesCount()
        {
            if (Minutes == 0)
            {
                Seconds = 59;
                hoursCount();
            }
            else
            {
                Minutes--;
            }
        }

        private void hoursCount()
        {
          Hours--;
          Minutes = 59;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            timer1.Enabled = false;
            button1.Enabled = true;


            Hours = 00;
            Minutes = 00;
            Seconds = 00;

            hourstxt.Text = Hours.ToString("00");
            minutetxt.Text = Minutes.ToString("00");
            secondtxt.Text = Seconds.ToString("00");

            progressBar1.Value = 0;

            comboBox1_SelectedIndexChanged(sender, e);
        }

    

        private void showtime()
        {
            hourstxt.Text = Hours.ToString("00");
            minutetxt.Text = Minutes.ToString("00");
            secondtxt.Text = Seconds.ToString("00");

        }

        private void bar()
        {
            try
            {
                progressBar1.Value++;

            }catch(Exception error) 
            {
                MessageBox.Show("Select time !", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.Text == "5 Minutes")
            {
                Hours = 0;
                Minutes = 4;
                Seconds = 59;
            }

            if (comboBox1.Text == "10 Minutes")
            {
                Hours = 0;
                Minutes = 9;
                Seconds = 59;
            }

            if (comboBox1.Text == "15 Minutes")
            {
                Hours = 0;
                Minutes = 14;
                Seconds = 59;
            }

            if (comboBox1.Text == "30 Minutes")
            {
                Hours = 0;
                Minutes = 29;
                Seconds = 59;
            }

            if (comboBox1.Text == "1 Hour")
            {
                Hours = 0;
                Minutes = 59;
                Seconds = 59;
            }

            if (comboBox1.Text == "2 Hours")
            {
                Hours = 1;
                Minutes = 59;
                Seconds = 59;
            }

            if (comboBox1.Text == "3 Hours")
            {
                Hours = 2;
                Minutes = 59;
                Seconds = 59;
            }

            if (comboBox1.Text == "4 Hours")
            {
                Hours = 3;
                Minutes = 59;
                Seconds = 59;
            }

            if (comboBox1.Text == "5 Hours")
            {
                Hours = 4;
                Minutes = 59;
                Seconds = 59;
            }

            if (comboBox1.Text == "6 Hours")
            {
                Hours = 5;
                Minutes = 59;
                Seconds = 59;
            }

            if (comboBox1.Text == "7 Hours")
            {
                Hours = 6;
                Minutes = 59;
                Seconds = 59;
            }

            if (comboBox1.Text == "8 Hours")
            {
                Hours = 7;
                Minutes = 59;
                Seconds = 59;
            }

            if (comboBox1.Text == "9 Hours")
            {
                Hours = 8;
                Minutes = 59;
                Seconds = 59;
            }

            if (comboBox1.Text == "10 Hours")
            {
                Hours = 9;
                Minutes = 59;
                Seconds = 59;
            }

            if (comboBox1.Text == "11 Hours")
            {
                Hours = 10;
                Minutes = 59;
                Seconds = 59;
            }

            if (comboBox1.Text == "12 Hours")
            {
                Hours = 11;
                Minutes = 59;
                Seconds = 59;
            }

            if (comboBox1.Text == "24 Hours")
            {
                Hours = 23;
                Minutes = 59;
                Seconds = 59;
            }

            if (comboBox1.Text == "Custom")
            {
                htxt.Visible = true;
                mtxt.Visible = true;
                stxt.Visible = true;

            }else
            {
                htxt.Visible = false;
                mtxt.Visible = false;
                stxt.Visible = false;
            }
        }
    }
}
