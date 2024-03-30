// See https://aka.ms/new-console-template for more information



namespace TrabalhoTrio
{
    public class Cantoneira
    {
        public void CantoneiraConstrutor(int tamanhoCantoneira)
        {
            string linha = null;
            for (int coluna = 0; coluna < tamanhoCantoneira; coluna++)
            {

                    linha = linha + (coluna + 1);
                    Console.WriteLine(linha);
                
            }
        }

        public int ValidaCantoneira(int tamanhoCantoneira)
        {
            int gabarito = 0;
            for (int i = 0; i < tamanhoCantoneira;i++)
            {
                gabarito = gabarito + (i + 1);
            }
            return gabarito;
        }
    }

    
    
}
