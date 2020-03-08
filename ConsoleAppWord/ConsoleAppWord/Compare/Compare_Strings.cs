using ConsoleAppWord.Maker;

namespace ConsoleAppWord.Compare
{
    class Compare_Strings
    {
        public static bool GetSame(string s1, string s2)
        {
            return StringSort.Get_SortedString(s1)== StringSort.Get_SortedString(s2); ;
        }
    }
}
