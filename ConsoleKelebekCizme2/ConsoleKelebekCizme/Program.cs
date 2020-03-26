using System;

namespace ConsoleKelebekCizme2
{
    class Program
    {
        static void Main(string[] args)
        {
            //15 Değeriyle Çiz Bebeğim :-)
            int boyut = 15;

            //Başlık değeri atama
            string baslik = "Kelebek";

            //Kelebek
            Kelebek kelebek = new Kelebek(true);
            var baslikYaz = kelebek.GetBaslik(baslik,boyut);

            //Başlığı Yazdır
            Console.WriteLine(baslikYaz);

            //Kelebek Çizdirme
            var listem = kelebek.GetKelebekList(boyut);
            foreach (var item in listem)
            {
                Console.WriteLine(item);
            }

            Console.Read();
        }
        
    }
}
