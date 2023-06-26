////É Dado uma letra ('A' a 'Z'), exiba um diamante iniciando em 'A' e
////tendo a letra fornecida com o  ponto mais distante.
using System;

namespace DiamanteLetras.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char letraInformada = 'G';

            char letra = 'A';

            int espacosDaMargem = letraInformada - letra;

            int quantidadeLinhas = letraInformada - letra;

            int espacosEntreAsLetras = -1;

            //desenhou a parte do superior do diamante

            for (int linha = 0; linha < quantidadeLinhas; linha++)
            {
                for (int i = 0; i < espacosDaMargem; i++)
                    Console.Write(" ");

                Console.Write(letra);

                for (int i = 0; i < espacosEntreAsLetras; i++)
                    Console.Write(" ");

                if (letra != 'A')
                    Console.Write(letra); //letra final

                letra++;
                espacosDaMargem--;
                espacosEntreAsLetras += 2;

                Console.WriteLine();
            }

            //desenho da parte do meio
            Console.Write(letraInformada);

            for (int i = 0; i < espacosEntreAsLetras; i++)
                Console.Write(" ");

            Console.Write(letraInformada);

            letra--;
            espacosDaMargem++;
            espacosEntreAsLetras -= 2;
            Console.WriteLine();

            //desenho da parte inferior do diamante

            for (int linha = 0; linha < quantidadeLinhas; linha++)
            {
                for (int i = 0; i < espacosDaMargem; i++)
                    Console.Write(" ");

                Console.Write(letra);

                for (int i = 0; i < espacosEntreAsLetras; i++)
                    Console.Write(" ");

                if (letra != 'A')
                    Console.Write(letra); //letra final

                letra--;
                espacosDaMargem++;
                espacosEntreAsLetras -= 2;

                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
