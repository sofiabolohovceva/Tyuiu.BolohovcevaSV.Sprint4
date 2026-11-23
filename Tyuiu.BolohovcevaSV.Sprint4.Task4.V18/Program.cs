using System;
using Tyuiu.BolohovcevaSV.Sprint4.Task4.V18.Lib;

namespace Tyuiu.BolohovcevaSV.Sprint4.Task4.V18
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт 4 | Выполнила: Болоховцева С. В. | СМАРТб-26-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт №4                                                               *");
            Console.WriteLine("* Тема: Двумерные массивы                                                 *");
            Console.WriteLine("* Задание №4                                                              *");
            Console.WriteLine("* Вариант №18                                                             *");
            Console.WriteLine("* Выполнила: Болоховцева С. В. | СМАРТб-26-1                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Заменить нечетные элементы массива на 0.                                *");
            Console.WriteLine("***************************************************************************");

            int[,] nums = new int[5, 5];

            Console.WriteLine("Введите элементы массива:");

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write($"Элемент [{i},{j}]: ");
                    nums[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            int[,] result = ds.Calculate(nums);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(result[i, j] + "\t");
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}