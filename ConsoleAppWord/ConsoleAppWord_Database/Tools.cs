using ConsoleAppWord_Sort;
using System;
using System.Collections.Generic;
using System.Linq;
namespace ConsoleAppWord_Database
{
    public class Tools
    {
        public static DbWordsEntities db = new DbWordsEntities();
        public static void  Insert_Db_From_TXT()
        {
            var temp = Get_Strings_From_TXT.Get_LinkedList_Strings();
            foreach (var item in temp)
            {
                Add_Word(item);
            }
        }
        public static void Add_Word(string str)
        {
            TBL_WORDS temp = new TBL_WORDS();
       
            temp.WORD = str;
            temp.WORD_LENGTH = str.Length;
            db.TBL_WORDS.Add(temp);
            db.SaveChanges();
        }
        public static TBL_WORDS[] Get_Words()
        {
            var result = from s in db.TBL_WORDS
                         orderby s.WORD_LENGTH descending
                         select s;

            return result.ToArray();
        }
        
        public static TBL_WORDS Get_Word(TBL_WORDS[] list, string word)
        {
            word = word.ToUpper();
            var result = (from s in list
                          where word.Length == s.WORD_LENGTH &&
                          s.ToString() == StringSort.Get_SortedString(word)
                          select s).FirstOrDefault();
            return result;
        }
        //public static TBL_WORDS Get_Word(TBL_WORDS[] list, string word)
        //{
        //    word = word.ToUpper();
        //    var result = (from s in list
        //                  where word.Length == s.WORD_LENGTH &&
        //                  s.ToString() == StringSort.Get_SortedString(word)
        //                  select s).FirstOrDefault();
        //    return result;
        //}
    }
}
