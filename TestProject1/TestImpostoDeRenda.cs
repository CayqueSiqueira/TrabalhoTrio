using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabalhoTrio;

namespace TesteTrabalhoTrio
{
    [TestClass]
    public class TesteImpostoDeRenda
    {
        [TestMethod]
        public void TesteImposto()
        {
            decimal salario = 1000;
            int filhos = 1;

            ImpostoLeao impostoLeao = new ImpostoLeao();

            decimal resultado = impostoLeao.CalculoImposto(salario, filhos);
            Assert.AreEqual(1000.000m, resultado);

            salario = 2000;
            filhos = 1;
            resultado = impostoLeao.CalculoImposto(salario, filhos);
            Assert.AreEqual(2000.000m, resultado);

            salario = 3000;
            filhos = 1;
            resultado = impostoLeao.CalculoImposto(salario, filhos);
            Assert.AreEqual(2931.440m, resultado);

            salario = 4000;
            filhos = 1;
            resultado = impostoLeao.CalculoImposto(salario, filhos);
            Assert.AreEqual(3762.770m, resultado);

            salario = 5000;
            filhos = 1;
            resultado = impostoLeao.CalculoImposto(salario, filhos);
            Assert.AreEqual(4521.000m, resultado);


        }
    }
}
