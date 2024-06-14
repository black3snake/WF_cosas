using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_cosas
{
    public partial class Form1 : Form
    {
        Dictionary<string, DataS> addressaC = new Dictionary<string, DataS>();
        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            Server server = new Server(this);
            addressaC = server.SetPoleObjets();

            button1.Enabled = false;
            
            await Task.Run(() =>
            {
                foreach (var address in addressaC.Values)
                {
                    Pinging(address.AddressS, address.TimeOutS, address.LabelS, address.PictureBoxS);
                }
            });
            
            button1.Enabled = true;

        }
    }
}
