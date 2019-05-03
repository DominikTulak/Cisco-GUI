using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using PrimS.Telnet;

namespace CiscoCLIGuide
{
    public partial class Form1 : Form
    {
        public Client tl;
        public async Task tn()
        {
           
            string outf = await tl.ReadAsync();
            textBox1.Text += "\n" + outf;
        }
        public Form1()
        {
            InitializeComponent();
            tl = new Client("tulak.host", 52556, new System.Threading.CancellationToken());
            tn();
            // client.WriteLine("show statistic wan2");
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                tl.WriteLine((sender as TextBox).Text);
                (sender as TextBox).Text = "";
                tn();
            }
        }
    }
}
