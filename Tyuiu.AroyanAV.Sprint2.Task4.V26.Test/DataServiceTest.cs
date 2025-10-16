using Tyuiu.AroyanAV.Sprint2.Task4.V26.Lib;

namespace Tyuiu.AroyanAV.Sprint2.Task4.V26.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 3;
            double y = 5;
            double res = ds.Calculate(x, y);
            double wait = 111616.035;
            Assert.AreEqual(wait, res);
        }
        public void ValidCondition2()
        {
            DataService ds = new DataService();
            double x = 3;
            double y = 5;
            double res = ds.Calculate(x, y);
            double wait = 3;
            Assert.AreEqual(wait, res);
        }
    }
}
