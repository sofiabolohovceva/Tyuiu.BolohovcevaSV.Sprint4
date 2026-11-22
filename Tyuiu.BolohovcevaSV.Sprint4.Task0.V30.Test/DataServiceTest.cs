using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.BolohovcevaSV.Sprint4.Task0.V30.Lib;

namespace Tyuiu.BolohovcevaSV.Sprint4.Task0.V30.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumEvenArrEl()
        {
            DataService ds = new DataService();

            int[] nums = { 9, 8, 4, 6, 9, 4, 3, 6, 1, 2 };

            int wait = 30;
            int res = ds.GetSumEvenArrEl(nums);

            Assert.AreEqual(wait, res);
        }
    }
}
