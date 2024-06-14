using System;
using System.Collections.Generic;

namespace WF_cosas
{
    public class Server
    {

        private readonly Form1 Form1S;
        Dictionary<string, DataS> addressaC = new Dictionary<string, DataS>();

        public Server(Form1 form1s)
        {
            if (form1s == null)
                throw new ArgumentNullException("form1s");
            Form1S = form1s;
        }

        public Dictionary<string, DataS> SetPoleObjets()
        {
            addressaC.Add("cosas", new DataS() { NameS = "cosas", AddressS = "172.17.252.243", TimeOutS = 2000, LabelS = Form1S.label7, PictureBoxS = Form1S.pictureBox3 });
            addressaC.Add("rgufk", new DataS() { NameS = "rgufk", AddressS = "rgufk.ru", TimeOutS = 2000, LabelS = Form1S.label6, PictureBoxS = Form1S.pictureBox2 });
            addressaC.Add("ifrgufk", new DataS() { NameS = "ifrgufk", AddressS = "ifrgufk.ru", TimeOutS = 2000, LabelS = Form1S.label5, PictureBoxS = Form1S.pictureBox1 });
            addressaC.Add("int_ifrgufk", new DataS() { NameS = "int_ifrgufk", AddressS = "192.168.0.1", TimeOutS = 2000, LabelS = Form1S.label9, PictureBoxS = Form1S.pictureBox4 });
            addressaC.Add("ITIL", new DataS() { NameS = "ITIL", AddressS = "172.17.250.12", TimeOutS = 2000, LabelS = Form1S.label11, PictureBoxS = Form1S.pictureBox5 });
            addressaC.Add("cisco", new DataS() { NameS = "cisco", AddressS = "84.244.48.75", TimeOutS = 2000, LabelS = Form1S.label14, PictureBoxS = Form1S.pictureBox6 });
            addressaC.Add("bbb2", new DataS() { NameS = "bbb2", AddressS = "84.244.48.76", TimeOutS = 2000, LabelS = Form1S.label15, PictureBoxS = Form1S.pictureBox7 });
            
            return addressaC;
        }

    }
}
