using System;

namespace ConsoleOgrenci3
{
    class Program
    {
        //Authorized by Yiğit KARAKOYUN VERSION 3.0

        /*  Ogrenci sayısı kullanıcı tarafından girilsin
            Ogrenci notları kullanıcı tarafından girilsin
            Ortalama Not hesaplansın
            Ortalama not ekrana yazılsın
            Sınıfın en büyük ve en kucuk notu ekrana yazılsın
         */

        static void Main(string[] args)
        {
            #region DEĞİŞKENLERİ TANIMLAMA
            float[] ogrenciler = null;
            float toplam = 0, ortalamaNot = 0, enbuyuk = 0, enkucuk = 100;
            #endregion

            #region ÖĞRENCİLERİN ADETİ BİLGİSİNİ OKUMA 

            //Program Başlığı
            Console.WriteLine("--- Ortalama Programı ---");

            //Ogrenci sayısı kullanıcı tarafından girilsin
            int ogrenciSayisi = 0;
            do
            {
                ogrenciSayisi = getOgrenciSayisiOkutma();
            } while (ogrenciSayisi <= 0);
            #endregion

            #region OGRENCILER DİZİSİNİ OLUŞTURMA
            ogrenciler = new float[ogrenciSayisi];
            #endregion

            #region MENU YAZDIRMA
            //Öğrenci Notlarının Girişi Başlığı
            Console.Clear();
            Console.WriteLine("---Öğrenci Notlarının Girişi (Notları [0-100] arasında giriniz!)---");
            Console.WriteLine();
            Console.WriteLine("---{0} Adet Öğrencinin Notu Girilecektir---", ogrenciSayisi);
            #endregion

            #region NOTLARI OKUTMA
            //Ogrenci notları kullanıcı tarafından girilsin
            int say = 0;
            do
            {
                float notu = getOgrenciNotunuOkutma(say);
                if (getOgrenciNotuDogruMu(notu))
                {
                    addOgrenciEkleme(ogrenciler, say, notu);
                    say++;
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("***{0}. Öğrencinin Notunu 0 - 100 aralığında sayı giriniz***", say + 1);
                }


            } while (say < ogrenciSayisi);
            #endregion

            #region TUM HESAPLAMALAR
            //Hesaplamalar
            for (int i = 0; i < ogrenciler.Length; i++)
            {
                float notu = ogrenciler[i];

                //Notların Toplamını Hesaplar
                toplam += notu;

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

            }
            //Notların Ortalaması hesaplasın
            ortalamaNot += getOgrenciOrtalamaHesapla(toplam, ogrenciSayisi);

            #endregion

            #region SONUÇLARI YAZDIRIR

            //Sonuçlar Başlığı
            Console.WriteLine();
            Console.WriteLine("------Sonuçlar------");

            //Öğrenci Notlarını Yazdırır
            Console.Write("Öğrenci Notları: ");
            for (int i = 0; i < ogrenciler.Length; i++)
            {
                Console.Write("{0} ", ogrenciler[i]);
            }

            Console.WriteLine();

            //Adetini ekrana yazılsın
            Console.WriteLine("Öğrenci Notlarının Adeti: " + ogrenciSayisi);

            //Ortalama notu ekrana yazılsın
            Console.WriteLine("Öğrenci Notlarının Ortalaması: " + ortalamaNot);

            //Toplama notunu ekrana yazılsın
            Console.WriteLine("Öğrenci Notlarının Toplamı: " + toplam);

            //En büyük ve en kucuk notlarını ekrana yazılsın
            Console.WriteLine("Öğrenci Notlarının En Büyüğü: " + enbuyuk);
            Console.WriteLine("Öğrenci Notlarının En Küçüğü: " + enkucuk);

            #endregion

            #region BEKLETME KOMUTU
            Console.Read();
            #endregion
        }

        #region GEREKLİ METODLAR
        private static int getOgrenciSayisiOkutma()
        {
            int adet = -1;
            try
            {
                Console.Write("Öğrenci Adetini Giriniz: ");
                int tempAdet = Convert.ToInt32(Console.ReadLine());
                if (tempAdet > 0)
                {
                    adet = tempAdet;
                }
                else
                {
                    Console.WriteLine();
                    Console.Write("***Öğrenci Adetini Sıfır Sayısından Daha Büyük Olarak Giriniz***");
                    Console.WriteLine();
                }

            }
            catch (Exception)
            {
                Console.WriteLine();
                Console.Write("***Öğrenci Adetini Sayı Olarak Giriniz***");
                Console.WriteLine();
            }

            return adet;
        }

        private static float getOgrenciNotunuOkutma(int indeks)
        {
            Console.Write("{0}. Öğrenci Notunu Giriniz: ", indeks + 1);
            float temp = -1f;
            try
            {
                string tempString = Console.ReadLine().Replace('.', ',');

                float tempSayi = Convert.ToSingle(tempString);
                if (tempSayi >= 0)
                {
                    temp = tempSayi;
                }
            }
            catch (Exception)
            {
                //Console.WriteLine();
                //Console.Write("{0}. Öğrencinin Notunu Sayı Olarak Giriniz: ", indeks + 1);
            }
            return temp;
        }

        private static bool getOgrenciNotuDogruMu(float ogrenciNotu)
        {
            return ogrenciNotu >= 0 && ogrenciNotu <= 100;
        }

        private static void addOgrenciEkleme(float[] ogrenciler, int indeks, float ogrenciNotu)
        {
            if (ogrenciler == null)
            {
                Console.WriteLine("Öğrenciler dizini boş gönderdin");
                return;
            }
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
        private static float getTekOgrenciOrtalamaHesapla(float notu, int ogrenciAdeti)
        {
            return notu / Convert.ToSingle(ogrenciAdeti);
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
        #endregion
    }
}
