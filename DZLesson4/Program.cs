using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace DZLesson4
{
    #region task2
    /*
        Реализуйте задачу 1 в виде статического класса StaticClass;
        а) Класс должен содержать статический метод, который принимает на вход массив и решает задачу 1;
        б) * Добавьте статический метод для считывания массива из текстового файла.Метод должен возвращать массив целых чисел;
        в)** Добавьте обработку ситуации отсутствия файла на диске.
    */
    static class task2
    {
        public static int[] ReadFromFile(string filename)
        {
            try
            {
                string line = null;

                line = File.ReadAllText(filename);
                string[] strArr = line.Split(' ', '\t');

                int[] result = new int[strArr.Length];

                for (int i = 0; i < strArr.Length; i++)
                {
                    result[i] = Convert.ToInt32(strArr[i]);
                }

                return result;
            }
            catch (FileNotFoundException exp)
            {
                Console.WriteLine(exp.Message);
                return new int[1] { 0 };
            }
        }
        
        public static int FindPairs(int[] arr)
        {
            int counter = 0;    // счётчик пар

            for (int i = 0; i < arr.Length - 1; i++)
            {
                if ((arr[i] % 3 == 0) ^ (arr[i + 1] % 3 == 0))
                    counter++;
            }

            return counter;
        }
    }
    #endregion task2

    class Program
    {
        #region task1
        
         /* Дан целочисленный массив из 20 элементов. Элементы массива могут принимать
          * целые значения от –10 000 до 10 000 включительно. Заполнить случайными числами.
          * Написать программу, позволяющую найти и вывести количество пар элементов массива, 
          * в которых только одно число делится на 3. В данной задаче под парой подразумевается
          * два подряд идущих элемента массива.
          * Например, для массива из пяти элементов: 6; 2; 9; –3; 6 ответ — 2. 
          */
        
        //public static int[] Create1DArray(int n)
        //{
        //    //Создание объекта для генерации чисел
        //    Random rnd = new Random();

        //    // объявление одномерного массива размерностью n
        //    int[] arr = new int[n];

        //    // инициализация эл-тов массива случайными числами от -10000 до 10000
        //    for (int i = 0; i < n; i++)
        //        arr[i] = rnd.Next(-10000, 10001);
        //    return arr;
        //}

        //public static int NumberOfPairs(int[] arr)
        //{
        //    int counter = 0;    // счётчик пар

        //    for (int i = 0; i < arr.Length - 1; i++)
        //    {
        //        if ((arr[i] % 3 == 0) ^ (arr[i + 1] % 3 == 0))
        //            counter++;
        //    }

        //    return counter;
        //}
        #endregion task1

        static void Main(string[] args)
        {
            #region for task2
            Console.WriteLine("Наш массив, считаный из файла: ");
            int[] arr = task2.ReadFromFile("arr1.txt");
            for (int i = 0; i < arr.Length; i++)
            {
                //Вывод полученного массива в консоль
                Console.Write($"{arr[i]} ");
            }
            Console.WriteLine();

            Console.WriteLine("Количество смежных пар массива, \nв которых только одно число делится на три равно = {0}", task2.FindPairs(arr));

            #endregion for task2

            #region for task1
            //int[] arr = Create1DArray(6);

            //Console.WriteLine("Наш псевдослучайный массив: ");
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    //Вывод полученного массива в консоль
            //    Console.Write($"{arr[i]} ");
            //}
            //Console.WriteLine();
            //Console.WriteLine("Количество смежных пар, в которых одно число делится на три равно = {0}", NumberOfPairs(arr));
            #endregion for task1

        }
    }
}
