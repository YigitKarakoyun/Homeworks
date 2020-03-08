using System;

namespace ConsoleAppWord.Maker
{
    class StringSort
    {
        public static string Get_SortedString(string str)
        {
            var car = str.ToCharArray();
            Array.Sort(car);
            return new string(car);
        }
    }
}
