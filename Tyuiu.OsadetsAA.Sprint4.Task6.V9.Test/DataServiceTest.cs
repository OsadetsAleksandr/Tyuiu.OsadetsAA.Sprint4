using Tyuiu.OsadetsAA.Sprint4.Task6.V9.Lib;
namespace Tyuiu.OsadetsAA.Sprint4.Task6.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();
            var str = new string[] { "�������", "���������", "������", "�������", "�����", "������", "����������" };
            int res = ds.Calculate(str);
            int wait = 3;
            Assert.AreEqual(wait, res);
        }
    }
}