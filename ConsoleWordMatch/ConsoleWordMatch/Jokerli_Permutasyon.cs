using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleWordMatch
{
    class Jokerli_Permutasyon
    {
        Jokerli_Basamaklilar jokerliBasamaklilar = new Jokerli_Basamaklilar();
        Permutasyon_Yapici permutasyon = new Permutasyon_Yapici();

        public void JokerlerDoldur()
        {
            jokerliBasamaklilar.JokerKarakterlerleriniDoldur();
            
        }
        private List<string> JokerliPermutasyonListesi(List<string> basamakList)
        {
            List<string> list = new List<string>();
            foreach (var item in basamakList)
            {
                permutasyon.Permutasyon_Stringi(item);
                foreach (var item2 in permutasyon.list)
                {
                    list.Add(item2);
                }
            }
            return list;
        }
        public List<string> Jokerli_DokuzBasamaklilar_Listesi()
        {
            return JokerliPermutasyonListesi(jokerliBasamaklilar.dokuz_basamaklilar);
        }
        public List<string> Jokerli_SekizBasamaklilar_Listesi()
        {
            return JokerliPermutasyonListesi(jokerliBasamaklilar.sekiz_basamaklilar);
        }
        public List<string> Jokerli_YediBasamaklilar_Listesi()
        {
            return JokerliPermutasyonListesi(jokerliBasamaklilar.yedi_basamaklilar);
        }
        public List<string> Jokerli_AltiBasamaklilar_Listesi()
        {
            return JokerliPermutasyonListesi(jokerliBasamaklilar.alti_basamaklilar);
        }
        public List<string> Jokerli_BesBasamaklilar_Listesi()
        {
            return JokerliPermutasyonListesi(jokerliBasamaklilar.bes_basamaklilar);
        }
        public List<string> Jokerli_DortBasamaklilar_Listesi()
        {
            return JokerliPermutasyonListesi(jokerliBasamaklilar.dort_basamaklilar);
        }
        public List<string> Jokerli_UcBasamaklilar_Listesi()
        {
            return JokerliPermutasyonListesi(jokerliBasamaklilar.uc_basamaklilar);
        }

        public void Yazdir(List<string> list)
        {
            Console.WriteLine("---Harfler---");
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            Console.WriteLine();


        }
    }
}
