

using System.Linq.Expressions;
using TrabalhoTrio;

Console.WriteLine("Bem vindo ao programa de testes:");
bool continua = true;
do 
{
    Console.WriteLine("Digite 0 para sair\nDigite 1 para somar dois numeros\nDigite 2 para converter metro em milimetro\nDigite 3 para criar uma cantoneira\nDigite 4 para calcular o imposto de renda");
    int resposta = int.Parse(Console.ReadLine());
    switch (resposta)
    {
        case 0:
            continua = false;
            break;
        case 1:
            Console.WriteLine("Entre com o 1º número");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o 2º número");
            int b = int.Parse(Console.ReadLine());
            Calcula calcula = new Calcula();
            Console.WriteLine($"O resultado da soma de {a} + {b} é {calcula.Soma(a, b)}");
            break;
        case 2:
            Console.WriteLine("Entre com a quantidade em metros");
            decimal metro = decimal.Parse(Console.ReadLine());
            Converte converte = new Converte();
            Console.WriteLine($"{metro}metros(s) convertido(s) em milimetros é {converte.MetroParaMilimetro(metro)}");
            break;
        case 3:
            Console.WriteLine("Informe tamanho da cantoneira");
            int tamanhoCantoneira = int.Parse(Console.ReadLine());
            Cantoneira cantoneira = new Cantoneira();
            Console.WriteLine(cantoneira.CantoneiraConstrutor(tamanhoCantoneira));
            break;
        case 4:
            Console.Write("Digite sua renda mensal:");
            float salario = float.Parse(Console.ReadLine());
            var impostoDeRenda = new impostoLeao();
            Console.WriteLine($"O salário após o desconto é: {impostoDeRenda.CalculoImposto(salario)}");

    }

}while(continua == true);
