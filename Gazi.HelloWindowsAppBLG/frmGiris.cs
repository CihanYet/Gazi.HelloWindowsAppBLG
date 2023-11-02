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
    public partial class frmGiris : Form
    {
        public frmGiris()
        {
            InitializeComponent();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            if (txtAd.Text == String.Empty || txtSoyad.Text == String.Empty)
            {
                MessageBox.Show("Ad soyad zorunludur!");
            }
            else
            {
                frmOyun frm = new frmOyun(txtAd.Text, txtSoyad.Text);
                if (rdKolay.Checked)
                {
                    frm.Size = new Size(300, 300);
                }
                else if (rdOrta.Checked)
                {
                    frm.Size = new Size(500, 500);
                }
                else if(rdZor.Checked)
                {
                    frm.Size = new Size(800, 800);
                }
                else
                {
                    MessageBox.Show("Seviye Seçiniz.");
                    return;
                }
                frm.ShowDialog();
            }
        }
    }
}
