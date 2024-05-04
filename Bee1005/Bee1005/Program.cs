using System;
using System.Globalization;

namespace Bee1005
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double pesoA = 3.5;
            double pesoB = 7.5;
            double A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double media = ((A * pesoA) + (B * pesoB)) / (pesoA + pesoB);
            
            Console.WriteLine($"MEDIA = {media.ToString("F5", CultureInfo.InvariantCulture)}");
        }
    }
}