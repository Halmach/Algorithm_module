using System;

namespace Algorithm_module
{
    class Program
    {
        static void Main(string[] args)
        {
            Greetings();
        }

        static void Greetings()
        {
            Console.WriteLine("Как Вас зовут?");
            var name = Console.ReadLine();
            var greetings = "Привет," + name;
            Console.WriteLine(greetings);
        }
    }
}
