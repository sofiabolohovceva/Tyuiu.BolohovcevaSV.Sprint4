using System;
using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.BolohovcevaSV.Sprint4.Task4.V18.Lib
{
    public class DataService : ISprint4Task4V18
    {
        public int[,] Calculate(int[,] matrix)
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (matrix[i, j] % 2 != 0)
                    {
                        matrix[i, j] = 0;
                    }
                }
            }

            return matrix;
        }
    }
}
