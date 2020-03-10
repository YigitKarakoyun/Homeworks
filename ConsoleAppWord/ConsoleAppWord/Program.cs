using ConsoleAppWord_Compare;
using ConsoleAppWord_Entity;
using ConsoleAppWord_Maker;
using System;
using System.Collections.Generic;
namespace ConsoleAppWord
{
    class Program
    {
        static void Main(string[] args)
        {
            AllWords.SetDosyaOku();
            Menu();
            Console.Read();
        }

        #region PRINT
        static void Print(ICollection<string> linkedList)
        {
            foreach (var item in linkedList)
            {
                Console.WriteLine(item);
            }
        }
        static void Print(string eight)
        {
            Console.WriteLine(eight);

        }
        static void Print(char[] linkedList)
        {
            Console.WriteLine();
            foreach (var item in linkedList)
            {
                Console.Write(item.ToString());
            }
        }
        static void Print(int[] linkedList)
        {
            Console.WriteLine();
            foreach (var item in linkedList)
            {
                Console.Write(item.ToString());
            }
        }
        static void Print()
        {
            Console.WriteLine("------------------------------------");
        }
        static void PrintSteps()
        {
            Print("9 Basamaklı: " + AllList.NineList.Count);
            Print(AllList.NineList);

            Print();
            Print("8 Basamaklı: " + AllList.EightList.Count);
            Print(AllList.EightList);

            Print();
            Print("7 Basamaklı: " + AllList.SevenList.Count);
            Print(AllList.SevenList);

            Print();
            Print("6 Basamaklı: " + AllList.SixList.Count);
            Print(AllList.SixList);

            Print();
            Print("5 Basamaklı: " + AllList.FiveList.Count);
            Print(AllList.FiveList);

            Print();
            Print("4 Basamaklı: " + AllList.FourList.Count);
            Print(AllList.FourList);

            Print();
            Print("3 Basamaklı: " + AllList.ThreeList.Count);
            Print(AllList.ThreeList);


        }
        static void PrintCounts()
        {
            Console.WriteLine("9 Adeti: " + AllList.NineList.Count);
            Console.WriteLine("8 Adeti: " + AllList.EightList.Count);
            Console.WriteLine("7 Adeti: " + AllList.SevenList.Count);
            Console.WriteLine("6 Adeti: " + AllList.SixList.Count);
            Console.WriteLine("5 Adeti: " + AllList.FiveList.Count);
            Console.WriteLine("4 Adeti: " + AllList.FourList.Count);
            Console.WriteLine("3 Adeti: " + AllList.ThreeList.Count);
        }
        #endregion

        static void Menu()
        {
            ConsoleKey key;
            do
            {
                Print();
                StringMaker.Set_AllLinkedList();
                StringMaker_WithJoker.Set_AllLinkedList();

                Console.WriteLine("---Sekiz Basamaklı---");
                Console.WriteLine("Değer: " + AllList.Eight);

                //PrintCounts();
                //Console.Write("Aranacak Kelime Giriniz: ");
                //var readme = Console.ReadLine().ToUpper();

                //var temp = Compare_Strings.GetSameWord(readme);
                //Console.WriteLine("Bulunan Kelime: "+temp);
                //Console.WriteLine("Skor: "+Score.Get_Score(temp));


                //var result = (from str1 in AllWords.list
                //              from str2 in AllList.ThreeList
                //              where Compare_Strings.GetSame(str1, str2)
                //              select str1).SingleOrDefault();
                bool result = false;
                var same = Compare_Strings.Get2();
                if (same == "")
                {
                    Console.WriteLine("9 NULL");
                }
                else
                {
                    Console.WriteLine(same);
                    result = true;

                }
                if (!result)
                {
                    same = Compare_Strings.Get2(AllList.EightList,8);
                    if (same == "")
                    {
                        Console.WriteLine("8 NULL");
                    }
                    else
                    {
                        Console.WriteLine(same);
                        result = true;
                    }
                }
                if (!result)
                {
                    same = Compare_Strings.Get2(AllList.SevenList,7);
                    if (same == "")
                    {
                        Console.WriteLine("7 NULL");
                    }
                    else
                    {
                        Console.WriteLine(same);
                        result = true;
                    }
                }

                if (!result)
                {
                    same = Compare_Strings.Get2(AllList.SixList,6);
                    if (same == "")
                    {
                        Console.WriteLine("6 NULL");
                    }
                    else
                    {
                        Console.WriteLine(same);
                        result = true;
                    }
                }
                if (!result)
                {
                    same = Compare_Strings.Get2(AllList.FiveList,5);
                    if (same == "")
                    {
                        Console.WriteLine("5 NULL");
                    }
                    else
                    {
                        Console.WriteLine(same);
                        result = true;
                    }
                }
                if (!result)
                {

                    same = Compare_Strings.Get2(AllList.FourList,4);
                    if (same == "")
                    {
                        Console.WriteLine("4 NULL");
                    }
                    else
                    {
                        Console.WriteLine(same);
                        result = true;
                    }
                }
                if (!result)
                {
                    same = Compare_Strings.Get2(AllList.ThreeList,3);
                    if (same == "")
                    {
                        Console.WriteLine("3 NULL");
                    }
                    else
                    {
                        Console.WriteLine(same);
                        result = true;
                    }
                }
                //bool result = false;
                //var same = Compare_Strings.Get2(AllList.NineList,9);
                //if (same == "")
                //{
                //    Console.WriteLine("9 NULL");
                //}
                //else
                //{
                //    Console.WriteLine(same);
                //    result = true;

                //}
                //if (!result)
                //{
                //    same = Compare_Strings.Get2(AllList.EightList,8);
                //    if (same == "")
                //    {
                //        Console.WriteLine("8 NULL");
                //    }
                //    else
                //    {
                //        Console.WriteLine(same);
                //        result = true;
                //    }
                //}
                //if (!result)
                //{
                //    same = Compare_Strings.Get2(AllList.SevenList,7);
                //    if (same == "")
                //    {
                //        Console.WriteLine("7 NULL");
                //    }
                //    else
                //    {
                //        Console.WriteLine(same);
                //        result = true;
                //    }
                //}

                //if (!result)
                //{
                //    same = Compare_Strings.Get2(AllList.SixList,6);
                //    if (same == "")
                //    {
                //        Console.WriteLine("6 NULL");
                //    }
                //    else
                //    {
                //        Console.WriteLine(same);
                //        result = true;
                //    }
                //}
                //if (!result)
                //{
                //    same = Compare_Strings.Get2(AllList.FiveList,5);
                //    if (same == "")
                //    {
                //        Console.WriteLine("5 NULL");
                //    }
                //    else
                //    {
                //        Console.WriteLine(same);
                //        result = true;
                //    }
                //}
                //if (!result)
                //{

                //    same = Compare_Strings.Get2(AllList.FourList,4);
                //    if (same == "")
                //    {
                //        Console.WriteLine("4 NULL");
                //    }
                //    else
                //    {
                //        Console.WriteLine(same);
                //        result = true;
                //    }
                //}
                //if (!result)
                //{
                //    same = Compare_Strings.Get2(AllList.ThreeList,3);
                //    if (same == "")
                //    {
                //        Console.WriteLine("3 NULL");
                //    }
                //    else
                //    {
                //        Console.WriteLine(same);
                //        result = true;
                //    }
                //}
               var score = ConsoleAppWord_Score.Score.Get_Score(same);
                Console.WriteLine(score+" Puan");

                // Key is available - read it
                key = Console.ReadKey(true).Key;
            } while (key != ConsoleKey.Escape);
        }
    }
}
