using System;
using System.Net.NetworkInformation;
using System.Windows.Forms;
using WF_cosas.Properties;

namespace WF_cosas
{
    public partial class Form1
    {
        public void Pinging(string address, int timeout, Label labelP, PictureBox pictureBoxP)
        {
            using (Ping pi = new Ping())
            {
                PingReply pingReply = null;
                try
                {
                    pingReply = pi.Send(address, timeout);
                    Invoke(new System.Action(() =>
                    {
                        labelP.Text = pingReply.RoundtripTime.ToString();
                    }));
                }
                catch (Exception)
                {
                    Invoke(new System.Action(() =>
                    {
                        labelP.Text = "No";
                    }));
                }
                if (pingReply.Status.ToString().Equals("Success"))
                {
                    pictureBoxP.BackgroundImage = Resources.status_sign_positive_checked_check_accepted_success_icon_220294;
                }
                else
                {
                    pictureBoxP.BackgroundImage = Resources.status_sign_negative_cancel_icon_220300;
                }

            }
        }


    }
}
