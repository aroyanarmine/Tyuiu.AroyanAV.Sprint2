using Tyuiu.AroyanAV.Sprint2.Task7.V12.Lib;

namespace Tyuiu.AroyanAV.Sprint2.Task7.V12.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double y = 1, x = 2;
            var res = ds.CheckDotInShadedArea(x, y);
            Assert.IsFalse(res);
        }
    }
}
