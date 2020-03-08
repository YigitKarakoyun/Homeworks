using ConsoleAppWord.Compare;
using ConsoleAppWord.Entity;
using ConsoleAppWord.Maker;
using System;
using System.Collections.Generic;

namespace ConsoleAppWord
{
    class Program
    {
        static void Main(string[] args)
        {
            StringMaker.Set_AllLinkedList();
            StringMaker_WithJoker.Set_AllLinkedList();

           
            Print(AllList.NineList);
            Console.Write("Sekiz: "+AllList.Eight);

            Console.WriteLine();
            var same = Compare_Strings.GetSame(AllList.Five.Last.Value, AllList.Eight);
            Console.WriteLine(same);
          
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
    }
}
