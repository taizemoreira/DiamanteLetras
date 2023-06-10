////É Dado uma letra ('A' a 'Z'), exiba um diamante iniciando em 'A' e
////tendo a letra fornecida com o  ponto mais distante.
using System;

namespace DiamanteLetras.ConsoleApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            char letraInformada = 'E';
            char letra = 'A';
            int espacosDaMargem = letraInformada - letra;
            int quantidadeDeLinhas = letraInformada - letra;

            int espacosEntreAsLetras = -1;

            // desenho parte superior
            for (int linha = 0; linha < quantidadeDeLinhas; linha++)
            {
                for (int i = 0; i < espacosDaMargem; i++)
                    Console.WriteLine("b");
            }

            Console.Write(letra);

            for (int linha = 0; linha < quantidadeDeLinhas; linha++)
            {
                    for (int i = 0; i < espacosEntreAsLetras; i++)
                        Console.WriteLine(" ");     
            }

            if (letra != 'A')
                Console.WriteLine(letra);

            letra++;
            espacosDaMargem--;
            espacosEntreAsLetras += 2;

            Console.WriteLine();
        
            //desenho da parte do meio
            Console.Write(letraInformada);

            for (int i = 0;i<espacosEntreAsLetras; i++) 
                Console.WriteLine(" ");       

            Console.Write(letraInformada);

            letra--;
            espacosDaMargem++;
            espacosEntreAsLetras -= 2;
            Console.WriteLine();

            //desenho da parte inferior
            for (int linha = 0; linha < 4; linha++)
            {
                for (int i = 0; i < espacosDaMargem; i++)
                    Console.WriteLine("b");
            }

            Console.Write(letra);

            for (int linha = 0; linha < 4; linha++)
            {
                {
                    for (int i = 0; i < espacosEntreAsLetras; i++)                  
                        Console.WriteLine(" ");                  
                }
            }

            if (letra != 'A')
                Console.WriteLine(letra);

            letra--;
            espacosDaMargem++;
            espacosEntreAsLetras -= 2;

            Console.WriteLine();
        }
    }
}


