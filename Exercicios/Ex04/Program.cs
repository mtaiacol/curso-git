using System;

namespace Ex04
{
    class Program
    {
        static void Main(string[] args)
        {
            Retangulo R = new();

            Console.Write("Informe a Base do Triângulo: ");
            R.Base = double.Parse(Console.ReadLine());

            Console.Write("Informe a Altura do Triângulo: ");
            R.Altura = double.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine(R);
        }
    }
}
