using System;
using System.Globalization;

namespace Ex04
{
    class Retangulo
    {
        public double Base, Altura;

        public double Area() => Base * Altura / 2;

        public double Perimetro() => Base + Altura + Hipotenusa();

        public double Hipotenusa() => Math.Sqrt(Math.Pow(Base, 2) + Math.Pow(Altura, 2));

        public override string ToString()
        {
            return $"O Triângulo informado tem Área de {Area().ToString("F4", CultureInfo.InvariantCulture)} cm2, " +
                   $"Perímetro de {Perimetro().ToString("F4", CultureInfo.InvariantCulture)} cm, " +
                   $"e sua Hipotenusa mede {Hipotenusa().ToString("F4", CultureInfo.InvariantCulture)}";
        }
    }
}