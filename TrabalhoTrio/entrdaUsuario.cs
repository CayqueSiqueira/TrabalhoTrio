

using TrabalhoTrio;

Console.WriteLine("Informe tamanho da cantoneira");
int tamanhoCantoneira = int.Parse(Console.ReadLine());
Cantoneira cantoneira = new Cantoneira();
Console.WriteLine(cantoneira.CantoneiraConstrutor(tamanhoCantoneira));