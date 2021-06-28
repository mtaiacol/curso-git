using System;

namespace Ex01
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa p1 = new();
            Pessoa p2 = new();

            Console.WriteLine("***Primeira Pessoa***");
            Console.Write("Informe o Nome:");
            p1.Nome = Console.ReadLine();
            Console.Write("Informe a Idade:");
            p1.Idade = int.Parse(Console.ReadLine());

            Console.WriteLine("***Segunda Pessoa***");
            Console.Write("Informe o Nome:");
            p2.Nome = Console.ReadLine();
            Console.Write("Informe a Idade:");
            p2.Idade = int.Parse(Console.ReadLine());

            Console.WriteLine($"Pessoa mais Velha:{p1.MaiorIdade(p1.Idade, p1.Nome, p2.Idade, p2.Nome)}");
        }
    }
}