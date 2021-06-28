using System;

namespace Lista1Ex2
{
    class Program
    {
        static void Main(string[] args)
        {

            double raio;

            Console.Write("Informe o Raio da Circunferência: ");

            raio = double.Parse(Console.ReadLine());

            Console.WriteLine($"A Área do Círculo de Raio {raio:F4} cm, é: {Math.PI * Math.Pow(raio, 2):F4} cm2!");

        }
    }
}
