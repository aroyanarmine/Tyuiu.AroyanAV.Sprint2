using Tyuiu.AroyanAV.Sprint2.Task5.V10.Lib;

namespace Tyuiu.AroyanAV.Sprint2.Task5.V10.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string res = ds.FindDateOfPreviousDay(2024, 9, 3);
            Assert.AreEqual("02.09.2024", res);
        }
    }
}
