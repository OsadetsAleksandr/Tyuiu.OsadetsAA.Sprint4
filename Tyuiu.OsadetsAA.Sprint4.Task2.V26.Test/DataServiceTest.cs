using Tyuiu.OsadetsAA.Sprint4.Task2.V26.Lib;
namespace Tyuiu.OsadetsAA.Sprint4.Task2.V26.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();
            int[] numsArray = { 2, 4, 3, 4, 6, 5, 7, 4, 5, 2, 6, 3, 5, 4 };
            int res = ds.Calculate(numsArray);
            int wait = 7875;
            Assert.AreEqual(wait, res);
        }
    }
}