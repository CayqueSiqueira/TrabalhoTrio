﻿// See https://aka.ms/new-console-template for more information



namespace TrabalhoTrio
{
    public class Cantoneira
    {
        public int CantoneiraConstrutor(int tamanhoCantoneira)
        {
            int gabarito = 0;
            for (int coluna = 0; coluna < tamanhoCantoneira; coluna++)
            {
                for (int linha = 0; linha < tamanhoCantoneira; linha++)
                {

                    if (linha > coluna)
                    {
                        break;
                    }
                    Console.Write(linha + 1);
                    gabarito = gabarito + (linha + 1);

                    //if(linha + 1 == tamanhoCantoneira)
                    //{
                    //    gabarito = gabarito + (linha + 1);
                    //}
                    //else
                    //{
                    //    gabarito = gabarito + (linha + 1) + ',';
                    //}


                }
                Console.WriteLine();

            }

            return gabarito;



        }
    }

    
    
}
