using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleWordMatch
{
    class Jokersiz_Basamaklar
    {
        SekizdenKucuk_Basamak_Yapicisi basamak = new SekizdenKucuk_Basamak_Yapicisi();
        SekizliBasamak_Yapici rastgeleYapici = new SekizliBasamak_Yapici();

        public string sekiz_basamakli { get; private set; } = "";
        public List<string> yedi_basamaklilar { get; set; }
        public List<string> alti_basamaklilar { get; set; }
        public List<string> bes_basamaklilar { get; set; }
        public List<string> dort_basamaklilar { get; set; }
        public List<string> uc_basamaklilar { get; set; }
        public List<string> iki_basamaklilar { get; set; }

        public void BasamaklariBul()
        {
            sekiz_basamakli = rastgeleYapici.SekizTane_HarfOlustur();
            yedi_basamaklilar = basamak.YediAltiBesDortUcListesi(sekiz_basamakli);
            alti_basamaklilar = basamak.YediAltiBesDortUcListesi(yedi_basamaklilar);
            bes_basamaklilar = basamak.YediAltiBesDortUcListesi(alti_basamaklilar);
            dort_basamaklilar = basamak.YediAltiBesDortUcListesi(bes_basamaklilar);
            uc_basamaklilar = basamak.YediAltiBesDortUcListesi(dort_basamaklilar);
            iki_basamaklilar = basamak.YediAltiBesDortUcListesi(uc_basamaklilar);
        }
        
    }
}
