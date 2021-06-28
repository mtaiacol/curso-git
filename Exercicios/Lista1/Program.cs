using System;

namespace Lista1
{
    class Ex1
    {
        static void Main(string[] args)
        {

            Console.Write("Informe os Números no Formato 'X+Y': ");

            string[] n = Console.ReadLine().Split("+");

            Console.Write($"Soma = {Soma(int.Parse(n[0]), int.Parse(n[1]))}");
        }

        static double Soma(double a, double b)
        {
            return a + b;
        }
    }
}