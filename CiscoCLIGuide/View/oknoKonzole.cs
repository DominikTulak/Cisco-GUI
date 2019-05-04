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
    public partial class oknoKonzole : Form
    {
        public oknoKonzole()
        {
            InitializeComponent();
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

        private void tbVstup_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                tbVystup.Text +=((sender as TextBox).Text + Environment.NewLine);
                (sender as TextBox).Text = "";
            }
        }
    }
}
