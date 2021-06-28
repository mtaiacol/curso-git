using System;

namespace Ex03
{
    class Program
    {
        static void Main(string[] args)
        {
            int MovEstoque;

            Console.WriteLine("*** Controle de Estoque ***");
            Produto p = new();

            Console.Write("Informe o Nome do Produto: ");
            p.Nome = Console.ReadLine();

            Console.Write("Informe o Preço do Produto: ");
            p.Preco = double.Parse(Console.ReadLine());

            Console.Write("Informe a Quantidade do Produto: ");
            p.Qtde = int.Parse(Console.ReadLine());

            Console.WriteLine(p);

            Console.WriteLine();

            Console.Write("Informe a Quantidade do Produto a ser Adicionado no Estoque: ");
            MovEstoque = int.Parse(Console.ReadLine());

            p.AdicionarProdutos(MovEstoque);

            Console.WriteLine(p);

            Console.WriteLine();

            Console.Write("Informe a Quantidade do Produto a ser Removido no Estoque: ");
            MovEstoque = int.Parse(Console.ReadLine());

            p.RemoverProdutos(MovEstoque);

            Console.WriteLine(p);
        }
    }
}
