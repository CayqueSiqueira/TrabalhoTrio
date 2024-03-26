using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace impostoDeRenda
{
    public class impostoLeao
    {
        public float CalculoImposto(float salario)
        {
            float imposto = 0;
            float resultado = 0;
            
            if (salario <= 2259.20f)
            {
                imposto = 0;
            }
            else if (salario <= 2826.66f)
            {
                imposto = salario * 0.075f;
                resultado = salario - imposto + 169.44f;
            }
            else if (salario <= 3751.05f)
            {
                imposto = salario * 0.15f;
                resultado = salario - imposto + 381.44f;

            }
            else if (salario <= 4664.68f)
            {
                imposto = salario * 0.225f;
                resultado = salario - imposto + 662.77f;

            }
            else
            {
                imposto = salario * 0.275f;
                resultado = salario - imposto + 896.00f;
            }
            return resultado;
        }
    }
}
