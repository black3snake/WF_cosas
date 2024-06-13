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

        /*private static string cosas = "172.17.252.243";
        private static string rgufk = "rgufk.ru";
        private static string ifrgufk = "ifrgufk.ru";
        private static string int_ifrgufk = "192.168.0.1";
        private static string ITIL = "172.17.250.12";*/
        private static int timeout = 2000;  // 2 сек

        private static Dictionary<string, string> addressaD = new Dictionary<string, string>
        {
            { "cosas", "172.17.252.243" },
            { "rgufk", "rgufk.ru" },
            { "ifrgufk", "ifrgufk.ru" },
            { "int_ifrgufk", "192.168.0.1" },
            { "ITIL", "172.17.250.12" },
            { "cisco", "84.244.48.75" },
            { "bbb2", "84.244.48.76" }
        };

        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            await Task.Run(() =>
            {
                
                foreach (var address in addressaD.Keys) {
                
                    switch (address)
                    {
                        case "cosas":
                            {
                                Pinging(address, timeout, label7);
                                break;
                            }
                        case "rgufk":
                            {
                                Pinging(address, timeout, label6);
                                break;
                            }
                        case "ifrgufk":
                            {
                                Pinging(address, timeout, label5);
                                break;
                            }
                        case "int_ifrgufk":
                            {
                                Pinging(address, timeout, label9);
                                break;
                            }
                        case "ITIL":
                            {
                                Pinging(address, timeout, label1);
                                break;
                            }
                        case "cisco":
                            {
                                //Pinging(address, timeout, label5);
                                break;
                            }
                        case "bbb2":
                            {
                                //Pinging(address, timeout, label5);
                                break;
                            }

                    }
                
                }
                
                


                

            });
        }


    }
}
