using System;
using System.Globalization;

namespace Ex07
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** Calculadora de Dólar ***");
            Console.WriteLine();

            Calculadora Calc = new();

            Console.Write("Informe a cotação do Dólar: ");
            Calc.Dolar = double.Parse(Console.ReadLine());
            
            Console.Write("Quantos Dólares deseja comprar? ");
            Calc.Qtde = double.Parse(Console.ReadLine());

            Console.Write($"Valor a pagar em Reais: {Calc.CalcularDolar.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
