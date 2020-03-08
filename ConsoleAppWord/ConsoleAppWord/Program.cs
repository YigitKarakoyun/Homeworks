using ConsoleAppWord.Compare;
using ConsoleAppWord.Entity;
using ConsoleAppWord.Maker;
using ConsoleAppWord.Scores;
using System;
using System.Collections.Generic;


namespace ConsoleAppWord
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
            Console.Read();
        }
        static void Print(LinkedList<string> linkedList)
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

                PrintCounts();
                Console.Write("Aranacak Kelime Giriniz: ");
                var readme = Console.ReadLine().ToUpper();
                
                var temp = Compare_Strings.GetSameWord(readme);
                Console.WriteLine("Bulunan Kelime: "+temp);
                Console.WriteLine("Skor: "+Score.Get_Score(temp));


                // Key is available - read it
                key = Console.ReadKey(true).Key;

                //if (key == ConsoleKey.NumPad1)
                //{
                //    Console.WriteLine(ConsoleKey.NumPad1.ToString());
                //}
                //else if (key == ConsoleKey.NumPad2)
                //{
                //    Console.WriteLine(ConsoleKey.NumPad1.ToString());
                //}

            } while (key != ConsoleKey.Escape);
        }
    }
}
