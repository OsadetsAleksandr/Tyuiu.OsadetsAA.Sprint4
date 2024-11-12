using Tyuiu.OsadetsAA.Sprint4.Task5.V7.Lib;
namespace Tyuiu.OsadetsAA.Sprint4.Task5.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCal()
        {
            DataService ds = new DataService();
            int[,] mas2 = { { -7, -6, -5, -4, -3},
                            { -2, -1, 0, 1, 2 },
                            { 3, 4, 5, 6, 5 },
                            { 4, 3, 2, 1, 0 },
                            { -1, -2, -3, -4, -5 } };
            int res = ds.Calculate(mas2);
            int wait = 12;
            Assert.AreEqual(wait, res);
        }
    }
}