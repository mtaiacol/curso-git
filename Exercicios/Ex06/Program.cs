using System;

namespace Ex06
{
    class Program
    {
        static void Main(string[] args)
        {

            Aluno Aluno = new();

            Console.Write("Informe o Nome do Aluno: ");
            Aluno.Nome = Console.ReadLine();
            Console.WriteLine();

            for (int i = 0; i < 3; i++)
            {
                Console.Write($"Informe a {i + 1}ª Nota do Aluno: ");
                Aluno.Nota[i] = double.Parse(Console.ReadLine());
            }
            Console.WriteLine();

            Console.WriteLine(Aluno);

        }
    }
}