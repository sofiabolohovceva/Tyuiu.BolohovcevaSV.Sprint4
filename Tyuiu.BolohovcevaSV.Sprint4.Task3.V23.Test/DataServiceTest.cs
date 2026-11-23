using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.BolohovcevaSV.Sprint4.Task3.V23.Lib;

namespace Tyuiu.BolohovcevaSV.Sprint4.Task3.V23.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int[,] matrix =
            {
                { 7, 5, 5, 6, 7 },
                { 8, 7, 8, 4, 3 },
                { 5, 6, 7, 8, 3 },
                { 4, 2, 3, 6, 4 },
                { 5, 2, 4, 2, 3 }
            };

            int res = ds.Calculate(matrix);

            Assert.AreEqual(13, res);
        }
    }
}
