using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleWordMatch
{
    class Jokerli_Basamaklilar
    {
        Jokersiz_Basamaklar basamaklar = new Jokersiz_Basamaklar();
        Joker_Yapicisi jokerler = new Joker_Yapicisi();

        public List<string> dokuz_basamaklilar { get; set; }
        public List<string> sekiz_basamaklilar { get; set; }
        public List<string> yedi_basamaklilar { get; set; }
        public List<string> alti_basamaklilar { get; set; }
        public List<string> bes_basamaklilar { get; set; }
        public List<string> dort_basamaklilar { get; set; }
        public List<string> uc_basamaklilar { get; set; }

        public void JokerKarakterlerleriniDoldur()
        {
            basamaklar.BasamaklariBul();

            dokuz_basamaklilar = 
                jokerler.Jokerli_AnlamsizKelimeOlustur(basamaklar.sekiz_basamakli);

            sekiz_basamaklilar =
                jokerler.Jokerli_AnlamsizKelimeOlustur(basamaklar.yedi_basamaklilar);

            yedi_basamaklilar =
                jokerler.Jokerli_AnlamsizKelimeOlustur(basamaklar.alti_basamaklilar);

            alti_basamaklilar =
                jokerler.Jokerli_AnlamsizKelimeOlustur(basamaklar.bes_basamaklilar);

            bes_basamaklilar =
                jokerler.Jokerli_AnlamsizKelimeOlustur(basamaklar.dort_basamaklilar);

            dort_basamaklilar =
                jokerler.Jokerli_AnlamsizKelimeOlustur(basamaklar.uc_basamaklilar);

            uc_basamaklilar =
                jokerler.Jokerli_AnlamsizKelimeOlustur(basamaklar.iki_basamaklilar);

        }

        public void Yazdir(List<string> KelimelerList)
        {
            Console.WriteLine("---Kelimeler---");
            foreach (var item in KelimelerList)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            Console.WriteLine();


        }
    }
}
