using System;
using System.Threading;

namespace Algorithm_module
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // Greetings();
            //  ReadArray();
            //CheckAge();
            var rnd = new Random();

            int[] mas = new int[10000];
            int[] mas2 = new int[mas.Length];
            for (int i = 0; i < mas.Length; i++)
            {
                mas[i] = rnd.Next(-90000, 1230000);
            }

            for (int i = 0; i < mas.Length; i++)
            {
                mas2[i] = mas[i];
            }

            BubbleSort(mas2);
            Array.Reverse(mas2);
            //Console.WriteLine(mas);
            for (int i = 0; i < mas.Length; i++)
            {
                if(BinarySearch(ref mas2, mas[i]) == -1) Console.WriteLine(i);
            }
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

        private static int BinarySearch(ref int[] mas, int requiredElement)
        {
            int left = 0;
            int right = mas.Length;

            for (int i = left; i <= right; i++)
            {
                var middle = (right + left) / 2 + 1;
                if (mas[middle] == requiredElement)
                {
            //        Console.WriteLine("Найденое значение = " + mas[middle]);
                    return middle;
                }

                if (middle == 1)
                {
                    if(mas[middle - 1] == requiredElement)
                    {
             //           Console.WriteLine("Найденое значение = " + mas[middle - 1]);
                        return middle - 1;
                    }
                }

                if (mas[middle] < requiredElement)
                {
                    i = left;
                    right = middle - 1;
                }

                if (mas[middle] > requiredElement)
                {
                    left = middle - 1;
                }
            }

            return -1;
        }

        private static void Swap(ref int e1, ref int e2)
        {
            var temp = e1;
            e1 = e2;
            e2 = temp;
        }

        private static int[] BubbleSort(int[] array)
        {
            var len = array.Length;
            for (var i = 1; i < len; i++)
            {
                for (var j = 0; j < len - i; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        Swap(ref array[j], ref array[j + 1]);
                    }
                }
            }

            return array;
        }
    }
}
