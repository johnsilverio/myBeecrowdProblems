using System;
using System.Globalization;

namespace BeecrowdProblems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int A = int.Parse(Console.ReadLine());
            double B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double consumoMedio = A / B;

            Console.WriteLine($"{consumoMedio.ToString("F3", CultureInfo.InvariantCulture)} km/l");
        }
    }
}