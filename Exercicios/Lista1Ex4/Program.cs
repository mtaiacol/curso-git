using System;

namespace Lista1Ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o Código do Funcionário, as Horas Trabalhadas e o Valor Hora, separador por Barra(/)!");

            string[] func = Console.ReadLine().Split("/");

            Console.Write(Msg(int.Parse(func[0])) + Salario(double.Parse(func[1]), double.Parse(func[2])));

        }

        static string Msg (int CodFunc)
        {
            return $"O Funcionário Código {CodFunc} Receberá um Salário de ";
        }

        static double Salario (double hora, double valorhora)
        {
            return hora * valorhora;
        }
    }
}
