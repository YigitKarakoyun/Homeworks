using ConsoleAppWord_Entity;
using ConsoleAppWord_Sort;
using System.Collections.Generic;

namespace ConsoleAppWord_Compare
{
    public class Compare_Strings
    {
        public static bool GetSame(string word1, string word2)
        {
            if (word1.Length != word2.Length)
            {
                return false;
            }
            return StringSort.Get_SortedString(word1.ToUpper()) == StringSort.Get_SortedString(word2.ToUpper());
        }
        public static string GetSame_Word(string word, string word_sorted)
        {
            if (GetSame(word, word_sorted))
            {
                return word;
            }
            else
            {
                return "";
            }
        }
        //public static string Get1(LinkedList<string> linkedlist)
        //{
        //    string temp = "";
        //    var words = AllWords.list;

        //    foreach (var item in linkedlist)
        //    {
        //        foreach (var item2 in words)
        //        {
        //            if (GetSame(item, item2))
        //            {
        //                return item2;

        //            }
        //        }

        //    }
        //    return temp;
        //}
        //public static string Get1()
        //{
        //    string temp = "";
        //    var words = AllWords.list;
        //    temp = Get1(AllList.NineList);
        //    if (temp != "")
        //    {
        //        return temp;
        //    }
        //    temp = Get1(AllList.EightList);
        //    if (temp != "")
        //    {
        //        return temp;
        //    }
        //    temp = Get1(AllList.SevenList);
        //    if (temp != "")
        //    {
        //        return temp;
        //    }
        //    temp = Get1(AllList.SixList);
        //    if (temp != "")
        //    {
        //        return temp;
        //    }
        //    temp = Get1(AllList.FiveList);
        //    if (temp != "")
        //    {
        //        return temp;
        //    }
        //    temp = Get1(AllList.FourList);
        //    if (temp != "")
        //    {
        //        return temp;
        //    }
        //    temp = Get1(AllList.ThreeList);
        //    if (temp != "")
        //    {
        //        return temp;
        //    }
        //    return temp;
        //}
        /// <summary>
        /// //
        /// </summary>
        /// <param name="linkedlist"></param>
        /// <returns></returns>
        public static string Get2(LinkedList<string> linkedlist, int count)
        {
            string temp = "";
            Dictionary<int, LinkedList<string>> words = AllWords.listem;

            foreach (var item in linkedlist)
            {
                foreach (var item2 in words[count])
                {
                    if (GetSame(item, item2))
                    {
                        return item2;

                    }
                }

            }


            return temp;
        }
        //public static string Get2()
        //{
        //    string temp = "";
        //    var words = AllWords.list;
        //    temp = Get2(AllList.NineList,9);
        //    if (temp != "")
        //    {
        //        return temp;
        //    }
        //    temp = Get2(AllList.EightList,8);
        //    if (temp != "")
        //    {
        //        return temp;
        //    }
        //    temp = Get2(AllList.SevenList,7);
        //    if (temp != "")
        //    {
        //        return temp;
        //    }
        //    temp = Get2(AllList.SixList,6);
        //    if (temp != "")
        //    {
        //        return temp;
        //    }
        //    temp = Get2(AllList.FiveList,5);
        //    if (temp != "")
        //    {
        //        return temp;
        //    }
        //    temp = Get2(AllList.FourList,4);
        //    if (temp != "")
        //    {
        //        return temp;
        //    }
        //    temp = Get2(AllList.ThreeList,3);
        //    if (temp != "")
        //    {
        //        return temp;
        //    }
        //    return temp;
        //}
    }
}
