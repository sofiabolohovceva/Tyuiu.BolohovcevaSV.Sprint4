using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.BolohovcevaSV.Sprint4.Task4.V18.Lib;

namespace Tyuiu.BolohovcevaSV.Sprint4.Task4.V18.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckReplaceOddNumbers()
        {
            DataService ds = new DataService();

            int[,] nums =
            {
                { 4, 7, 4, 5, 4 },
                { 4, 4, 5, 6, 7 },
                { 7, 5, 6, 6, 6 },
                { 6, 7, 6, 6, 4 },
                { 5, 6, 6, 6, 5 }
            };

            int[,] wait =
            {
                { 4, 0, 4, 0, 4 },
                { 4, 4, 0, 6, 0 },
                { 0, 0, 6, 6, 6 },
                { 6, 0, 6, 6, 4 },
                { 0, 6, 6, 6, 0 }
            };

            int[,] res = ds.Calculate(nums);

            CollectionAssert.AreEqual(wait, res);
        }
    }
}
