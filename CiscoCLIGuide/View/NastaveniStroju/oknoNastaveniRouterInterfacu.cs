<<<<<<< HEAD
﻿using System;
=======
﻿using CiscoCLIGuide.Model.NastaveniStroju;
using System;
>>>>>>> 526b27403fd352e30009fb2c2d07eb2efb3b880b
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
<<<<<<< HEAD
=======
using System.Net;
>>>>>>> 526b27403fd352e30009fb2c2d07eb2efb3b880b
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CiscoCLIGuide.View
{
    public partial class oknoNastaveniRouterInterfacu : Form
    {
        public oknoNastaveniRouterInterfacu()
        {
            InitializeComponent();
        }
<<<<<<< HEAD
=======

        //Uložení nastavení
        private void buttonUlozit_Click(object sender, EventArgs e)
        {
            //Uložení druhu interfacu + kontrola, zda byl navolen
            string druhInterfacu = comboBoxDruhIf.Text;
            if (druhInterfacu == "") //Prázdný vstup
            {
                MessageBox.Show("Zvol druh interfacu!", "CHYBA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            RouterInterface.druhInterfacu = druhInterfacu;

            //Uložení označení interfacu
            RouterInterface.oznaceniInterfacu = textBoxOznaceniIf.Text;

            //Uložení informace o povoleni
            RouterInterface.povolitInterface = checkBoxPovolitIf.Checked;

            //Uložení IP adresy + kontrola formátu
            IPAddress IPAdresa = null;
            bool vysledek = IPAddress.TryParse(textBoxIP.Text, out IPAdresa);

            if (vysledek == false) //Převod se nezdařil
            {
                MessageBox.Show("Zadej platný formát IPv4 adresy interfacu!", "CHYBA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            RouterInterface.IPAdresaInterfacu = IPAdresa;

            //Uložení masky + kontrola formátu
            IPAddress maska = null;
            bool vysledek2 = KontrolaMasky.VytvorMasku(textBoxMaska.Text, out maska);

            if (vysledek2 == false) //Převod se nezdařil
            {
                MessageBox.Show("Zadej platný formát IPv4 masky interfacu!", "CHYBA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            RouterInterface.MaskaInterfacu = maska;

            //Uložení decriptionu
            RouterInterface.DescriptionInterfacu = textBoxDescription.Text;

            MessageBox.Show(maska.ToString());
        }
>>>>>>> 526b27403fd352e30009fb2c2d07eb2efb3b880b
    }
}
