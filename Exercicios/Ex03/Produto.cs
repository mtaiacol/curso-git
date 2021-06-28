using System.Globalization;

namespace Ex03
{
    class Produto
    {
        public string Nome;
        public double Preco;
        public int Qtde;

        public double ValorTotalemEstoque() { return Qtde * Preco; }

        public void AdicionarProdutos(int add) => Qtde += add;

        public void RemoverProdutos(int del) => Qtde -= del;

        public override string ToString()
        {
            return $"O Produto {Nome}, " +
                $"tem Preço de R${Preco.ToString("F2", CultureInfo.InvariantCulture)}, " +
                $"tem Estoque de {Qtde.ToString("F2", CultureInfo.InvariantCulture)} Peças, " +
                $"e um valor total de Estoque de R${ValorTotalemEstoque().ToString("F2", CultureInfo.InvariantCulture)}! ";
        }
    }
}
