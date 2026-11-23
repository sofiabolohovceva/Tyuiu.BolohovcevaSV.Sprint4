using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.BolohovcevaSV.Sprint4.Task7.V3.Lib;

namespace Tyuiu.BolohovcevaSV.Sprint4.Task7.V3.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            int rows = 4;
            int columns = 2;

            string str = "27182818";

            DataService ds = new DataService();

            int res = ds.Calculate(rows, columns, str);

            int wait = 3;

            Assert.AreEqual(wait, res);
        }
    }
}
