using Newtonsoft.Json.Linq;
using TrabalhoTrio;

namespace TesteTrabalhoTrio
{
    [TestClass]
    public class CantoneiraTest
    {
        [TestMethod]
        public void TestCantoneiraCorreta()
        {

            //cenario
            int tamanhoCantoneira = 3;

            Cantoneira cantoneira = new Cantoneira();
            //acao
            int resultado = cantoneira.CantoneiraConstrutor(tamanhoCantoneira);

            //verifica��o
            Assert.AreEqual(10, resultado);

        }

        [TestMethod]
        public void TestCalculaSoma()
        {

            //cenario
            int a = 3;
            int b = 3;

            Calcula calcula = new Calcula();
            //acao
            int resultado = calcula.Soma(a,b);

            //verifica��o
            Assert.AreEqual(6, resultado);

        }

        [TestMethod]
        public void TestConverteMetro()
        {

            //cenario
            Decimal metros = 3;

            Converte converte = new Converte();
            //acao
            Decimal resultado = converte.MetroParaMilimetro(metros);

            //verifica��o
            Assert.AreEqual(3000, resultado);

        }
    }
}