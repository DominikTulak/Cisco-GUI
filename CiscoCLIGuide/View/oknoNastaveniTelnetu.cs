using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using CiscoCLIGuide.Model;

namespace CiscoCLIGuide.View
{
    public partial class oknoNastaveniTelnetu : Form
    {
        public oknoNastaveniTelnetu()
        {
            InitializeComponent();
        }

        private void buttonUlozit_Click(object sender, EventArgs e)
        {
            //Převod textu na IP
            IPAddress adresaTelnetu = null;
            bool vysledekPrevodu = IPAddress.TryParse(textBoxIPAdresa.Text, out adresaTelnetu);

            //Převod se nezdařil...
            if (vysledekPrevodu == false)
            {
                MessageBox.Show("Neplatný formát adresy. Použij standartní IPv4 notaci!", "CHYBA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else //Převod se zdařil
            {
                //Uložíme hodnoty do příslušené třídy
                TelnetNastaveni.adresaTelnetu = adresaTelnetu;
                TelnetNastaveni.cisloPortu = (int)ciselnikPort.Value;
            }
        }

        //Načtení okna (převyplnění adresy)
        //Načtení okna (předvyplnění adresy)
        private void oknoNastaveniTelnetu_Load(object sender, EventArgs e)
        {
            textBoxIPAdresa.Text = Convert.ToString(Dns.GetHostByName(Dns.GetHostName()).AddressList[0]);
        }
    }
}
