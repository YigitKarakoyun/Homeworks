using System;

namespace ConsoleKelebekCizme
{
    class Program
    {
        static void Main(string[] args)
        {
            //15 Değeriyle Çiz Bebeğim :-)
            Console.WriteLine("----Kelebek----");
            printKelebekCiz(15);

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


    }
}
