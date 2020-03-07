using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleWordMatch
{
    class SekizdenKucuk_Basamak_Yapicisi
    {
        public List<string> YediAltiBesDortUcListesi(string tempSekiz)
        {
            List<string> temp = new List<string>();
            for (int i = 0; i < tempSekiz.Length; i++)
            {
                string tempString = "";

                for (int j = 0; j < tempSekiz.Length; j++)
                {
                    if (i != j)
                    {
                        tempString += tempSekiz[j].ToString();
                    }
                }
                
                if (!temp.Contains(tempString))
                {
                    temp.Add(tempString);
                }
                

            }
            return temp;
        }
        public List<string> YediAltiBesDortUcListesi(List<string> tempListesi)
        {
            List<string> temp = new List<string>();
            foreach (string item in tempListesi)
            {
                List<string> tempSekiz = YediAltiBesDortUcListesi(item);
                foreach (var itemSekiz in tempSekiz)
                {
                    if (!temp.Contains(itemSekiz))
                    {
                        temp.Add(itemSekiz);
                    }
             
                }
            }
            return temp;
        }
        public void Yazdir(List<string> harflerList)
        {
            Console.WriteLine("---Harfler---");
            foreach (var item in harflerList)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            Console.WriteLine();


        }

    }
}
