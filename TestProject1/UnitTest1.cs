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

            //verificação
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

            //verificação
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

            //verificação
            Assert.AreEqual(3000, resultado);

        }

        [TestMethod]
        public void TestMethod1()
        {
            float salario = 8000;

            var impostoDeRenda = new impostoLeao();

            float resultado = impostoDeRenda.CalculoImposto(salario);
            Assert.AreEqual(6696, resultado);
        }
    }
}
