using System;

namespace Console_BankaFaiz
{
    class Program
    {
        public static double getYillikFaizHesap_Orani(double para)
        {
            if (para < 50000)
            {
                return 0.003;
            }
            else if (para < 100000)
            {
                return 0.004;
            }
            else if (para < 500000)
            {
                return 0.005;
            }
            else
            {
                return 0.008;
            }
        }
        public static double getAylikFaizHesap_Orani(double para)
        {
            if (para < 50000)
            {
                return 0.003;
            }
            else if (para < 100000)
            {
                return 0.004;
            }
            else if (para < 500000)
            {
                return 0.005;
            }
            else
            {
                return 0.008;
            }
        }
        public static double getGunlukFaizHesap_Orani(double para)
        {
            if (para < 50000)
            {
                return 0.002;
            }
            else if (para < 100000)
            {
                return 0.003;
            }
            else if (para < 500000)
            {
                return 0.004;
            }
            else
            {
                return 0.006;
            }
        }

        public static double getYillikFaizHesap_Boleni()
        {
            return 100d;
        }
        public static double getAylikFaizHesap_Boleni()
        {
            return 1200d;
        }
        public static double getGunlukFaizHesap_Boleni()
        {
            return 36500d;
        }

        public static void Menu()
        {
            Console.WriteLine("\t-------------------------------");
            Console.WriteLine("\t----CRAFT BANKA HOŞGELDİNİZ----");
            
            Console.WriteLine("");
            Console.WriteLine("\t\t[1] Günlük Faiz");
            Console.WriteLine("\t\t---------------");
            Console.WriteLine("\t\t[2] Aylık  Faiz");
            Console.WriteLine("\t\t---------------");
            Console.WriteLine("\t\t[3] Yıllık Faiz");
            Console.WriteLine("\t\t---------------\n");
        }
        public static int getSecim()
        {
            int secim = -1;
            do
            {
                Console.Write(" Lütfen Seçiminizi Yapınız.");
                secim = Convert.ToInt32(Console.ReadLine());
            } while (secim != 1 && secim != 2 && secim !=3 );
            
            Console.Clear();
            return secim;
        }

        public static double Anapara_Al()
        {
            int onay = 0;
            double para = 0;
            do
            {
                Console.WriteLine("Lütfen Anaparanızı Giriniz.");
                para = Convert.ToDouble(Console.ReadLine());
                Console.Clear();

                Console.WriteLine("Anaparanız : " + para);
                Console.WriteLine("[1] Onay \n[2] Değiştir ");
                onay = Convert.ToInt32(Console.ReadLine());

            } while (onay != 1);
            return para;
        }
        static void Main(string[] args)
        {
            Menu();

            int secim = getSecim();
            double para = Anapara_Al();
            Hesaplama(secim, para);
            

            Console.Read();
        }
        

        public static void Hesaplama(int secim,double para)
        {
            switch (secim)
            {
                case 1:
                    Console.WriteLine("Kazancınız : " + GunlukFaizHesap(para));
                    break;

                case 2:
                    Console.WriteLine("Kazancınız : " + AylikFaizHesap(para));
                    break;
                case 3:
                    Console.WriteLine("Kazancınız : " + YillikFaizHesap(para));
                    break;
            }
        }
        public static int getGun(string metin)
        {
            Console.WriteLine(metin);
            int gun = Convert.ToInt32(Console.ReadLine());

            Console.Clear();
            return gun;
        }

        public static double GunlukFaizHesap(double para)
        {
            int gun = getGun("Kaç Gün Kalacağını Belirtiniz.");

            double oran = getGunlukFaizHesap_Orani(para);
            double temp = (double)gun;
            double bolen = getGunlukFaizHesap_Boleni();

            return (para * oran * temp) / bolen;
        }

        public static double AylikFaizHesap(double para)
        {
            int ay = getGun("Kaç Ay Kalacağını Belirtiniz.");

            double oran = getAylikFaizHesap_Orani(para);
            double temp = (double)ay;
            double bolen = getAylikFaizHesap_Boleni();

            return (para * oran * temp) / bolen;
        }

        public static double YillikFaizHesap(double para)
        {
            int yil = getGun("Kaç Yil Kalacağını Belirtiniz.");

            double oran = getAylikFaizHesap_Orani(para);
            double temp = (double)yil;
            double bolen = getYillikFaizHesap_Boleni();

            return (para * oran * temp) / bolen;
        }

        
    }
}