using System;

namespace Algorithm_module
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // Greetings();
            //  ReadArray();
            CheckAge();
        }

        private static void Greetings() // линейный алгоритм
        {
            Console.WriteLine("Как Вас зовут?");
            var name = Console.ReadLine();
            var greetings = "Привет," + name;
            Console.WriteLine(greetings);
        }

        private static void ReadArray() // циклический алгоритм
        {
            Console.WriteLine("Сколько элементов будет в массиве?");
            int count = 0;
            string[] array;
            try
            {
                int.TryParse(Console.ReadLine(), out count);
                array = new string[count];
                for (int i = 0; i < array.Length; i++)
                {
                    Console.WriteLine($"Заполнить {i} элемент массива");
                    array[i] = Console.ReadLine(); 
                }

                Console.WriteLine("Все элементы записаны");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }         
        } 

        private static void CheckAge()
        {
            Console.WriteLine("Введите свой возраст");
            var age = int.Parse(Console.ReadLine());
            if (age > 13)
            {
                Console.WriteLine("Вы успешно зарегистрированы");
            }
            else
            {
                Console.WriteLine("Пользователи младше 14 лет не могут быть зарегистрированы");
            }
        }
    }
}
