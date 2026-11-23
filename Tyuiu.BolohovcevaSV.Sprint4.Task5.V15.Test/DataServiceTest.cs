using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.BolohovcevaSV.Sprint4.Task5.V15.Lib;

namespace Tyuiu.BolohovcevaSV.Sprint4.Task5.V15.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int[,] array =
            {
                { 1, -2, 3, -4, 5 },
                { -1, 2, -3, 4, -5 },
                { 6, -6, 0, 1, -1 },
                { 2, 3, -4, -5, 0 },
                { -6, 4, 2, -3, 1 }
            };

            int wait = 34;
            int res = ds.Calculate(array);

            Assert.AreEqual(wait, res);
        }
    }
}
