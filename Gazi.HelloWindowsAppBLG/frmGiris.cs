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
                Seviye seviye;

                if (rdKolay.Checked)
                {
                    seviye = Seviye.Kolay;
                }
                else if (rdOrta.Checked)
                {
                    seviye = Seviye.Orta;
                }
                else if (rdZor.Checked)
                {
                    seviye = Seviye.Zor;
                }
                else
                {
                    MessageBox.Show("Seviye Seçiniz.");
                    return;
                }


                frmOyun frm = new frmOyun(new GameInfo(txtAd.Text, txtSoyad.Text, seviye));
                frm.ShowDialog();
            }
        }
    }
}
