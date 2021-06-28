using System;

namespace Sec06Ex01
{
    class Program
    {
        static void Main(string[] args)
        {
            const int QtdeQuarto = 10;

            Console.Write("*** Hotel Virtual ***");
            Console.WriteLine(); 
            Console.WriteLine();

            Console.Write("Bem-Vindo! Quantos Quartos Deseja Alugar? (1 a 10): ");
            int n = int.Parse(Console.ReadLine());
            Quarto[] Q = new Quarto[QtdeQuarto];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine();
                Console.WriteLine($"Aluguel #{i + 1}");
                Console.Write("Nome: "); 
                string locatario = Console.ReadLine();
                Console.Write("E-Mail: "); 
                string email = Console.ReadLine();
                Console.Write("Quarto: "); 
                int numQuarto = int.Parse(Console.ReadLine());
                Q[numQuarto] = new Quarto { Locatario = locatario, Email = email };
            }

            Console.WriteLine(); Console.WriteLine("Quartos Alocados:"); Console.WriteLine();

            for (int i = 0; i < 10; i++)
                if (Q[i] != null)
                    Console.WriteLine($"{i}: {Q[i]}");
        }
    }
}