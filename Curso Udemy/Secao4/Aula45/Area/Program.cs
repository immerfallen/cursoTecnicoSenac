using System;
using System.Globalization;

namespace Area
{
    class Program
    {
        static void Main(string[] args)
        {
           Area retangulo = new Area();

           Console.WriteLine("Entre com a altura e a largura do retângulo:");

           retangulo.altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture );
           retangulo.largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture );

           Console.WriteLine("A área do retângulo é de: " + retangulo.AreaTotal().ToString("F2",CultureInfo.InvariantCulture));
           Console.WriteLine("O perímetro do retângulo é de: " + retangulo.Perimetro().ToString("F2",CultureInfo.InvariantCulture));
        }
    }
}
