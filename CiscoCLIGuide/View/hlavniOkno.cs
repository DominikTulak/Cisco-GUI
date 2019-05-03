using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CiscoCLIGuide.View
{
    public partial class hlavniOkno : Form
    {
        public hlavniOkno()
        {
            InitializeComponent();
        }

        //Okno pro nastavení sériové linky
        private void menuButtonNastaveniRS_Click(object sender, EventArgs e)
        {
            //Otevření okna pro nastavení RS232
            oknoNastaveniRS232 nastaveniRS232 = new oknoNastaveniRS232();
            nastaveniRS232.ShowDialog();
        }

        //Okno pro nastavení logovacího sobouru
        private void menuButtonNastaveniLog_Click(object sender, EventArgs e)
        {
            //Otevření okna pro nastavení logovacího souboru
            oknoNastaveniLogSouboru nastaveniLog = new oknoNastaveniLogSouboru();
            nastaveniLog.ShowDialog();
        }

        //Okno pro nastavení plaintextu
        private void menuButtonNastaveniPlaintext_Click(object sender, EventArgs e)
        {

        }

        //Okno pro nastavení hesel
        private void menuButtonNastaveniHesel_Click(object sender, EventArgs e)
        { 
            oknoNastaveniHesla nastaveniHesla = new oknoNastaveniHesla();
            nastaveniHesla.ShowDialog();
        }
    }
}
