using Tyuiu.OsadetsAA.Sprint4.Task1.V23.Lib;
namespace Tyuiu.OsadetsAA.Sprint4.Task1.V23.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();
            int[] numsArray = { 9, 9, 5, 6, 5, 4, 4, 5, 8, 7, 6, 8, 7, 5, 9, 9, 9 };
            int res = ds.Calculate(numsArray);
            int wait = 36;
            Assert.AreEqual(wait, res);
        }
    }
}