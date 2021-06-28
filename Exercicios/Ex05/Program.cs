using System;

namespace Ex05
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario Func = new();
            Console.WriteLine("*** Informe os Dados do Funcionário ***");
            Console.WriteLine();

            Console.Write("Nome: "); 
            Func.Nome = Console.ReadLine();

            Console.Write("Salário Bruto: "); 
            Func.SalarioBruto = double.Parse(Console.ReadLine());

            Console.Write("Imposto sobre Salário: "); 
            Func.Imposto = double.Parse(Console.ReadLine());

            Console.WriteLine(); Console.WriteLine();

            Console.WriteLine($"Funcionário: {Func}");

            Console.WriteLine();

            Console.Write("Informe a Porcentagem de Aumento sobre o Salário: "); 
            double Perc = double.Parse(Console.ReadLine());

            Func.AumentarSalario(Perc);

            Console.WriteLine($"Funcionário Atualizado: {Func}");
        }
    }
}
