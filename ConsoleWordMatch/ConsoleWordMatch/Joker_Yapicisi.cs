using System;
using System.Collections.Generic;

namespace ConsoleWordMatch
{

   public class Joker_Yapicisi
    {
        string[] harfler = Alfabe.harfler_dizisi;

        //------------------------------------------------------
        public List<string> Jokerli_AnlamsizKelimeOlustur(string tempSekiz)
        {
            List<string> temp = new List<string>();
            foreach (string item in harfler)
            {
                string yeniString =  SiraliKelime(item + tempSekiz);
                if (!temp.Contains(yeniString))
                {
                    temp.Add(yeniString);
                }
                
            }
            return temp;
        }
        public List<string> Jokerli_AnlamsizKelimeOlustur(List<string> tempList)
        {
            List<string> temp = new List<string>();
            foreach (string item in harfler)
            {
                foreach (var itemMetin in tempList)
                {
                    string yeniString = SiraliKelime(item + itemMetin);
                    if (!temp.Contains(yeniString))
                    {
                        temp.Add(yeniString);
                    }
                    
                }

            }

            return temp;
        }
        private string SiraliKelime(string itemMetin)
        {
            List<string> sirali = new List<string>();
            foreach (var item in itemMetin)
            {
                sirali.Add(item.ToString());
            }
            sirali.Sort();
            var temp = "";
            foreach (var item in sirali)
            {
                temp += item;
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
