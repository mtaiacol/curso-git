using System.Globalization;


namespace Ex06
{
    class Aluno
    {
        public string Nome;
        public double[] Nota = new double[3];

        public bool AlunoAprovado()
        {
            return NotaFinal() >= 60;
        }

        public double NotaFinal()
        {
            return Nota[0] + Nota[1] + Nota[2];
        }

        public double QtoFalta()
        {         
            return 60 - NotaFinal();
        }

        public override string ToString()
        {
            return $"NOTA FINAL: {NotaFinal().ToString("F2", CultureInfo.InvariantCulture)} \n" +
                   $"{(AlunoAprovado() ? "APROVADO" : "REPROVADO")} \n" +
                   $"{(QtoFalta() > 0 ? "FALTARAM " : null)}" +
                   $"{(QtoFalta() > 0 ? QtoFalta().ToString("F2", CultureInfo.InvariantCulture) : null)}" +
                   $"{(QtoFalta() > 0 ? " PONTOS! " : null)}";
        }
    }
}