using CiscoCLIGuide.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CiscoCLIGuide
{
    public partial class oknoHlavni : Form
    {
        public oknoHlavni()
        {
            InitializeComponent();
        }

        private void oknoHlavni_Load(object sender, EventArgs e)
        {
            hlavniOkno ho = new hlavniOkno();
            ho.Show();
            

        }
    }
}
