using System;
using System.Globalization;

namespace Exercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com seu nome Completo:");
            string nome = Console.ReadLine();

            Console.WriteLine("Quantos Quartos tem sua Casa?");
            int QtdeQuartos = int.Parse(Console.ReadLine());

            Console.WriteLine("Entre com o preço de um Produto:");
            double preco = double.Parse(Console.ReadLine());

            Console.WriteLine("Entre com seu último nome, idade e altura (mesma linha):");
            string[] cadpessoa  = Console.ReadLine().Split(" ");


            Console.WriteLine($"Seu Nome Completo é: {nome}!");
            Console.WriteLine($"Sua casa tem {QtdeQuartos} Quartos!");
            Console.WriteLine($"Seu produto custa R${preco:F2}! ");
            Console.WriteLine($"Suas informações de Cadastro são: Sobrenome: {cadpessoa[0]}, Vc tem {cadpessoa[1]} anos de Idade e tem {cadpessoa[2]:F2} m. de Altura!");

            

        }
    }
}
