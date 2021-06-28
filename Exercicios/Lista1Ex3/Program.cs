using System;

namespace Lista1Ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, d;

            Console.Write("Informe o 1º Valor: ");
            a = int.Parse(Console.ReadLine());

            Console.Write("Informe o 2º Valor: ");
            b = int.Parse(Console.ReadLine());

            Console.Write("Informe o 3º Valor: ");
            c = int.Parse(Console.ReadLine());

            Console.Write("Informe o 4º Valor: ");
            d = int.Parse(Console.ReadLine());

            Console.WriteLine($"A Diferença entre os Produtos de {a} * {b} e {c} * {d} é igual a {Produto(a, b, c, d)}!");
        }

        static int Produto(int n1, int n2, int n3, int n4)
        {
            return (n1 * n2 - n3 * n4);
        }
    }
}
