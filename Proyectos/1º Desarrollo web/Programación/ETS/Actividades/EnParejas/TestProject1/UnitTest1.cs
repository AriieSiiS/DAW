namespace TestProject1

{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int a = 10;
            int resultado = 20;
            CSAlturas.PersonasPorEncimaMedia();
            Assert.AreEqual(20, resultado);
        }
    }
}