using System;
using System.Globalization;

namespace Exercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            string produto1 = "Computador";
            string produto2 = "Mesa de Escritório";

            byte idade = 30;
            int codigo = 5290;
            char genero = 'M';

            double preco1 = 2100;
            double preco2 = 650.5;
            double medida = 53.234567;


            Console.WriteLine("Produtos: ");
            Console.WriteLine($"{produto1}, cujo preço é {preco1:F2}");
            Console.WriteLine($"{produto2}, cujo preço é {preco2:F2}");
            Console.WriteLine("");
            Console.WriteLine($"Registro: {idade} de idade, Código: {codigo} e Gênero: {genero}");
            Console.WriteLine("");
            Console.WriteLine($"Medida com oito Casas Decimais: {medida:F8}");
            Console.WriteLine($"Arredondado (Três Casas Decimais): {medida:F3}");
            Console.WriteLine("Separador Decimal Invariant Culture: " + medida.ToString("F3", CultureInfo.InvariantCulture ));

        }
    }
}
