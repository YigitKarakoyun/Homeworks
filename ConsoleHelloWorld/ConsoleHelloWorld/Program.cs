using System;

namespace ConsoleHelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            //HELLO WORLD YAZDIRIR
            setHelloWorldYazdir();

            Console.Read();
        }
        static void setBoslukBirak(int yukseklik)
        {
            for (int i = 1; i <= yukseklik; i++) { Console.WriteLine(); }
        }
        static void setHelloWorldYazdir()
        {
            class_Fabric fabric = new class_Fabric();
            for (int i = 3; i < 8; i++)
                fabric.printHorizontal("hello world", i);
        }
        
        
    }
}
