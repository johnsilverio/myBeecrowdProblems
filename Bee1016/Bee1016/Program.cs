using System;

namespace Bee1016
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int distanciaKm = int.Parse(Console.ReadLine());
            distanciaKm *= 2;
            Console.WriteLine($"{distanciaKm} minutos");
        }
    }
}
