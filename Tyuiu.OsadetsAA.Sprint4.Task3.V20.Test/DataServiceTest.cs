using Tyuiu.OsadetsAA.Sprint4.Task3.V20.Lib;
namespace Tyuiu.OsadetsAA.Sprint4.Task3.V20.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();
            int[,] mas2 = { {8, 7, 7, 8, 5},
                            {4, 3, 5, 6, 3 },
                            {5, 3, 8, 6, 3 },
                            {6, 3, 8, 5, 4 },
                            {3, 6, 8, 3, 4 } };

            int res = ds.Calculate(mas2);
            int wait = 3;
            Assert.AreEqual(wait, res);
        }
    }
}