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
    public partial class oknoNastaveniHesla : Form
    {
        public oknoNastaveniHesla()
        {
            InitializeComponent();
        }

        //Změna stavu kteréhokoliv z checkboxů
        private void checkBoxKonzole_CheckedChanged(object sender, EventArgs e)
        {
            //Aktualizace stavů checkboxů
            textBoxEXEC.Enabled = checkBoxEXEC.Checked;
            textBoxKonzole.Enabled = checkBoxKonzole.Checked;
            textBoxTelnet.Enabled = checkBoxTelnet.Checked;
        }

        //Tlačítko pro uložení stavu
        private void buttonUlozit_Click(object sender, EventArgs e)
        {
            //Kontrola prázdných hesel
            if (textBoxEXEC.Enabled && textBoxEXEC.Text == "" 
                || textBoxKonzole.Enabled && textBoxKonzole.Text == ""
                || textBoxTelnet.Enabled && textBoxTelnet.Text == "")
            {
                MessageBox.Show("Chybný vstup! Zadej hesla, která jsi zaškrtl!", "CHYBA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Uložení požadavků na heslo
            Hesla.hesloEXEC = checkBoxEXEC.Checked;
            Hesla.hesloKonzole = checkBoxKonzole.Checked;
            Hesla.hesloTelnet = checkBoxTelnet.Checked;

            //Uložení hesel (prázdné heslo nevadí)
            Hesla.hesloEXECString = textBoxEXEC.Text;
            Hesla.hesloKonzoleString = textBoxKonzole.Text;
            Hesla.hesloTelnetString = textBoxTelnet.Text;

            //Ohlášení splnění
            MessageBox.Show("Úspěšně uloženo.", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
