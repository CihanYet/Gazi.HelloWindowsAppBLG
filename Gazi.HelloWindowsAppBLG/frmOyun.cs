﻿using GameLib;
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
        public frmOyun(GameInfo info)
        {
            InitializeComponent();
            lblOyuncu.Text = $"Hoşgeldin,{info.Ad} {info.Soyad}";
            switch (info.Level)
            {
                case Seviye.Kolay:
                    this.Size = new Size(300, 300);
                    sure = 20;
                    btnYakala.Size = new Size(100, 100);
                    break;
                case Seviye.Orta:
                    this.Size = new Size(500, 500);
                    sure = 10;
                    btnYakala.Size = new Size(50, 50);
                    break;
                case Seviye.Zor:
                    this.Size = new Size(800, 800);
                    sure = 5;
                    btnYakala.Size = new Size(20, 20);
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
            if (skor % 5 == 0)
            {
                var btn2 = new Button();
                btn2.Size = new Size(50, 50);
                btn2.Location = new Point(rnd.Next(this.ClientSize.Width - btn.Width - pnlBilgi.Width), rnd.Next(this.ClientSize.Height - btn.Height));
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
