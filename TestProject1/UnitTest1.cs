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
            int tamanhoCantoneira = 5;

            Cantoneira cantoneira = new Cantoneira();
            //acao
            string resultado = cantoneira.CantoneiraConstrutor(tamanhoCantoneira);

            //verificação
            Assert.AreEqual("1,1,2,1,2,3,1,2,3,4,1,2,3,4,5", resultado);

        }
    }
}