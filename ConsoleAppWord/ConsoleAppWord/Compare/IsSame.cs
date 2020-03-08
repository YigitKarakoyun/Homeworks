using ConsoleAppWord.Maker;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppWord.Compare
{
    class IsSame
    {
        public static bool GetSame(string word, string s2)
        {
            return StringSort.Get_SortedString(word.ToUpper()) == StringSort.Get_SortedString(s2.ToUpper());
        }
    }
}
