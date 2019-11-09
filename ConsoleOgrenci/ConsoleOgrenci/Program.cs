using System;

namespace ConsoleOgrenci
{
    class Program
    {
        //Authorized by Yiğit KARAKOYUN VERSION 1.0

        /*  Ogrenci sayısı kullanıcı tarafından girilsin
            Ogrenci notları kullanıcı tarafından girilsin
            Ortalama Not hesaplansın
            Ortalama not ekrana yazılsın
            Sınıfın en büyük ve en kucuk notu ekrana yazılsın
         */

        static void Main(string[] args)
        {
            float[] ogrenciler = null;
            float toplam = 0, ortalamaNot = 0, enbuyuk = 0, enkucuk = 100;

            Console.WriteLine("--- Ortalama Programı ---");

            //Ogrenci sayısı kullanıcı tarafından girilsin
            int ogrenciSayisi = getOgrenciSayisiOkutma();
            ogrenciler = new float[ogrenciSayisi];

            //Öğrenci Notlarının Girişi Başlığı
            Console.Clear();
            Console.WriteLine("---Öğrenci Notlarının Girişi (Notları [0-100] arasında giriniz!)---");

            //Ogrenci notları kullanıcı tarafından girilsin
            int say = 0;
            do
            {
                float notu = getOgrenciNotunuOkutma(say);
                if (getOgrenciNotuDogruMu(notu))
                {
                    addOgrenciEkleme(ogrenciler, say, notu);

                    //Notların toplamını hesaplasın
                    toplam = getOgrenciNotlariniTopla(toplam, notu);

                    //En BuyukMu hesaplansın
                    if (getEnBuyukOgrenciMi(enbuyuk, notu))
                    {
                        enbuyuk = notu;
                    }
                    //En KucukMu hesaplansın
                    if (getEnKucukOgrenciMi(enkucuk, notu))
                    {
                        enkucuk = notu;
                    }

                    say++;
                }

            } while (say < ogrenciSayisi);

            //Ortalama Not hesaplansın
            ortalamaNot = getOgrenciOrtalamaHesapla(toplam, ogrenciSayisi);

            //Öğrenci Notlarının Başlığı
            Console.WriteLine();
            Console.WriteLine("---Öğrenci Notlarının---");

            //Adetini ekrana yazılsın
            Console.WriteLine("Adeti: " + ogrenciSayisi);

            //Ortalama notu ekrana yazılsın
            Console.WriteLine("Ortalaması: " + ortalamaNot);

            //Toplama notunu ekrana yazılsın
            Console.WriteLine("Toplamı: " + toplam);

            //En büyük ve en kucuk notlarını ekrana yazılsın
            Console.WriteLine("En Büyüğü: " + enbuyuk);
            Console.WriteLine("En Küçüğü: " + enkucuk);

            //Finish
            Console.Read();
        }

        private static int getOgrenciSayisiOkutma()
        {
            int adet = -1;
            try
            {
                Console.Write("Öğrenci Adetini Giriniz: ");
                adet = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.Write("Öğrenci Adetini Sayı Olarak Giriniz: ");

            }

            return adet;
        }

        private static float getOgrenciNotunuOkutma(int indeks)
        {
            Console.Write("{0}. Öğrenci Notunu Giriniz: ", indeks + 1);
            return Convert.ToSingle(Console.ReadLine());
        }

        private static bool getOgrenciNotuDogruMu(float ogrenciNotu)
        {
            return ogrenciNotu >= 0 && ogrenciNotu <= 100;
        }

        private static void addOgrenciEkleme(float[] ogrenciler, int indeks, float ogrenciNotu)
        {
            ogrenciler[indeks] = ogrenciNotu;
        }

        private static float getOgrenciNotlariniTopla(float toplam, float ogrenciNotu)
        {
            return toplam + ogrenciNotu;
        }

        private static float getOgrenciOrtalamaHesapla(float toplam, int ogrenciAdeti)
        {
            return toplam / Convert.ToSingle(ogrenciAdeti);
        }

        private static bool getEnBuyukOgrenciMi(float enbuyuk, float ogrenciNotu)
        {
            if (enbuyuk < ogrenciNotu)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private static bool getEnKucukOgrenciMi(float enkucuk, float ogrenciNotu)
        {
            if (enkucuk > ogrenciNotu)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
