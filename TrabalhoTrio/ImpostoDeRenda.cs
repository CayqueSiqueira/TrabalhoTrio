using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoTrio
{
    public class ImpostoLeao
    {
        public decimal CalculoImposto(decimal salario, int filhos)
        {
            decimal imposto = 0;
            decimal resultado = 0;
            
            if (salario <= 1903.98m)
            {
                imposto = 0;
                resultado = salario;
            }
            else if (salario <= 2826.65m)
            {
                imposto = (salario * 0.075m) - (169.44m * filhos);
                if(imposto < 0)
                {
                    imposto = 0;
                }
                resultado = salario - imposto;
            }
            else if (salario <= 3751.05m)
            {
                imposto = (salario * 0.15m) - (381.44m * filhos);
                if (imposto < 0)
                {
                    imposto = 0;
                }
                resultado = salario - imposto;

            }
            else if (salario <= 4664.68m)
            {
                imposto = (salario * 0.225m) - (662.77m * filhos);
                if (imposto < 0)
                {
                    imposto = 0;
                }
                resultado = salario - imposto;

            }
            else
            {
                imposto = (salario * 0.275m) - (896.00m * filhos);
                if (imposto < 0)
                {
                    imposto = 0;
                }
                resultado = salario - imposto;
            }
            return resultado;
        }
    }
}
