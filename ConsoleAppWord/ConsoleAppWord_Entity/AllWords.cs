using ConsoleAppWord_Sort;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;

namespace ConsoleAppWord_Entity
{
    public class AllWords
    {
        public static LinkedList<string> list = new LinkedList<string>();
        static string  temp = @"C:\Users\Samsung\Documents\GitHub\Homeworks\ConsoleAppWord\ConsoleAppWord\Resources\Words.txt";
        public static void SetDosyaOku()
        {
            string dosyaTamYolu = temp;
            list.Clear();
            FileStream fs = new FileStream(dosyaTamYolu, FileMode.Open, FileAccess.Read);
            StreamReader sw = new StreamReader(fs);
            string yazi = sw.ReadLine();
            while (yazi != null)
            {
                yazi = sw.ReadLine();
                if (yazi != null && yazi.Length>2 && yazi.Length<10)
                {
                    yazi = yazi.ToUpper();
                    list.AddLast(yazi);

                    
                }
               

            }

            sw.Close();
            fs.Close();

        }

    }
}
