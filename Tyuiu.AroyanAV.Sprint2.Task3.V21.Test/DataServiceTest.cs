using Tyuiu.AroyanAV.Sprint2.Task3.V21.Lib;

namespace Tyuiu.AroyanAV.Sprint2.Task3.V21.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
            {
                DataService ds = new DataService();
                double x = 6;
                double res = ds.Calculate(x);
                double wait = 4374;
                Assert.AreEqual(wait, res);
            }

            [TestMethod]
            public void TestMethod2()
            {
                DataService ds = new DataService();
                double x = 0;
                double res = ds.Calculate(x);
                double wait = 0.833;
                Assert.AreEqual(wait, res);
            }

            [TestMethod]
            public void TestMethod3()
            {
                DataService ds = new DataService();
                double x = -2;
                double res = ds.Calculate(x);
                double wait = 0.64;
                Assert.AreEqual(wait, res);
            }

            [TestMethod]
            public void TestMethod4()
            {
                DataService ds = new DataService();
                double x = -40;
                double res = ds.Calculate(x);
                double wait = -439.975;
                Assert.AreEqual(wait, res);
            }
        }
    }
