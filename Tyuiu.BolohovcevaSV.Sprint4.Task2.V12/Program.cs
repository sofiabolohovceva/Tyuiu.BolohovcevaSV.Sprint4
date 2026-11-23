using System;
using Tyuiu.BolohovcevaSV.Sprint4.Task2.V12.Lib;

namespace Tyuiu.BolohovcevaSV.Sprint4.Task2.V12
{
    class Program
    {
        static void Main(string[] args)
        {

            Random rnd = new Random();
            DataService ds = new DataService();
            Console.Title = "Спринт 3 | Выполнила: Болоховцева С. В. | СМАРТб-26-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт 4                                                                *");
            Console.WriteLine("* Тема: Одномерные массивы                                                *");
            Console.WriteLine("* Задание №2                                                              *");
            Console.WriteLine("* Вариант №12                                                             *");
            Console.WriteLine("* Выполнила: Болоховцева София Вячеславовна | СМАРТб-26-1                 *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан одномерный целочисленный массив на 14 элементов                     *");
            Console.WriteLine("* заполненный случайными в диапазоне от 4 до 9                            *");
            Console.WriteLine("* подсчитать сумму нечетных элементов массива.                            *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");

            Console.Write("Введите количество элементов массива: ");
            int len = Convert.ToInt32(Console.ReadLine());

            int[] numsArray = new int[len];

            for (int i = 0; i <= len - 1; i++)
            {
                numsArray[i] = rnd.Next(4, 9);
            }

            Console.WriteLine("Массив: ");
            for (int i = 0; i <= len - 1; i++)
            {
                Console.Write(numsArray[i] + '\t');
            }

            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            int res = ds.Calculate(numsArray);

            Console.WriteLine("Сумма нечетных элементов массива = " + res);

            Console.ReadKey();
        }
    }
}
