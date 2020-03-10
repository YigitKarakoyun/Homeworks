using System.Collections.Generic;

namespace ConsoleAppWord_Entity
{
    public class AllList
    {
        public static string Eight { get; set; } = "";
        public static LinkedList<string> Seven { get; set; } = new LinkedList<string>();
        public static LinkedList<string> Six { get; set; } = new LinkedList<string>();
        public static LinkedList<string> Five { get; set; } = new LinkedList<string>();
        public static LinkedList<string> Four { get; set; } = new LinkedList<string>();
        public static LinkedList<string> Three { get; set; } = new LinkedList<string>();
        public static LinkedList<string> Two { get; set; } = new LinkedList<string>();

        public static LinkedList<string> NineList { get; set; } = new LinkedList<string>();
        public static LinkedList<string> EightList { get; set; } = new LinkedList<string>();
        public static LinkedList<string> SevenList { get; set; } = new LinkedList<string>();
        public static LinkedList<string> SixList { get; set; } = new LinkedList<string>();
        public static LinkedList<string> FiveList { get; set; } = new LinkedList<string>();
        public static LinkedList<string> FourList { get; set; } = new LinkedList<string>();
        public static LinkedList<string> ThreeList { get; set; } = new LinkedList<string>();

        public static LinkedList<string>[] NumberList { get; private set; } = { NineList, EightList ,SevenList, SixList,FiveList,FourList,ThreeList}; 
    }
}
