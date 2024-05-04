using System;
using System.Globalization;

namespace Bee1006
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double pesoA, pesoB, pesoC;
            pesoA = 2;
            pesoB = 3;
            pesoC = 5;
            double A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double media = (((A * pesoA) + (B * pesoB) + (C * pesoC)) / (pesoA + pesoB + pesoC));
            
            Console.WriteLine($"MEDIA = {media.ToString("F1", CultureInfo.InvariantCulture)}");
        }
    }
}