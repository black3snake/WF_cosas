using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WF_cosas.Properties;

namespace WF_cosas
{
    public partial class Form1 
    {
        public void Pinging(string address, int timeout, Label label )
        {
            using (Ping pi = new Ping())
            {
                PingReply pingReply = null;
                try
                {
                    pingReply = pi.Send(address, timeout);
                    Invoke(new System.Action(() =>
                    {
                        label.Text = pingReply.RoundtripTime.ToString();
                    }));
                }
                catch (Exception)
                {
                    Invoke(new System.Action(() =>
                    {
                        label.Text = "No";
                    }));
                }
                if (pingReply.Status.ToString().Equals("Success"))
                {
                    pictureBox1.BackgroundImage = Resources.status_sign_positive_checked_check_accepted_success_icon_220294;
                }
                else
                {
                    pictureBox1.BackgroundImage = Resources.status_sign_negative_cancel_icon_220300;
                }

            }
        }


    }
}
