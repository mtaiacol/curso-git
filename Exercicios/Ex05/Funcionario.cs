namespace Ex05
{
    class Funcionario
    {

        public string Nome;
        public double SalarioBruto;
        public double Imposto;

        public double SalarioLiquido()
        {
            return SalarioBruto - Imposto;
        }

        public void AumentarSalario(double Perc)
        {
            SalarioBruto += SalarioBruto * (Perc / 100);
        }

        public override string ToString()
        {
            return $"{Nome}, R${SalarioLiquido()}";
        }
    }
}
