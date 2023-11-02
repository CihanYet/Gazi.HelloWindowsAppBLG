using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gazi.HelloWindowsAppBLG
{
    public partial class Frm2 : Form
    {
        Frm1 frm;//Frm2'nin this
        public Frm2(Frm1 frm)
        {
            InitializeComponent();
            this.frm = frm;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm.Text = txtBaslik.Text;
        }
    }
}
