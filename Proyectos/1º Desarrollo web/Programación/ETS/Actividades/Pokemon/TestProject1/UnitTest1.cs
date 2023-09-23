using Ejercicio;
namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        public const string FilePokemon = "..\\..\\..\\pokemon.csv";
        [TestMethod]
        public void TestMethod1()
        {
            string filewrong = "..\\..\\..\\pokemon1.csv";
            int generation = 0;
            string resultado = Functions.strongestPokemon(filewrong, generation);
            string expected = "";
            Assert.AreEqual(expected, resultado);
        }
        [TestMethod]
        public void TestMethod2()
        {
            int generation = 0;
            string resultado = Functions.strongestPokemon(FilePokemon, generation);
            string expected = "";
            Assert.AreEqual(expected, resultado);
        }
        [TestMethod]
        public void TestMethod3()
        {
            int generation = 1;
            string resultado = Functions.strongestPokemon(FilePokemon, generation);
            string expected = "PinsirMega Pinsir";
            Assert.AreEqual(expected, resultado);
        }
        [TestMethod]
        public void TestMethod4()
        {
            int generation = 8;
            string resultado = Functions.strongestPokemon(FilePokemon, generation);
            string expected = "";
            Assert.AreEqual(expected, resultado);
        }
    }
    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        public void TestMethod1()
        {
            string filewrong = "..\\..\\..\\pokemon1.csv";
            int generation = 0;
            string resultado = Functions.strongestPokemon(filewrong, generation);
            string expected = "";
            Assert.AreEqual(expected, resultado);
        }
        [TestMethod]
        public void TestMethod2()
        {
            string filewrong = "..\\..\\..\\pokemon1.csv";
            string resultado = Functions.filterPokemon(filewrong);
            //no se muy bien como probar esto
            string expected = "..\\..\\..\\DoubleTypePokemon.csv";
            Assert.AreEqual(expected, resultado);
        }
    }
}