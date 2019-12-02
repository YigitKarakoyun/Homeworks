using System;

namespace ConsoleHelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            //HELLO WORLD YAZDIRIR
            setHelloWorldYazdirC();
            setHelloWorldYazdirHelloWorld();
            //setHelloWorldYazdirHelloWorldVertical();
            Console.Read();
        }
        static void setBoslukBirak(int yukseklik)
        {
            for (int i = 1; i <= yukseklik; i++) { Console.WriteLine(); }
        }
        static void setHelloWorldYazdirC()
        {
            class_Fabric fabric = new class_Fabric();
            for (int i = 3; i < 8; i++)
                fabric.printHorizontal("hello world", i, 'C');
        }
        static void setHelloWorldYazdirHelloWorld()
        {
            class_Fabric fabric = new class_Fabric();
            for (int i = 3; i < 8; i++)
                fabric.printHorizontal_Harfler("hello world", i, "hello world".ToUpper());
        }
        static void setHelloWorldYazdirHelloWorldVertical()
        {
            class_Fabric fabric = new class_Fabric();
            for (int i = 3; i < 8; i++)
                fabric.printVertical_Harfler("hello world", i, "hello world".ToUpper());
        }
    }
}
