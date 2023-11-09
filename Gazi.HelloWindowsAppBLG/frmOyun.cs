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
    public partial class frmOyun : Form
    {
        int skor = 0;
        int sure = 3;
        public frmOyun(string ad,string soyad,string seviye)
        {
            InitializeComponent();          
            lblOyuncu.Text = $"Hoşgeldin,{ad} {soyad}";
            switch (seviye)
            {
                case "Kolay":
                    this.Size = new Size(300, 300);
                    break;
                case "Orta":
                    this.Size = new Size(500, 500);
                    break;
                case "Zor":
                    this.Size = new Size(800, 800);
                    break;
                default:
                    break;
            }
        }

        private void btnYakala_MouseMove(object sender, MouseEventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.Name == "btnEksi")
            {
                skor--;
            }
            else
            {
                skor++;
            }
            var rnd = new Random();
            btn.Location = new Point(rnd.Next(this.ClientSize.Width - btn.Width - pnlBilgi.Width), rnd.Next(this.ClientSize.Height - btn.Height));

            lblSkor.Text = skor.ToString();
            if (skor == 5)
            {
                var btn2 = new Button();
                btn2.Size = new Size(50, 50);
                btn2.Location = new Point(0, 0);
                btn2.Name = "btnEksi";
                btn2.MouseMove += btnYakala_MouseMove;
                btn2.BackColor = Color.Red;
                this.Controls.Add(btn2);
            }
        }

        private void frmOyun_SizeChanged(object sender, EventArgs e)
        {
            //pnlBilgi.Location = new Point(this.ClientSize.Width - pnlBilgi.Width, 0);
            //pnlBilgi.Height = this.ClientSize.Height;
        }

        private void tmrSure_Tick(object sender, EventArgs e)
        {
            lblSure.Text = sure.ToString();
            if (sure == 0)
            {
                tmrSure.Stop();
                MessageBox.Show($"Süreniz doldu!Skorunuz:{skor}");
                this.Close();
            }
            sure--;
        }

        private void frmOyun_Load(object sender, EventArgs e)
        {
            tmrSure.Start();
        }
    }
}
