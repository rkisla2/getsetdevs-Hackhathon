using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
public void KayitMesaji()
{
    MessageBox.Show("Hesabınız başarıyla oluşturuldu .", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
}
namespace GetSetDevs
{
    public partial class Kaydol : Form
    {
        public Kaydol()
        {
            InitializeComponent();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {  //Burada her birfirma alt sınıfından  nesne oluşturduk...
            FirmaSahipBilgileri TarimFirmaSahip = new FirmaSahipBilgileri();
            FirmaSahipBilgileri TeksitlfirmaSahip = new FirmaSahipBilgileri();
            FirmaSahipBilgileri ZiraatFirmaSahip = new FirmaSahipBilgileri();
            FirmaSahipBilgileri ReklamFirmaSahip = new FirmaSahipBilgileri();
            FirmaSahipBilgileri EndsüstriFirmaSahip = new FirmaSahipBilgileri();
                if (checkBox1.Checked == true)
                {
                    if (guna2ComboBox1.Text == "Tekstil")//Burada bİgileri nesnenin property lerine aktardık.
                    {   //TEKSTİL
                        TeksitlfirmaSahip.Ad = txtbx1.Text;
                        TeksitlfirmaSahip.SoyAd = txtbx2.Text;
                        TeksitlfirmaSahip.KullaniciAdi = txtbx3.Text;
                        TeksitlfirmaSahip.Sifre = Convert.ToUInt64(txtbx4.Text);
                        TeksitlfirmaSahip.FirmaAdi = txtbx5.Text;
                        TeksitlfirmaSahip.FirmaAdresi = txtbx7.Text;
                        TeksitlfirmaSahip.FirmaSektoru = "Tekstil";
                    KayitMesaji();
                        Form1 Geridön = new Form1();
                        Geridön.Show();
                        this.Hide();
                    
                       
                    }
                    if (guna2ComboBox1.Text == "Reklam")
                    {   //REKLAM
                        ReklamFirmaSahip.Ad = txtbx1.Text;
                        ReklamFirmaSahip.SoyAd = txtbx2.Text;
                        ReklamFirmaSahip.KullaniciAdi = txtbx3.Text;
                        ReklamFirmaSahip.Sifre = Convert.ToUInt64(txtbx4.Text);
                        ReklamFirmaSahip.FirmaAdi = txtbx5.Text;
                        ReklamFirmaSahip.FirmaAdresi = txtbx7.Text;
                        ReklamFirmaSahip.FirmaSektoru = "Reklam";
                        Form1 Geridön = new Form1();
                        Geridön.Show();
                        this.Hide();
                }

                    if (guna2ComboBox1.Text == "Tarım")
                    {   //TARIM
                        TarimFirmaSahip.Ad = txtbx1.Text;
                        TarimFirmaSahip.SoyAd = txtbx2.Text;
                        TarimFirmaSahip.KullaniciAdi = txtbx3.Text;
                        TarimFirmaSahip.Sifre = Convert.ToUInt64(txtbx4.Text);
                        TarimFirmaSahip.FirmaAdi = txtbx5.Text;
                        TarimFirmaSahip.FirmaAdresi = txtbx7.Text;
                        TarimFirmaSahip.FirmaSektoru = "Tarım";
                        Form1 Geridön = new Form1();
                        Geridön.Show();
                        this.Hide();
                }
                    if (guna2ComboBox1.Text == "Endüstri")
                    {   //Endüstri
                        EndsüstriFirmaSahip.Ad = txtbx1.Text;
                        EndsüstriFirmaSahip.SoyAd = txtbx2.Text;
                        EndsüstriFirmaSahip.KullaniciAdi = txtbx3.Text;
                        EndsüstriFirmaSahip.Sifre = Convert.ToUInt64(txtbx4.Text);
                        EndsüstriFirmaSahip.FirmaSektoru = "Endüstri";
                        EndsüstriFirmaSahip.FirmaAdi = txtbx5.Text;
                        EndsüstriFirmaSahip.FirmaAdresi = txtbx7.Text;
                       
                       
                        Form1 Geridön = new Form1();
                        Geridön.Show();
                        this.Hide();
                }
                    if (guna2ComboBox1.Text == "Ziraat")
                    {   //ZİRAAT
                        ZiraatFirmaSahip.Ad = txtbx1.Text;
                        ZiraatFirmaSahip.SoyAd = txtbx2.Text;
                        ZiraatFirmaSahip.KullaniciAdi = txtbx3.Text;
                        ZiraatFirmaSahip.Sifre = Convert.ToUInt64(txtbx4.Text);
                        ZiraatFirmaSahip.FirmaAdi = txtbx5.Text;
                        ZiraatFirmaSahip.FirmaAdresi = txtbx7.Text;
                        ZiraatFirmaSahip.FirmaSektoru = "Ziraat";   
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
            MessageBox.Show("Kişisel Verilerin Toplanması, İşlenmesi ve İşleme AmaçlarıKişisel verileriniz, Softtech tarafından verilen hizmet, ürün ya da ticari faaliyete bağlı olarak değişkenlik gösterebilmekle beraber; otomatik ya da otomatik olmayan yöntemlerle, ofisler, internet sitesi, sosyal medya mecraları, mobil uygulamalar ve benzeri vasıtalarla sözlü, yazılı ya da elektronik olarak toplanabilecektir.Softtech’in ürün ve hizmetlerinden yararlandığınız müddetçe oluşturularak ve güncellenerek kişisel verileriniz işlenebilecektir.Ayrıca, Softtech hizmetlerini kullanmak niyetiyle internet sayfamızı kullandığınızda, Softtech’i veya internet sitemizi ziyaret ettiğinizde, Softtech’in düzenlediği eğitim, seminer veya organizasyonlara katıldığınızda kişisel verileriniz işlenebilecektir","Aydınlatma Metni",MessageBoxButtons.OK,MessageBoxIcon.Information);
                      }
    }
}

