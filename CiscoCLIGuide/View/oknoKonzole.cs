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
using PrimS.Telnet;

namespace CiscoCLIGuide.View
{
    public partial class oknoKonzole : Form
    {
        Client client;
        public async Task Read()
        {
            tbVystup.Text += "\n" + await client.ReadAsync();
        }
        public oknoKonzole()
        {
            InitializeComponent();
            client = new Client("tulak.host", 52556, new System.Threading.CancellationToken());
            Read();
        }

        private void tbVystup_TextChanged(object sender, EventArgs e)
        {
            tbVystup.SelectionStart = tbVystup.Text.Length;
            tbVystup.ScrollToCaret();
        }

        private void cbDarkMode_CheckedChanged(object sender, EventArgs e)
        {
            if (cbDarkMode.Checked)
            {
                this.BackColor = Color.Black;
                tbVstup.ForeColor = Color.White;
                tbVystup.ForeColor = Color.White;
                tbVystup.BackColor = Color.Black;
                tbVstup.BackColor = Color.Black;
                tbVystup.BorderStyle = BorderStyle.None;
                cbDarkMode.ForeColor = Color.White;
            }
            else
            {
                this.BackColor = Color.White;
                tbVstup.ForeColor = Color.Black;
                tbVystup.ForeColor = Color.Black;
                tbVystup.BackColor = Color.White;
                tbVstup.BackColor = Color.White;
                tbVystup.BorderStyle = BorderStyle.Fixed3D;
                cbDarkMode.ForeColor = Color.Black;
            }
        }

        private void tbVstup_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                client.WriteLine((sender as TextBox).Text);
                (sender as TextBox).Text = "";
                Read();
                tbVystup.Text += ((sender as TextBox).Text + Environment.NewLine);
                (sender as TextBox).Text = "";

                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }
    }
}
