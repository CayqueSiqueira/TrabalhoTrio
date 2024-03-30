using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabalhoTrio;

namespace TesteTrabalhoTrio
{
    [TestClass]
    public class TesteCalcula
    {
        [TestMethod]
        public void TestCalculaSoma()
        {

            //cenario
            int a = 3;
            int b = 3;

            Calcula calcula = new Calcula();
            //acao
            int resultado = calcula.Soma(a, b);

            //verificação
            Assert.AreEqual(6, resultado);

        }
    }
}
