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
        public static Dictionary<int, LinkedList<string>> listem = new Dictionary<int, LinkedList<string>>();
        //public static LinkedList<string> list = new LinkedList<string>();
        static string  temp = @"C:\Users\Samsung\Documents\GitHub\Homeworks\ConsoleAppWord\ConsoleAppWord\Resources\Words.txt";
        public static void SetDosyaOku()
        {
            string dosyaTamYolu = temp;
            //list.Clear();
            listem.Clear();
            FileStream fs = new FileStream(dosyaTamYolu, FileMode.Open, FileAccess.Read);
            StreamReader sw = new StreamReader(fs);
            string yazi = sw.ReadLine();
            while (yazi != null)
            {
                yazi = sw.ReadLine();
                if (yazi != null && yazi.Length>2 && yazi.Length<10)
                {
                    yazi = yazi.ToUpper();
                    //list.AddLast(yazi);

                    int size = yazi.Length;
                    if (!listem.Keys.Contains(size))
                    {
                        LinkedList<string> linkedList = new LinkedList<string>();
                        linkedList.AddLast(yazi);
                        listem.Add(size, linkedList);
                    }
                    else
                    {
                        (listem[size]).AddFirst(yazi);
                    }

                }
               

            }

            sw.Close();
            fs.Close();

        }

    }
}
