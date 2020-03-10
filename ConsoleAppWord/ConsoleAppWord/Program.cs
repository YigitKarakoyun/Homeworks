using ConsoleAppWord_Compare;
using ConsoleAppWord_Database;
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
            //Print();
            StringMaker.Set_AllLinkedList();
            StringMaker_WithJoker.Set_AllLinkedList();

            Console.WriteLine("---Sekiz Basamaklı---");
            Console.WriteLine("Değer: " + AllList.Eight);

            //İnsert DB
            //Tools.Insert_Db_From_TXT();
            //---------------------------------------------------
            //TBL_WORDS word = Tools.Get_Word(tools, "ZÜRRİYET");
            //if (word!=null)
            //{
            //    Console.WriteLine(word.WORD+"\n"+word+"\n"+word.ID);
            //}
            //---------------------------------------------------
            var tools = Tools.Get_Words();
            var temp = AllList.FourList;
            foreach (var item in temp)
            {
                TBL_WORDS word = Tools.Get_Word(tools, item);
                if (word != null)
                {
                    Console.WriteLine(word.WORD + "\t" + word + "\t" + word.ID);
                }
            }
            Console.WriteLine("Arama Bitti");

            Console.Read();
        }

        //#region PRINT
        //static void Print(ICollection<string> linkedList)
        //{
        //    foreach (var item in linkedList)
        //    {
        //        Console.WriteLine(item);
        //    }
        //}
        //static void Print(string eight)
        //{
        //    Console.WriteLine(eight);

        //}
        //static void Print(char[] linkedList)
        //{
        //    Console.WriteLine();
        //    foreach (var item in linkedList)
        //    {
        //        Console.Write(item.ToString());
        //    }
        //}
        //static void Print(int[] linkedList)
        //{
        //    Console.WriteLine();
        //    foreach (var item in linkedList)
        //    {
        //        Console.Write(item.ToString());
        //    }
        //}
        //static void Print()
        //{
        //    Console.WriteLine("------------------------------------");
        //}
        //static void PrintSteps()
        //{
        //    Print("9 Basamaklı: " + AllList.NineList.Count);
        //    Print(AllList.NineList);

        //    Print();
        //    Print("8 Basamaklı: " + AllList.EightList.Count);
        //    Print(AllList.EightList);

        //    Print();
        //    Print("7 Basamaklı: " + AllList.SevenList.Count);
        //    Print(AllList.SevenList);

        //    Print();
        //    Print("6 Basamaklı: " + AllList.SixList.Count);
        //    Print(AllList.SixList);

        //    Print();
        //    Print("5 Basamaklı: " + AllList.FiveList.Count);
        //    Print(AllList.FiveList);

        //    Print();
        //    Print("4 Basamaklı: " + AllList.FourList.Count);
        //    Print(AllList.FourList);

        //    Print();
        //    Print("3 Basamaklı: " + AllList.ThreeList.Count);
        //    Print(AllList.ThreeList);


        //}
        //static void PrintCounts()
        //{
        //    Console.WriteLine("9 Adeti: " + AllList.NineList.Count);
        //    Console.WriteLine("8 Adeti: " + AllList.EightList.Count);
        //    Console.WriteLine("7 Adeti: " + AllList.SevenList.Count);
        //    Console.WriteLine("6 Adeti: " + AllList.SixList.Count);
        //    Console.WriteLine("5 Adeti: " + AllList.FiveList.Count);
        //    Console.WriteLine("4 Adeti: " + AllList.FourList.Count);
        //    Console.WriteLine("3 Adeti: " + AllList.ThreeList.Count);
        //}
        //#endregion

        //static void Menu()
        //{
        //    //ConsoleKey key;
        //    //do
        //    //{
        //    //    Print();
        //    //    StringMaker.Set_AllLinkedList();
        //    //    StringMaker_WithJoker.Set_AllLinkedList();

        //    //    Console.WriteLine("---Sekiz Basamaklı---");
        //    //    Console.WriteLine("Değer: " + AllList.Eight);

        //    //    List<TBL_WORDS> tools = Tools.Get_Words();
        //    //    Console.WriteLine(tools.Count);
        //    //    foreach (var item in tools)
        //    //    {
        //    //        Console.WriteLine(item);
        //    //    }


        //    //    // Key is available - read it
        //    //    key = Console.ReadKey(true).Key;
        //    //} while (key != ConsoleKey.Escape);

            

        //    //Console.WriteLine(tools.Count);
        //    //foreach (var item in tools)
        //    //{
        //    //    Console.WriteLine(item);
        //    //}
        //}
    }
}
