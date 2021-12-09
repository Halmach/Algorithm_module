using System;

namespace Algorithm_module
{
    class Program
    {
        static void Main(string[] args)
        {
            Greetings();
            ReadArray();
        }

        static void Greetings()
        {
            Console.WriteLine("Как Вас зовут?");
            var name = Console.ReadLine();
            var greetings = "Привет," + name;
            Console.WriteLine(greetings);
        }

        static void ReadArray()
        {
            Console.WriteLine("Сколько элементов будет в массиве?");
            int count = 0;
            string[] array;
            try
            {
                int.TryParse(Console.ReadLine(), out count);
                array = new string[count];
                for(int i = 0; i < array.Length; i++)
                {
                    Console.WriteLine($"Заполнить {i} элемент массива");
                    array[i] = Console.ReadLine(); 
                }
                Console.WriteLine("Все элементы записаны");
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }         
        }
    }
}
