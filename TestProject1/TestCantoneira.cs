using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabalhoTrio;

namespace TesteTrabalhoTrio
{
    [TestClass]
    public class TesteCantoneira
    {
        [TestMethod]
        public void TestCantoneiraCorreta()
        {

            //cenario
            int tamanhoCantoneira = 5;

            Cantoneira cantoneira = new Cantoneira();
            //acao
            int resultado = cantoneira.ValidaCantoneira(tamanhoCantoneira);

            //verificação
            Assert.AreEqual(15, resultado);

        }
    }
}
