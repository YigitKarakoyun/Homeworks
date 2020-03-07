using System;

namespace ConsoleWordMatch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------------------------------");
            Jokerli_Permutasyon jip = new Jokerli_Permutasyon();
            jip.JokerlerDoldur();
            var result = jip.Jokerli_UcBasamaklilar_Listesi();
            jip.Yazdir(result);

            Console.Read();
        }
    }

}
