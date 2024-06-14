using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_cosas
{
    public partial class Form1 : Form
    {
        #region Alternative
        /*private static int timeout = 2000;  // 2 сек
        private static Dictionary<string, string> addressaD = new Dictionary<string, string>
        {
            { "cosas", "172.17.252.243" },
            { "rgufk", "rgufk.ru" },
            { "ifrgufk", "ifrgufk.ru" },
            { "int_ifrgufk", "192.168.0.1" },
            { "ITIL", "172.17.250.12" },
            { "cisco", "84.244.48.75" },
            { "bbb2", "84.244.48.76" }
        };*/
        #endregion

        Dictionary<string, DataS> addressaC = new Dictionary<string, DataS>();
        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            Server server = new Server(this);
            addressaC = server.SetPoleObjets();


            await Task.Run(() =>
            {
                foreach (var address in addressaC.Values)
                {
                    Pinging(address.AddressS, address.TimeOutS, address.LabelS, address.PictureBoxS);
                }
            });



            #region Alternative
            /*await Task.Run(() =>
            {
                
                foreach (var address in addressaD.Keys) {
                
                    switch (address)
                    {
                        case "cosas":
                            {
                                Pinging(addressaD[address], timeout, label7, pictureBox3);
                                break;
                            }
                        case "rgufk":
                            {
                                Pinging(addressaD[address], timeout, label6, pictureBox2);
                                break;
                            }
                        case "ifrgufk":
                            {
                                Pinging(addressaD[address], timeout, label5, pictureBox1);
                                break;
                            }
                        case "int_ifrgufk":
                            {
                                Pinging(addressaD[address], timeout, label9, pictureBox4);
                                break;
                            }
                        case "ITIL":
                            {
                                Pinging(addressaD[address], timeout, label11, pictureBox5);
                                break;
                            }
                        case "cisco":
                            {
                                Pinging(addressaD[address], timeout, label14, pictureBox6);
                                break;
                            }
                        case "bbb2":
                            {
                                Pinging(addressaD[address], timeout, label15, pictureBox7);
                                break;
                            }

                    }
                
                }

            });*/
            #endregion
        }
    }
}
