using System;

namespace S05_Ex01
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente CC;
            Console.WriteLine("*** Banco Digital ***");
            Console.WriteLine();

            Console.Write("Informe o Número da Conta: ");
            int NumCC = int.Parse(Console.ReadLine());

            Console.Write("Informe o Titular da Conta: ");
            string NomeTitular = Console.ReadLine();

            Console.Write("Haverá Depósito Inicial (s/n)?: ");
            char Depositar = char.Parse(Console.ReadLine());

            if (char.ToUpper(Depositar) == 'N')
            {
                CC = new(NomeTitular, NumCC);
                Console.WriteLine();
            }
            else
            {
                Console.Write("Informe o Valor do Depósito Inicial: ");
                double DepIni = double.Parse(Console.ReadLine());

                CC = new(NomeTitular, NumCC, DepIni);
                Console.WriteLine();
            }

            Console.WriteLine(CC);
            Console.WriteLine();

            Console.Write("Informe o Valor do Depósito: ");
            CC.FazerDeposito(double.Parse(Console.ReadLine()));
            
            Console.WriteLine();
            Console.WriteLine("Dados da Conta Atualizado");
            Console.WriteLine(CC);
            Console.WriteLine();

            Console.Write("Informe o Valor do Saque: ");
            CC.FazerSaque(double.Parse(Console.ReadLine()));

            Console.WriteLine();
            Console.WriteLine("Dados da Conta Atualizado");
            Console.WriteLine(CC);
            Console.WriteLine();
        }
    }
}