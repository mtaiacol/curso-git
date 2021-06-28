using System;
using System.Globalization;

namespace Ex02
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario f1 = new();
            Funcionario f2 = new();

            Console.WriteLine("***Primeiro Funcionário***");
            Console.Write("Informe o Nome:");
            f1.Nome = Console.ReadLine();
            Console.Write("Informe o Salário:");
            f1.Salario = double.Parse(Console.ReadLine());

            Console.WriteLine("***Segundo Funcionário***");
            Console.Write("Informe o Nome:");
            f2.Nome = Console.ReadLine();
            Console.Write("Informe a Idade:");
            f2.Salario = double.Parse(Console.ReadLine());

            Console.WriteLine($"O Salário Médio é:{MediaSalario(f1.Salario,f2.Salario).ToString("F2",CultureInfo.InvariantCulture)}");
        }

        static double MediaSalario(double S1, double S2)
        {
            return (S1 + S2) / 2.0;
        }
    }
}
