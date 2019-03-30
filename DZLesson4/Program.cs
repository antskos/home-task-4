using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace DZLesson4
{
    class Program
    {
        public static int[] Create1DArray(int n)
        {
            //Создание объекта для генерации чисел
            Random rnd = new Random();

            // объявление одномерного массива размерностью n
            int[] arr = new int[n];

            // инициализация эл-тов массива случайными числами от -10000 до 10000
            for (int i = 0; i < n; i++)
                arr[i] = rnd.Next(-10000, 10001);
            return arr;
        }

        public static int NumberOfPairs(int[] arr)
        {
            int counter = 0;    // счётчик пар

            for (int i = 0; i < arr.Length - 1; i++)
            {
                if ((arr[i] % 3 == 0) ^ (arr[i + 1] % 3 == 0))
                    counter++;
            }

            return counter;
        }

        static void Main(string[] args)
        {
            int[] arr = Create1DArray(6);

            Console.WriteLine("Наш псевдослучайный массив: ");
            for (int i = 0; i < arr.Length; i++)
            {
                //Вывод полученного массива в консоль
                Console.Write($"{arr[i]} ");
            }
            Console.WriteLine();
            Console.WriteLine("Количество смежных пар, в которых одно число делится на три равно = {0}", NumberOfPairs(arr));
            

        }
    }
}
