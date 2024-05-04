using System;
using System.Globalization;

namespace String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double R = double.Parse(Console.ReadLine());
            double volume = (4 / 3.0) * 3.14159 * Math.Pow(R, 3);
            Console.WriteLine($"VOLUME = {volume.ToString("F3", CultureInfo.InvariantCulture)}");
        }
    }
}