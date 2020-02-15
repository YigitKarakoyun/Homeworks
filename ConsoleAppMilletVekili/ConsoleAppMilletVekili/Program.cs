using System;
namespace ConsoleAppMilletVekili
{
    
    class Program
    {

        static void Main(string[] args)
        {
            //İLDE ÇIKACAK MV SAYISI
            int mv_sayisi = 7;

            //PARTİ BİLGİSİ OLUŞTURMA
            parti_bilgisi GetParti_Bilgisi(string isim, int oy_sayisi)
            {
                parti_bilgisi parti_Bilgisi = new parti_bilgisi();
                parti_Bilgisi.isim = isim + " Partisi";
                parti_Bilgisi.oy_sayisi = oy_sayisi;

                return parti_Bilgisi;
            }

            parti_bilgisi pA = GetParti_Bilgisi("A", 3292);
            parti_bilgisi pD = GetParti_Bilgisi("D", 2531);
            parti_bilgisi pB = GetParti_Bilgisi("B", 2396);
            parti_bilgisi pE = GetParti_Bilgisi("E", 2000);
            parti_bilgisi pC = GetParti_Bilgisi("C", 1900);
            parti_bilgisi pF = GetParti_Bilgisi("F", 1255);
            parti_bilgisi pH = GetParti_Bilgisi("H", 723);
            parti_bilgisi pG = GetParti_Bilgisi("G", 12);

            parti_bilgisi[] parti_bilgileri = new parti_bilgisi[8] 
            {
                pA,pD,pB,pE,pC,pF,pH,pG
            };

            //PARTI OYLARINI YAZDIRIR
            void Parti_OylariYazdir()
            {
                Console.WriteLine("---Parti Oyları---");
                foreach (parti_bilgisi item in parti_bilgileri)
                {
                    Console.WriteLine(item.isim + " " + item.oy_sayisi);
                }
                Console.WriteLine();
            }
            Parti_OylariYazdir();

            //PARTİLERİN KAÇ OY ALMIŞ
            int GetParti_ToplamOyu()
            {
                int toplam = 0;
                foreach (parti_bilgisi item in parti_bilgileri)
                {
                    toplam += item.oy_sayisi; 
                }
                return toplam;
            }
            int toplamOy = GetParti_ToplamOyu();
            Console.WriteLine("---Toplam Oy Sayıları---");
            Console.WriteLine(toplamOy);
            Console.WriteLine();

            //PARTİLERİN OY YÜZDELERİNİ HESAPLA
            void Partilerin_OyYuzdelerini_Hesapla(int toplam_oy)
            {
                for (int i = 0; i < parti_bilgileri.Length; i++)
                {
                    double bolme_sonucu = ((double)parti_bilgileri[i].oy_sayisi / (double)toplam_oy)*100;
                    parti_bilgileri[i].oy_yuzdesi = (bolme_sonucu);
                   
                }
                
            }
            Partilerin_OyYuzdelerini_Hesapla(toplamOy);

            //PARTİLERİN OY YÜZDELERİNİ YAZDIR
            void Parti_YuzdeleriYazdir()
            {
                Console.WriteLine("---Parti Yüzdeleri---");
                foreach (parti_bilgisi item in parti_bilgileri)
                {
                    Console.WriteLine(item.isim + " " + item.oy_yuzdesi);
                }
                Console.WriteLine();
            }
            Parti_YuzdeleriYazdir();

            //PARTILERİN EN BUYUK YUZDESİNİ BULMA
            int GetPartilerin_EnBuyuk_YuzdelisiniBulma()
            {
                double enBuyuk_Yuzde = 0;
                int enBuyuk_indeks = 0;
                for (int i = 0; i < parti_bilgileri.Length; i++)
                {
                    parti_bilgisi item = parti_bilgileri[i];
                    if (enBuyuk_Yuzde < item.oy_yuzdesi)
                    {
                        enBuyuk_Yuzde = item.oy_yuzdesi;
                        enBuyuk_indeks = i;
                    }
                }
                return enBuyuk_indeks;
                
            }
            void Partilerin_MV_Hesapla()
            {
                int temp_mv_sayisi = mv_sayisi;
                int i = 0;
                while (temp_mv_sayisi>0)
                {
                    
                    int enbuyuk_indeks = GetPartilerin_EnBuyuk_YuzdelisiniBulma();
                    parti_bilgileri[enbuyuk_indeks].mv_sayisi++;
                    parti_bilgileri[enbuyuk_indeks].oy_sayisi /= 2;
                    parti_bilgileri[enbuyuk_indeks].oy_yuzdesi /= 2;
                    temp_mv_sayisi--;

                }
                

            }
            Partilerin_MV_Hesapla();


            //MV YAZDIRMA
            void Parti_MVYazdir()
            {
                Console.WriteLine("---Parti MV Sayıları---");
                foreach (parti_bilgisi item in parti_bilgileri)
                {
                    Console.WriteLine(item.isim + " " + item.mv_sayisi);
                }
                Console.WriteLine();
            }
            Parti_MVYazdir();


            Console.Read();
        }


    }

    struct parti_bilgisi
    {
        public string isim;
        public int oy_sayisi;
        public double oy_yuzdesi;
        public int mv_sayisi;
    }
}
