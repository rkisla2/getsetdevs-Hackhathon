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
    public partial class Anasayfa : Form
    {
        public Anasayfa()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            ÜrünEkle urunekranı = new ÜrünEkle();
            urunekranı.Show();
            this.Hide();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            TakasEt takaset = new TakasEt();
            takaset.Show();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            ReklamAl reklamAl = new ReklamAl();
            reklamAl.Show();


        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Profil profil = new Profil();
            profil.Show();
        }
    }
}
