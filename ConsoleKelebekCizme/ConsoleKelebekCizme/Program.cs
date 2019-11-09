using System;

namespace ConsoleKelebekCizme
{
    class Program
    {
        static void Main(string[] args)
        {
            //15 Değeriyle Çiz Bebeğim :-)
            int boyut = 15;

            //Başlık değeri atama
            string baslik = "Kelebek";

            //Başlığı Yazdır
            printBaslik(baslik, boyut);

            //Kelebek Çizdirme
            printKelebekCiz(boyut);

            Console.Read();
        }
        static void printYildiz()
        {
            Console.Write("*");
        }
        static void printBosluk()
        {
            Console.Write(" ");
        }
        static void println()
        {
            Console.WriteLine();
        }
        static void printKelebekString(int bosluk1, int bosluk2, int bosluk3)
        {
            printBoslukYildiz(bosluk1);
            printBoslukYildiz(bosluk2);
            printBoslukYildiz(bosluk3);
        }
        static void printBoslukYildiz(int bosluk)
        {
            for (int i = 0; i < bosluk; i++)
            {
                printBosluk();
            }
            printYildiz();
        }
        static void printKelebekCiz(int kadar)
        {
            int yarisi = (kadar - 3) / 2;

            for (int i = 0; i <= yarisi; i++)
            {
                int bosluk = yarisi - i;
                printKelebekString(i, bosluk, bosluk);
                println();
            }
            int yatayCizgi = kadar;
            if (kadar % 2 == 0)
            {
                yatayCizgi = kadar - 1;
            }
            for (int i = 0; i < yatayCizgi; i++) printYildiz();

            for (int i = yarisi; i >= 0; i--)
            {

                println();
                int bosluk = yarisi - i;
                printKelebekString(i, bosluk, bosluk);

            }
            println();
            println();
        }

        static void printBaslik(string kelime,int boyut)
        {
            int kelimeBoyutu = kelime.Length;
            string yeniKelime = "";
            if (boyut>kelimeBoyutu)
            {
                int yildiz = (boyut - kelimeBoyutu)/2;
                for (int i = 0; i < yildiz; i++)
                {
                    yeniKelime += "-";         
                }
                yeniKelime += kelime;
                for (int i = 0; i < yildiz; i++)
                {
                    yeniKelime += "-";
                }
                Console.WriteLine(yeniKelime);
            }
            else
            {
                Console.WriteLine(kelime);
            }
        }
    }
}
