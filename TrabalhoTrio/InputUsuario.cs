

using System.Linq.Expressions;
using TrabalhoTrio;

Console.WriteLine("Bem vindo ao programa de testes:");
bool continua = true;
do 
{
    Console.WriteLine("Digite 0 para sair\nDigite 1 para somar dois numeros\nDigite 2 para converter metro em milimetro\nDigite 3 para criar uma cantoneira\nDigite 4 para calcular o imposto de renda\n");
    int resposta = int.Parse(Console.ReadLine());
    switch (resposta)
    {
        case 0:
            continua = false;
            break;
        case 1:
            Console.WriteLine("\nVocê escolheu somar dois números");
            Console.WriteLine("Entre com o 1º número");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o 2º número");
            int b = int.Parse(Console.ReadLine());
            Calcula calcula = new Calcula();
            Console.WriteLine($"O resultado da soma de {a} + {b} é {calcula.Soma(a, b)}\n");
            break;
        case 2:
            Console.WriteLine("\nVocê escolheu Converter metros para milimetros");
            Console.WriteLine("Entre com a quantidade em metros");
            decimal metro = decimal.Parse(Console.ReadLine());
            Converte converte = new Converte();
            Console.WriteLine($"{metro} metros(s) convertido(s) em milimetros é {converte.MetroParaMilimetro(metro)}\n");
            break;
        case 3:
            Console.WriteLine("\nVocê escolheu crar uma cantoneira");
            Console.WriteLine("Informe tamanho da cantoneira");
            int tamanhoCantoneira = int.Parse(Console.ReadLine());
            Cantoneira cantoneira = new Cantoneira();
            cantoneira.CantoneiraConstrutor(tamanhoCantoneira);
            Console.Write("\n");
            break;
        case 4:
            Console.WriteLine("\nVocê escolheu calcular seu umposto de renda");
            Console.Write("Digite sua renda mensal:");
            decimal salario = decimal.Parse(Console.ReadLine());
            Console.Write("Caso possua filhos digite quantos:");
            int filhos = int.Parse(Console.ReadLine());
            ImpostoLeao impostoLeao = new ImpostoLeao();
            Console.WriteLine($"O salário após o desconto é: {impostoLeao.CalculoImposto(salario, filhos):f2}\n");
            break;
    }

} while(continua == true);
