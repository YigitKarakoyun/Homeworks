using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleWordMatch
{
    public class SekizliBasamak_Yapici
    {
        Random rastgele = new Random();
        string[] harfler = Alfabe.harfler_dizisi;


        //------------------------------------------------------
        public string SekizTane_HarfOlustur()
        {
            string temp = "";
            for (int i = 0; i < 8; i++)
            {
                temp += BirTane_HarfOlustur();
            }
            return temp;
        }

        //-------------------------------------------------------
        string BirTane_HarfOlustur()
        {
            int diziBoyut = harfler.Length;
            int rastgeleIndeks = rastgele.Next(diziBoyut);
            return harfler[rastgeleIndeks];
        }
    }
}
