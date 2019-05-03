using CiscoCLIGuide.Model;
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
    public partial class oknoNastaveniLogSouboru : Form
    {
        public oknoNastaveniLogSouboru()
        {
            InitializeComponent();
        }

        //Povolení textboxu v případě povoleného logování
        private void checkBoxLogovani_CheckedChanged(object sender, EventArgs e)
        {
            textBoxCesta.Enabled = checkBoxLogovani.Checked;
        }

        //Zvolení cesty (SaveFileDialog)
        private void buttonZvolit_Click(object sender, EventArgs e)
        {
            //Načtení názvu souboru
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBoxCesta.Text = saveFileDialog1.FileName;
            }
        }

        //Uložení cesty
        private void buttonUlozitCestu_Click(object sender, EventArgs e)
        {
            //Logování zapnuto, ale není navolený soubor
            if (checkBoxLogovani.Checked && textBoxCesta.Text == "")
            {
                MessageBox.Show("Chybný vstup! Cesta není nastavena.", "CHYBA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Uložení parametrů do příslušené třídy
            Logovani.povolitLogovani = checkBoxLogovani.Checked;
            Logovani.cestaKLogSouboru = textBoxCesta.Text;
        }
    }
}
