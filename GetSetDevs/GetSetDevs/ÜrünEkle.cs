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
    public partial class ÜrünEkle : Form
    {
        public ÜrünEkle()
        {
            InitializeComponent();
        }
        

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Anasayfa anasayfa = new Anasayfa();
            anasayfa.Show();
            ReklamAl reklamAl = new ReklamAl();
           


        }
        
        private void button_ekle_Click(object sender, EventArgs e)
        {
            double Soğanbirimfiyat = 2;
            double PatatesBİrimFİyat = 1.5;
            double bugdaybirimfiyat = 2.3;
            double domatesbirimfiyat = 3.1;
            double fiyat = 0;
            int miktar = Convert.ToInt32(miktar_txt.Text);
            if (ürün_cmbbox.Text == "Soğan")
            {
                fiyat = Soğanbirimfiyat * miktar;
            }
            if (ürün_cmbbox.Text == "Patates")
            {
                fiyat = PatatesBİrimFİyat * miktar;
            }
            if (ürün_cmbbox.Text == "Bugday")
            {
                fiyat = bugdaybirimfiyat * miktar;
            }
            if (ürün_cmbbox.Text == "Domates")
            {
                fiyat = domatesbirimfiyat * miktar;
            }
            Deger_lbl.Text = fiyat.ToString();

        }
    }
}
