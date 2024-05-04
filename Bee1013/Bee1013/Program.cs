using System;

namespace Bee1013
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] valores = Console.ReadLine().Split(" ");
            int a, b, c;
            a = int.Parse(valores[0]);
            b = int.Parse(valores[1]);
            c = int.Parse(valores[2]);
            int maiorAB = ((a + b) + Math.Abs(a - b)) / 2;
            int maior = (maiorAB + c + Math.Abs(maiorAB - c)) / 2;
            Console.WriteLine($"{maior} eh o maior");
        }
    }
}