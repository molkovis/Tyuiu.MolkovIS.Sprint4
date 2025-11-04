using Tyuiu.MolkovIS.Sprint4.Task7.V30.Lib;


namespace Tyuiu.MolkovIS.Sprint4.Task7.V30.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            string str = "2345";
            int wait = 8;
            int real = ds.Calculate(0, 0, str);
            Assert.AreEqual(wait, real);

        }
    }
}
