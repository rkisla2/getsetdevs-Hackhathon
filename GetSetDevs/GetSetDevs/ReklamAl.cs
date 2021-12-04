using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GetSetDevs
{
    public partial class ReklamAl : Form
    {
        public ReklamAl()
        {
            InitializeComponent();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            Anasayfa geri = new Anasayfa();
            geri.Show();
            this.Hide();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
           
            int googlereklam = 2000;
            int youtubereklam = 1500;
            int instagramreklam = 3000;
            int deger = 0;
            int tekrarsayisi = Convert.ToInt32(tekrarsayisi_txt.Text);
            if (ReklamTürü_cmbbox.Text == "Google")
            {
                deger = googlereklam * tekrarsayisi;
            }
            if (ReklamTürü_cmbbox.Text == "Youtube")
            {
                deger = youtubereklam * tekrarsayisi;
            }
            if (ReklamTürü_cmbbox.Text == "Istagram")
            {
                deger = instagramreklam * tekrarsayisi;
            }
            Deger_lbl.Text = deger.ToString();
        }
    }
}
