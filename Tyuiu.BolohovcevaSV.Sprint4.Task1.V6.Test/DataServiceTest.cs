using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.BolohovcevaSV.Sprint4.Task1.V6.Lib;

namespace Tyuiu.BolohovcevaSV.Sprint4.Task1.V6.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int[] nums = { 2, 4, 4, 7, 2, 5, 4, 3, 3, 4 };

            int wait = 1024;
            int res = ds.Calculate(nums);

            Assert.AreEqual(wait, res);
        }
    }
}
