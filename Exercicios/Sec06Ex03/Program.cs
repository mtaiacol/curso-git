using System;

namespace Sec06Ex03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** Matrizes ***");
            Console.WriteLine("");
            Console.Write("Informe o Nº de Lados da Matriz: ");
            int nLados = int.Parse(Console.ReadLine());
            Console.WriteLine("");

            int[,] Cubo = new int[nLados, nLados];
            int NumNeg = 0;

            for (int x = 0; x < nLados; x++)
            {
                for (int y = 0; y < nLados; y++)
                {
                    Console.Write($"Entre com o Elemento da Linha {x}, Coluna {y}: ");
                    Cubo[x, y] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("");
            Console.Write("A Diagonal Principal da Matrix é: ");

            for (int x = 0; x < nLados; x++)
            {
                Console.Write($"{Cubo[x, x]} ");
            }

            Console.WriteLine("");

            for (int x = 0; x < nLados; x++)
            {
                for (int y = 0; y < nLados; y++)
                {
                    if (Cubo[x, y] < 0)
                        NumNeg++;
                }
            }

            Console.WriteLine("");
            Console.Write($"A Matrix tem {NumNeg} Números Negativos: ");
        }
    }
}