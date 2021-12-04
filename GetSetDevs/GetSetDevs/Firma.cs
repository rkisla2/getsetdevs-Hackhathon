using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetSetDevs
{
    
        public class Firma
        {
            public string FirmaAdi { get; set; }
            public string FirmaAdresi { get; set; }
            public string FirmaSektoru { get; set; }

        }
        public class Urun : Firma
        {
            public string UrunAdi { get; set; }
            public double UrunMiktarı { get; set; }

        }
        public class FirmaSahipBilgileri : Firma
        {

            public string Ad { get; set; }
            public string SoyAd { get; set; }
            public string KullaniciAdi { get; set; }
            public ulong Sifre { get; set; }


        }

        public class Tarim : Urun
        {
            public int FiyatTarim { get; set; }



        }

        class Tekstil : Urun
        {


            public int FiyatTekstil { get; set; }



        }
        class Endustri : Urun
        {
            public int FiyatEndustri { get; set; }



        }
        class Ziraat : Urun
        {
            public int FiyatZiraat { get; set; }



        }
        class Reklam : Urun
        {
            public int FiyatReklam { get; set; }




        }
    
}
