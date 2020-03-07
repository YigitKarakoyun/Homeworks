using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleWordMatch
{
    class Permutasyon_Yapici
    {
        int adet = 0;
        public List<string> list = new List<string>();
        public void Permutasyon_Stringi(string str)
        {
            list.Clear();
            char[] metin = str.ToCharArray();
            Permutasyon(metin, 0, metin.Length - 1);
        }
        
        void Degistir(ref char a, ref char b)
        {
            if (a == b) return;
            char c = a;
            a = b;
            b = c;
        }
        
        void Permutasyon(char[] dizi, int sol, int sag)
        {
            if (sol == sag)
            {
                adet++;
                //Console.WriteLine(dizi);
                string temp = "";
                foreach (char item in dizi)
                {
                    temp += item.ToString();
                }
                list.Add(temp);
            }
            else
                for (int i = sol; i <= sag; i++)
                {
                    Degistir(ref dizi[sol], ref dizi[i]);
                    Permutasyon(dizi, sol + 1, sag);
                    Degistir(ref dizi[sol], ref dizi[i]);
                }
        }

       
    }
}
