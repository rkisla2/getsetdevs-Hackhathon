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
    public partial class FormKayıtcs : Form
    {
        public FormKayıtcs()
        {
            InitializeComponent();
        }
        public void KayitMesaji()
        {
            MessageBox.Show("Hesabınız başarıyla oluşturuldu .", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void FormKayıtcs_Load(object sender, EventArgs e)
        {

        }



        private void guna2Button3_Click(object sender, EventArgs e)
        {
            //Nesneleri Oluşturalım...
            FirmaSahipBilgileri TarimFirmaSahip = new FirmaSahipBilgileri();
            FirmaSahipBilgileri TeksitlfirmaSahip = new FirmaSahipBilgileri();
            FirmaSahipBilgileri ZiraatFirmaSahip = new FirmaSahipBilgileri();
            FirmaSahipBilgileri ReklamFirmaSahip = new FirmaSahipBilgileri();
            FirmaSahipBilgileri EndüstriFirmaSahip = new FirmaSahipBilgileri();




            if (Sözlesme_check.Checked == true)
            {
                if (SirketSektör_txt.Text == "Tekstil")//Sektör tekstil ise bilgileri tekstilfirması bilgileirne aktar.
                {
                    TeksitlfirmaSahip.Ad = isim_txt.Text;
                    TeksitlfirmaSahip.SoyAd = Soyİsim_txt.Text;
                    TeksitlfirmaSahip.KullaniciAdi = txtkullaniciadi_txt.Text;
                    TeksitlfirmaSahip.Sifre = Convert.ToUInt64(sifre_txt.Text);
                    TeksitlfirmaSahip.FirmaAdi = sirketismi_txt.Text;
                    TeksitlfirmaSahip.FirmaSektoru = SirketSektör_txt.Text;
                    TeksitlfirmaSahip.FirmaAdresi = SirketAdres_txt.Text;
                    KayitMesaji();

                }
                if (SirketSektör_txt.Text == "Reklam")//Sektör Reklam ise bilgileri reklamfirmasi bilgilerine aktar.
                {
                    ReklamFirmaSahip.Ad = isim_txt.Text;
                    ReklamFirmaSahip.SoyAd = Soyİsim_txt.Text;
                    ReklamFirmaSahip.KullaniciAdi = txtkullaniciadi_txt.Text;
                    ReklamFirmaSahip.Sifre = Convert.ToUInt64(sifre_txt.Text);
                    ReklamFirmaSahip.FirmaAdi = sirketismi_txt.Text;
                    ReklamFirmaSahip.FirmaSektoru = SirketSektör_txt.Text;
                    ReklamFirmaSahip.FirmaAdresi = SirketAdres_txt.Text;
                    KayitMesaji();
                    Form1 Geridön = new Form1();
                    Geridön.Show();
                    this.Hide();

                }
                if (SirketSektör_txt.Text == "Tarım")//SEktör Tarim ise bilgileri tarimfirmasi bilgilerine aktardık.
                {
                    TarimFirmaSahip.Ad = isim_txt.Text;
                    TarimFirmaSahip.SoyAd = Soyİsim_txt.Text;
                    TarimFirmaSahip.KullaniciAdi = txtkullaniciadi_txt.Text;
                    TarimFirmaSahip.Sifre = Convert.ToUInt64(sifre_txt.Text);
                    TarimFirmaSahip.FirmaAdi = sirketismi_txt.Text;
                    TarimFirmaSahip.FirmaSektoru = SirketSektör_txt.Text;
                    TarimFirmaSahip.FirmaAdresi = SirketAdres_txt.Text;
                    KayitMesaji();
                    Form1 Geridön = new Form1();
                    Geridön.Show();
                    this.Hide();

                }
                if (SirketSektör_txt.Text == "Endüstri")//Sektör Endüstri ise Bilgileri endüstrifirmasi bilgilerine aktardık.
                {
                    EndüstriFirmaSahip.Ad = isim_txt.Text;
                    EndüstriFirmaSahip.SoyAd = Soyİsim_txt.Text;
                    EndüstriFirmaSahip.KullaniciAdi = txtkullaniciadi_txt.Text;
                    EndüstriFirmaSahip.Sifre = Convert.ToUInt64(sifre_txt.Text);
                    EndüstriFirmaSahip.FirmaAdi = sirketismi_txt.Text;
                    EndüstriFirmaSahip.FirmaSektoru = SirketSektör_txt.Text;
                    EndüstriFirmaSahip.FirmaAdresi = SirketAdres_txt.Text;
                    KayitMesaji();
                    Form1 Geridön = new Form1();
                    Geridön.Show();
                    this.Hide();

                }
                if (SirketSektör_txt.Text == "Ziraat")//Sektör ziraat ise Bilgileri ziraarfirması bilgilerine aktardık.
                {
                    ZiraatFirmaSahip.Ad = isim_txt.Text;
                    ZiraatFirmaSahip.SoyAd = Soyİsim_txt.Text;
                    ZiraatFirmaSahip.KullaniciAdi = txtkullaniciadi_txt.Text;
                    ZiraatFirmaSahip.Sifre = Convert.ToUInt64(sifre_txt.Text);
                    ZiraatFirmaSahip.FirmaAdi = sirketismi_txt.Text;
                    ZiraatFirmaSahip.FirmaSektoru = SirketSektör_txt.Text;
                    ZiraatFirmaSahip.FirmaAdresi = SirketAdres_txt.Text;
                    KayitMesaji();
                    Form1 Geridön = new Form1();
                    Geridön.Show();
                    this.Hide();

                }

                
            }
            else
            {
                MessageBox.Show("Sözleşme onaylanmadan Kayıt Yapilamaz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("KUllanıcı Sözleşmesi...");
               
        }
    }
}
