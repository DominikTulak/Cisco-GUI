using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CiscoCLIGuide.Model;

namespace CiscoCLIGuide.View
{
    public partial class oknoNastaveniRS232 : Form
    {
        public oknoNastaveniRS232()
        {
            InitializeComponent();
        }

        //Tlačítko pro uložení parametrů sériového portu
        private void buttonUlozit_Click(object sender, EventArgs e)
        {
            //Přečtení hodnot do proměnných
            int cisloPortu = (int)ciselnikPort.Value;
            bool stopbity = true; if (radioButtonStopbity1.Checked) stopbity = false;
            int databity = (int)ciselnikDataBity.Value;

            //Baud rate (nastavení výchozí hodnoty)
            int baudovaRychlost = 9600;
            if (comboBoxBaudRate.Text != "") baudovaRychlost = Convert.ToInt32(comboBoxBaudRate.Text);

            //Parita
            Parita parita = Parita.ZADNA;
            if (comboBoxParita.Text == "Sudá") parita = Parita.SUDA;
            if (comboBoxParita.Text == "Lichá") parita = Parita.LICHA;

            //Uložení proměnných do konfigurační třídy
            RS232.baudovaRychlost = baudovaRychlost;
            RS232.cisloPortu = cisloPortu;
            RS232.parita = parita;
            RS232.pocetDataBitu = databity;
            RS232.pocetStopBitu = stopbity;


        }
    }
}
