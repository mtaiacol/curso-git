using System;
using System.Collections.Generic;

namespace Sec06Ex02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** Cadastro de Funcionários ***");
            Console.WriteLine();

            Console.Write("Quantos Funcionário Serão Registrados: ");
            int QtdeFunc = int.Parse(Console.ReadLine());

            List<Funcionario> lstFunc = new List<Funcionario>();

            for (int i = 0; i < QtdeFunc; i++)
            {
                Console.WriteLine($"Funcionário #{i + 1}: ");
                Console.Write("ID: ");
                int Id = int.Parse(Console.ReadLine());

                Console.Write("Nome: ");
                string Nome = Console.ReadLine();
                Console.Write("Salário: ");
                double Salario = double.Parse(Console.ReadLine());

                lstFunc.Add(new Funcionario(Id, Nome, Salario));
                Console.WriteLine();
            }

            Console.Write("Informe o Funcionário que terá o Salário Aumentado: ");
            int FuncAum = int.Parse(Console.ReadLine());

            Console.Write("Informe a Porcentagem do Aumento: ");
            double Perc = double.Parse(Console.ReadLine());

            Funcionario Func = lstFunc.Find(x => x.Id == FuncAum);

            if (Func != null)
            {
                _ = Func.AumentarSalario(Perc);

                Console.WriteLine();
                Console.WriteLine("Lista de Funcionários Atualizada:");
                Console.WriteLine();

                for (int i = 0; i < QtdeFunc; i++)
                {
                    Console.WriteLine($"{lstFunc[i].Id}, {lstFunc[i].Nome}, {lstFunc[i].Salario}");
                }
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Funcionários não Localizado!");
                Console.WriteLine();
            }

        }
    }
}
