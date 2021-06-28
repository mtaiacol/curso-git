using System;

namespace Sec06Ex04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** Matriz 02 ***");
            Console.WriteLine("");
            Console.Write("Informe a Qtde de Linhas X Colunas da Matriz (Separado por Espaço): ");
            string[] sLinCol = Console.ReadLine().Split(' ');
            Console.WriteLine("");

            int[,] Matriz = new int[int.Parse(sLinCol[0]), int.Parse(sLinCol[1])];

            for (int l = 0; l < int.Parse(sLinCol[0]); l++)
            {
                Console.Write($"Informe a {l + 1}ª Linha da Matriz (Separado por Espaço): ");
                string[] Linha = Console.ReadLine().Split(' ');
                for (int c = 0; c < int.Parse(sLinCol[1]); c++)
                {
                    Matriz[l, c] = int.Parse(Linha[c]);
                }
            }
            Console.WriteLine("");

            Console.Write("Informe um Número a ser Pesquisado na Matriz : ");
            int nPesq = int.Parse(Console.ReadLine());


            for (int l = 0; l < int.Parse(sLinCol[0]); l++)
            {
                for (int c = 0; c < int.Parse(sLinCol[1]); c++)
                {
                    if (Matriz[l, c] == nPesq)
                    {
                        Console.WriteLine("");
                        Console.Write($"O Número Pesquisado está na Posição: {l}, {c}! "); Console.WriteLine("");

                        if (l - 1 >= 0)//Acima
                            Console.Write($"Acima dele temos o Número: {Matriz[l - 1, c]}! "); Console.WriteLine("");

                        if (c - 1 >= 0)//Esquerda
                            Console.Write($"A Esquerda dele temos o Número: {Matriz[l, c - 1]}! "); Console.WriteLine("");

                        if (c + 1 <= int.Parse(sLinCol[1])) //Direita
                            Console.Write($"A Direita dele temos o Número: {Matriz[l, c + 1]}! "); Console.WriteLine("");

                        if (l + 1 < int.Parse(sLinCol[0]))//Abaixo
                            Console.Write($"Abaixo dele temos o Número: {Matriz[l + 1, c]}! "); Console.WriteLine("");
                    }
                }
            }
        }
    }
}
