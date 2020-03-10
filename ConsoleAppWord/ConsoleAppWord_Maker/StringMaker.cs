using ConsoleAppWord_Entity;
using ConsoleAppWord_Sort;
using System;
using System.Collections.Generic;

namespace ConsoleAppWord_Maker
{
    public class StringMaker
    {
        static Random rand = new Random();
        //----------------------------------------------
        private static string GetString_One()
        {
            int rnd = rand.Next(Letters.LetterCount);
            return Letters.Get_Letter(rnd);
        }
        //----------------------------------------------
        public static void Set_String_Eight()
        {
            string temp = "";
            for (int i = 0; i < 8; i++)
            {
                temp += GetString_One();
            }
            
            AllList.Eight = StringSort.Get_SortedString(temp); ;
        }
        //-------------------------------------------------------------
        private static LinkedList<string> Get_LinkedList(string str)
        {
            LinkedList<string> temp = new LinkedList<string>();
            for (int i = 0; i < str.Length; i++)
            {
                string tempString = "";

                for (int j = 0; j < str.Length; j++)
                {
                    if (i != j)
                    {
                        tempString += str[j].ToString();
                    }
                }
                tempString = StringSort.Get_SortedString(tempString);
                if (!temp.Contains(tempString))
                {
                    temp.AddLast(tempString);
                }


            }
            return temp;
        }
        
        //Linked Listleri Doldurma
        private static void Set_LinkedLists(LinkedList<string> tempList, LinkedList<string> temp)
        {
            temp.Clear();
            foreach (var item in tempList)
            {
                var list = Get_LinkedList(item);
                foreach (var listItem in list)
                {
                    if (!temp.Contains(listItem))
                    {
                        temp.AddLast(listItem);
                    }

                }
            }
        }

        //7li linkedlist OLUŞTURUR
        public static void Set_SevenLinkedList()
        {
            string tempEight = AllList.Eight;
            LinkedList<string> temp = AllList.Seven;
            temp.Clear();

            for (int i = 0; i < tempEight.Length; i++)
            {
                string tempString = "";

                for (int j = 0; j < tempEight.Length; j++)
                {
                    if (i != j)
                    {
                        tempString += tempEight[j].ToString();
                    }
                }

                if (!temp.Contains(tempString))
                {
                    temp.AddLast(tempString);
                }


            }

        }

        //6li linkedlist OLUŞTURUR
        public static void Set_SixLinkedList()
        {
            Set_LinkedLists(AllList.Seven, AllList.Six);
        }

        //5li linkedlist OLUŞTURUR
        public static void Set_FiveLinkedList()
        {
            Set_LinkedLists(AllList.Six, AllList.Five);
        }

        //4li linkedlist OLUŞTURUR
        public static void Set_FourLinkedList()
        {
            Set_LinkedLists(AllList.Five, AllList.Four);
        }
        //3li linkedlist OLUŞTURUR
        public static void Set_ThreeLinkedList()
        {
            Set_LinkedLists(AllList.Four, AllList.Three);
        }
        //2li linkedlist OLUŞTURUR
        public static void Set_TwoLinkedList()
        {
            Set_LinkedLists(AllList.Three, AllList.Two);
        }
        public static void Set_AllLinkedList()
        {
            Set_String_Eight();
            Set_SevenLinkedList();
            Set_SixLinkedList();
            Set_FiveLinkedList();
            Set_FourLinkedList();
            Set_ThreeLinkedList();
            Set_TwoLinkedList();
        }
        //----------------------------------------------

        //----------------------------------------------
    }
}
