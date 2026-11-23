using System;
using Tyuiu.BolohovcevaSV.Sprint4.Task3.V23.Lib;

namespace Tyuiu.BolohovcevaSV.Sprint4.Task3.V23
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт 2 | Выполнила: Болоховцева С. В. | СМАРТб-26-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт 4                                                                *");
            Console.WriteLine("* Тема: Операции сравнения                                                *");
            Console.WriteLine("* Задание №3                                                              *");
            Console.WriteLine("* Вариант №23                                                              *");
            Console.WriteLine("* Выполнила: Болоховцева София Вячеславовна | СМАРТб-26-1                 *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Подсчитать количество четных элементов двумерного массива 5 на 5.      *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");

            int[,] matrix =
            {
                { 7, 5, 5, 6, 7 },
                { 8, 7, 8, 4, 3 },
                { 5, 6, 7, 8, 3 },
                { 4, 2, 3, 6, 4 },
                { 5, 2, 4, 2, 3 }
            };

            Console.WriteLine("Массив:");

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }

            int res = ds.Calculate(matrix);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Количество четных элементов = " + res);

            Console.ReadLine();
        }
    }
}