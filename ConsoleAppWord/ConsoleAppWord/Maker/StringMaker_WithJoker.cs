using ConsoleAppWord.Entity;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleAppWord.Maker
{
    class StringMaker_WithJoker
    {

        private static void Set_LinkedList(LinkedList<string> temp, LinkedList<string> tempLess)
        {
            temp.Clear();
            foreach (string item in Letters.Letter)
            {
                foreach (var item2 in tempLess)
                {
                    string yeniString = StringSort.Get_SortedString(item + item2);
                    if (!temp.Contains(yeniString))
                    {
                        temp.AddLast(yeniString);
                    }
                }
            }
            
        }
        public static void Set_AllLinkedList()
        {
            Set_NineList();
            Set_EightList();
            Set_SevenList();
            Set_SixList();
            Set_FiveList();
            Set_FourList();
            Set_ThreeList();
        }
             
        public static void Set_NineList()
        {
            var temp = AllList.NineList;
            temp.Clear();
            foreach (string item in Letters.Letter)
            {
                string yeniString = StringSort.Get_SortedString(item + AllList.Eight);
                if (!temp.Contains(yeniString))
                {
                    temp.AddLast(yeniString);
                }

            }
        }

        public static void Set_EightList()
        {
            Set_LinkedList(AllList.EightList,AllList.Seven);
        }
        public static void Set_SevenList()
        {
            Set_LinkedList(AllList.SevenList, AllList.Six);
        }
        public static void Set_SixList()
        {
            Set_LinkedList(AllList.SixList, AllList.Five);
        }
        public static void Set_FiveList()
        {
            Set_LinkedList(AllList.FiveList, AllList.Four);
        }
        public static void Set_FourList()
        {
            Set_LinkedList(AllList.FourList, AllList.Three);
        }
        public static void Set_ThreeList()
        {
            Set_LinkedList(AllList.ThreeList, AllList.Two);
        }
    }
}
