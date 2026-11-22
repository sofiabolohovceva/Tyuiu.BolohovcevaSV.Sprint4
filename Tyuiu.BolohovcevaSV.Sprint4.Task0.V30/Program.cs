using System;
using Tyuiu.BolohovcevaSV.Sprint4.Task0.V30.Lib;

namespace Tyuiu.BolohovcevaSV.Sprint4.Task0.V30
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт 4 | Выполнила: Болоховцева С. В. | СМАРТб-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт 4                                                                *");
            Console.WriteLine("* Тема: Одномерные массивы                                                *");
            Console.WriteLine("* Задание №0                                                              *");
            Console.WriteLine("* Вариант №30                                                             *");
            Console.WriteLine("* Выполнила: Болоховцева София Вячеславовна | СМАРТб-26-1                 *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан одномерный целочисленный массив на 10 элементов, заполненный        *");
            Console.WriteLine("* статическими значениями в диапазоне от 0 до 9. Подсчитать сумму        *");
            Console.WriteLine("* четных элементов массива.                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");

            int[] nums = { 9, 8, 4, 6, 9, 4, 3, 6, 1, 2 };

            Console.WriteLine("Исходный массив:");

            for (int i = 0; i < nums.Length; i++)
            {
                Console.Write(nums[i] + " ");
            }

            int res = ds.GetSumEvenArrEl(nums);

            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Сумма четных элементов массива = " + res);

            Console.ReadLine();
        }
    }
}