using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WF_cosas.Properties;

namespace WF_cosas
{
    public partial class Form1 : Form
    {

        private static string cosas = "172.17.252.243";
        private static string rgufk = "rgufk.ru";
        private static string ifrgufk = "ifrgufk.ru";
        private static string int_ifrgufk = "192.168.0.1";
        private static string ITIL = "172.17.250.12";
        private static int timeout = 2000;  // 2 сек

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            using (Ping pi = new Ping())
            {
                PingReply pingReply = null;
                try
                {
                pingReply = pi.Send(ifrgufk, timeout);
                label5.Text = pingReply.RoundtripTime.ToString();
                }
                catch (Exception)
                {
                    label5.Text = "No";
                }
                if (pingReply.Status.ToString().Equals("Success")) {
                    pictureBox1.BackgroundImage = Resources.status_sign_positive_checked_check_accepted_success_icon_220294;
                } else
                {
                    pictureBox1.BackgroundImage = Resources.status_sign_negative_cancel_icon_220300;
                }

            }

            using (Ping pi2 = new Ping())
            {
                PingReply pingReply = null;
                try
                {
                    pingReply = pi2.Send(rgufk, timeout);
                    label6.Text = pingReply.RoundtripTime.ToString();
                }
                catch (Exception)
                {
                    label6.Text = "No";
                }
                if (pingReply.Status.ToString().Equals("Success"))
                {
                    pictureBox2.BackgroundImage = Resources.status_sign_positive_checked_check_accepted_success_icon_220294;
                }
                else
                {
                    pictureBox2.BackgroundImage = Resources.status_sign_negative_cancel_icon_220300;
                }
            }


            using (Ping pi3 = new Ping())
            {
                PingReply pingReply = null;
                pingReply = pi3.Send(cosas, timeout);
                label7.Text = pingReply.RoundtripTime.ToString();
                if (pingReply.Status.ToString().Equals("Success"))
                {
                    pictureBox3.BackgroundImage = Resources.status_sign_positive_checked_check_accepted_success_icon_220294;
                }
                else
                {
                    pictureBox3.BackgroundImage = Resources.status_sign_negative_cancel_icon_220300;
                }
            }

            using (Ping pi4 = new Ping())
            {
                PingReply pingReply = null;
                pingReply = pi4.Send(int_ifrgufk, timeout);
                label9.Text = pingReply.RoundtripTime.ToString();
                if (pingReply.Status.ToString().Equals("Success"))
                {
                    pictureBox4.BackgroundImage = Resources.status_sign_positive_checked_check_accepted_success_icon_220294;
                }
                else
                {
                    pictureBox4.BackgroundImage = Resources.status_sign_negative_cancel_icon_220300;
                }

            }
            
            using (Ping pi5 = new Ping())
            {
                PingReply pingReply = null;
                pingReply = pi5.Send(ITIL, timeout);
                label11.Text = pingReply.RoundtripTime.ToString();
                if (pingReply.Status.ToString().Equals("Success"))
                {
                    pictureBox5.BackgroundImage = Resources.status_sign_positive_checked_check_accepted_success_icon_220294;
                }
                else
                {
                    pictureBox5.BackgroundImage = Resources.status_sign_negative_cancel_icon_220300;
                }

            }

        }


    }
}
