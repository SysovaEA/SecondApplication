using System;

namespace SecondApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name: ");
            var name = Console.ReadLine();
            Console.Write("Enter your age: ");
            var age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your name is {0} and age is {1}", name, age);
            Console.Write("Enter your bithday: ");
            var birthday = Console.ReadLine();
            Console.WriteLine("Your birthday is {0}", birthday);
         }
    }
    enum DayOfWeek : byte
    {
        Monday = 1,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }

}
