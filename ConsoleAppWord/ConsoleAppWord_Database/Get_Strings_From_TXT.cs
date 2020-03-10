using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ConsoleAppWord_Database
{
    public class Get_Strings_From_TXT
    {  
        public static Dictionary<int, LinkedList<string>> Get_DictionaryStrings()
        {
            string temp = @"C:\Users\Samsung\Documents\GitHub\Homeworks\ConsoleAppWord\ConsoleAppWord\Resources\Words.txt";
            return Get_DictionaryStrings(temp);
        }
        public static Dictionary<int, LinkedList<string>> Get_DictionaryStrings(string path)
        {
            var mylist = new Dictionary<int, LinkedList<string>>();

            string filePath = path;

            mylist.Clear();
            FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read);
            StreamReader sw = new StreamReader(fs);
            string str = sw.ReadLine();
            while (str != null)
            {
                str = sw.ReadLine();
                if (str != null && str.Length > 2 && str.Length < 10)
                {
                    str = str.ToUpper();

                    int size = str.Length;
                    if (!mylist.Keys.Contains(size))
                    {
                        LinkedList<string> linkedList = new LinkedList<string>();
                        linkedList.AddLast(str);
                        mylist.Add(size, linkedList);
                    }
                    else
                    {
                        (mylist[size]).AddFirst(str);
                    }
                }
            }

            sw.Close();
            fs.Close();

            return mylist;

        }
        public static LinkedList<string> Get_LinkedList_Strings(string path)
        {
            var mylist = new LinkedList<string>();

            string filePath = path;

            mylist.Clear();
            FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read);
            StreamReader sw = new StreamReader(fs);
            string str = sw.ReadLine();
            while (str != null)
            {
                str = sw.ReadLine();
                if (str!=null)
                {
                    str = str.ToUpper().Trim();
                }
                if (str != null && str.Length > 2 && str.Length < 10)
                {
                    int size = str.Length;
                    if (!mylist.Contains(str))
                    {
                        mylist.AddLast(str);
                    }
                }
            }

            sw.Close();
            fs.Close();

            return mylist;

        }
        public static LinkedList<string> Get_LinkedList_Strings()
        {
            string filePath = @"C:\Users\Samsung\Desktop\WordSolution\ConsoleAppWord_Database\Resources\Words.txt";
            return Get_LinkedList_Strings(filePath);

        }
    }
}
