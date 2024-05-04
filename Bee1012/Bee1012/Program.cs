using System;
using System.Globalization;

namespace Bee1012
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double A, B, C, areaTriangulo, areaCirculo, areaTrapezio, areaQuadrado, areaRetangulo;
            string vet = Console.ReadLine();
            string[] entrada = vet.Split(' ');
            A = double.Parse(entrada[0], CultureInfo.InvariantCulture);
            B = double.Parse(entrada[1], CultureInfo.InvariantCulture);
            C = double.Parse(entrada[2], CultureInfo.InvariantCulture);
            areaTriangulo = (A * C) / 2;
            areaCirculo = 3.14159 * Math.Pow(C, 2);
            areaTrapezio = (A + B) * C / 2.0;
            areaQuadrado = Math.Pow(B, 2);
            areaRetangulo = A * B;
            Console.WriteLine($"TRIANGULO: {areaTriangulo.ToString("F3", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"CIRCULO: {areaCirculo.ToString("F3", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"TRAPEZIO: {areaTrapezio.ToString("F3", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"QUADRADO: {areaQuadrado.ToString("F3", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"RETANGULO: {areaRetangulo.ToString("F3", CultureInfo.InvariantCulture)}");
        }
    }
}