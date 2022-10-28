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

            /*string MyName = "Computer";
            Console.WriteLine("Привет, человек");
            Console.WriteLine("Меня зовут {0}", MyName);
            Console.Write("А как тебя зовут? ");
            string YourName = Console.ReadLine();
            Console.Write($"Рад встрече, {YourName} ");

            Console.ReadKey();*/

            /*int a = 5;
            var result = ++a % 2;
            Console.WriteLine("{0} % 2 = {1}", a, result);
            a *= 2;
            Console.WriteLine(a);*/

            /*Console.Write("Enter your age: ");
            int age;
            bool iscorrect = int.TryParse(Console.ReadLine(), out age);
            Console.WriteLine("Your age is {0} ", age);
            Console.ReadKey();*/

            /*Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Console.Write("Enter your age: ");
            byte age = checked((byte)int.Parse(Console.ReadLine()));
            Console.WriteLine("Your name is {0} and age is {1} ", name, age);
            Console.Write("What is your favorite day of week? ");
            DayOfWeek dayOfWeek = (DayOfWeek)int.Parse(Console.ReadLine());
            Console.WriteLine("Your favorite day of week is " + dayOfWeek);
            Console.ReadKey();*/

            Console.Write("Как вас зовут? ");
            var name = Console.ReadLine();
            Console.Write("Сколько вам лет? ");
            var age = checked((byte)int.Parse(Console.ReadLine()));
            Console.Write("Напишите свою дату рождения: ");
            var date = Console.ReadLine();
            Console.WriteLine("Вы {0}, вам {1}, вы родились в {2}", name, age, date);
            Console.ReadKey();
        }
    }
}
