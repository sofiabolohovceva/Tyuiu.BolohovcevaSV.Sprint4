using System;
using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.BolohovcevaSV.Sprint4.Task1.V6.Lib
{
    public class DataService : ISprint4Task1V6
    {
        public int Calculate(int[] array)
        {
            int mult = 1;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {
                    mult *= array[i];
                }
            }

            return mult;
        }
    }
}
