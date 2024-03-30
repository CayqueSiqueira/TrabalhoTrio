using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabalhoTrio;

namespace TesteTrabalhoTrio
{
    [TestClass]
    public class TesteConverte
    {
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
    }
}
