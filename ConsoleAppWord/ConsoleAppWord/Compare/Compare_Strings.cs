using ConsoleAppWord.Entity;
using ConsoleAppWord.Maker;
using System.Collections.Generic;

namespace ConsoleAppWord.Compare
{
    class Compare_Strings
    {
        public static bool GetSame(string word, string s2)
        {
            return StringSort.Get_SortedString(word.ToUpper()) == StringSort.Get_SortedString(s2.ToUpper());
        }
        private static bool GetSame_Lists(string word,LinkedList<string> linkedlist)
        {
            bool temp = false;
            foreach (var item in linkedlist)
            {
                if (GetSame(item, word))
                {
                    temp = true;
                    break;
                }
            }
            return temp;
        }
        public static bool GetSame_NineList(string word)
        {
            return GetSame_Lists(word,AllList.NineList);
        }
        public static bool GetSame_EightList(string word)
        {
            return GetSame_Lists(word, AllList.EightList);
        }
        public static bool GetSame_SevenList(string word)
        {
            return GetSame_Lists(word, AllList.SevenList);
        }
        public static bool GetSame_SixList(string word)
        {
            return GetSame_Lists(word, AllList.SixList);
        }
        public static bool GetSame_FiveList(string word)
        {
            return GetSame_Lists(word, AllList.FiveList);
        }
        public static bool GetSame_FourList(string word)
        {
            return GetSame_Lists(word, AllList.FourList);
        }
        public static bool GetSame_ThreeList(string word)
        {
            return GetSame_Lists(word, AllList.ThreeList);
        }
        public static string GetSameWord(string word)
        {
            var temp = GetSame_NineList(word);
            if (temp)
            {
                return word;
            }
            else
            {
                temp = GetSame_EightList(word);
                if (temp)
                {
                    return word;
                }
                else
                {
                    temp = GetSame_SevenList(word);
                    if (temp)
                    {
                        return word;
                    }
                    else
                    {
                        temp = GetSame_SixList(word);
                        if (temp)
                        {
                            return word;
                        }
                        else
                        {
                            temp = GetSame_FiveList(word);
                            if (temp)
                            {
                                return word;
                            }
                            else
                            {
                                temp = GetSame_FourList(word);
                                if (temp)
                                {
                                    return word;
                                }
                                else
                                {
                                    temp = GetSame_ThreeList(word);
                                    if (temp)
                                    {
                                        return word;
                                    }
                                    else
                                    {
                                        return "";
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
