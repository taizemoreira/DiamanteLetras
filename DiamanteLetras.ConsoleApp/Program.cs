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
            int espacosDaMargem = letraInformada - letra; //diferença entre espaços
            int quantidadeLinhas = letraInformada - letra;
            int espacosEntreAsLetras = -1;

            //desenho da parte superior do diamante
            for (int linha = 0; linha < quantidadeLinhas; linha++)
            {
                for (int i = 0; i < espacosDaMargem; i++)
                { // primeira linha do diamante
                    Console.Write(" ");
                }

                Console.Write(letra);

                for (int i = 0; i < espacosEntreAsLetras; i++)
                {
                    Console.Write(" ");
                }
                if (letra != 'A')
                {
                    Console.Write(letra); //letra final
                }

                letra++;
                espacosDaMargem--;
                espacosEntreAsLetras += 2;

                Console.WriteLine();
            }

            // desenho parte do meio  do diamante 
            Console.Write(letraInformada);

            for (int i = 0; i < espacosEntreAsLetras; i++)
            {
                Console.Write(" ");
            }

            letra--;
            espacosDaMargem++;
            espacosEntreAsLetras -= 2;
            Console.WriteLine();    

        }

        // desenho parte inferior do diamante
        for (int linha = 0; linha < quantidadeLinhas; linha++)
			{
                for (int i = 0; i < espacosDaMargem; i++)
			    {
                    Console.Write(" ");
			    }

                Console.Write(letra);

                for (int i = 0; i < espacosEntreAsLetras; i++)
			    {
                    Console.Write(" ");
			    }

                if (DiamanteLetras != 'A')
                    Console.Write(letra); // letra final
                

                letra--;
                espacosDaMargem++;
                espacosEntreAsLetras -= 2;

                Console.WriteLine(); 
			    }
                
            Console.ReadLine(); 
          
         }        
    }
}

