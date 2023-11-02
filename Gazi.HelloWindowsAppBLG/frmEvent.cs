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
    public partial class frmEvent : Form
    {
        int sonuc = 0;
        public frmEvent()
        {
            InitializeComponent();
        }

        private void frmEvent_MouseMove(object sender, MouseEventArgs e)
        {            
            lblKoordinat.Text = e.Location.ToString();
            lblKoordinat.Location = e.Location;
        }

        private void frmEvent_MouseLeave(object sender, EventArgs e)
        {            
            lblKoordinat.Text = String.Empty;
        }

        private void Topla(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            sonuc += int.Parse(btn.Text);
        }

        private void btnSonuc_Click(object sender, EventArgs e)
        {
            MessageBox.Show(sonuc.ToString());
        }
    }
}
