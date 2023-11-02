using System;
using System.Windows.Forms;

namespace Gazi.HelloWindowsAppBLG
{
    public partial class Frm1 : Form
    {
        public Frm1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {           
            Frm2 frm2 = new Frm2(this);
            frm2.Show();
        }
    }
}
