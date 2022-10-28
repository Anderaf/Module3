using System;

namespace Module3
{
    internal class Program
    {
        enum Months{
            January,
            February,
            March,
            April,
            May,
            June,
            July,
            August,
            September,
            October,
            November,
            December
        }
        enum Semaphore
        {
            Red = 100,
            Yellow = 200,
            Green = 300
        }
        static void Main(string[] args)
        {
            /*const string MyName = "Andrey";

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

            Console.ReadKey();*/

            /*Console.WriteLine("Today is {0}", Months.October);*/

            string MyName = "Computer";
            Console.WriteLine("Привет, человек");
            Console.WriteLine("Меня зовут {0}", MyName);
            Console.Write("А как тебя зовут? ");
            string YourName = Console.ReadLine();
            Console.Write($"Рад встрече, {YourName} ");

            Console.ReadKey();
        }
    }
}
