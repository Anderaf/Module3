using System;

namespace Module3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string MyName = "Andrey";

            Console.WriteLine(MyName);

            Console.WriteLine("\t Привет Мир");
            Console.WriteLine("\t Мне 16 лет");
            Console.WriteLine("\t My name is \n {0}", MyName);
            Console.WriteLine("\u0040");
            Console.WriteLine("\x23");

            Console.WriteLine(0x0A);
            Console.WriteLine(0b11);
            Console.WriteLine(5.5);

            Console.WriteLine(0x01);
            Console.WriteLine(0x06);
            Console.WriteLine(0x0F);
            Console.WriteLine(0x10);
            Console.WriteLine(0b1000100111);

            Console.ReadKey();
        }
    }
}
