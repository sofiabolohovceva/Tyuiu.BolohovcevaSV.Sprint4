using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.BolohovcevaSV.Sprint4.Task2.V12.Lib;

namespace Tyuiu.BolohovcevaSV.Sprint4.Task2.V12.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int[] nums = { 5, 4, 4, 7, 9, 5, 4, 6, 7, 4, 7, 9, 6, 5 };

            int wait = 54;
            int res = ds.Calculate(nums);

            Assert.AreEqual(wait, res);
        }
    }
}
