using System;
using Tyuiu.BolohovcevaSV.Sprint4.Task7.V3.Lib;

namespace Tyuiu.BolohovcevaSV.Sprint4.Task7.V3
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт 4 | Выполнила: Болоховцева С. В. | СМАРТб-26-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт 4                                                                *");
            Console.WriteLine("* Тема: Двумерные массивы                                                 *");
            Console.WriteLine("* Задание №7                                                              *");
            Console.WriteLine("* Вариант №3                                                              *");
            Console.WriteLine("* Выполнила: Болоховцева София Вячеславовна | СМАРТб-26-1                 *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дана строка из одноразрядных цифр 27182818. Преобразовать ее в матрицу  *");
            Console.WriteLine("* 4 на 2 и подсчитать количество нечетных чисел в матрице.               *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");

            int rows = 4;
            int columns = 2;
            string str = "27182818";
            int index = 0;

            Console.WriteLine("\nМатрица:");

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"{str[index]}\t");
                    index++;
                }
                Console.WriteLine();
            }
            Console.WriteLine("Строка = " + str);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Количество нечетных элементов = " + ds.Calculate(rows, columns, str));
            Console.ReadLine();
        }
    }
}