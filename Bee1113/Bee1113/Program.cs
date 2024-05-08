using System;

namespace Bee1113
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int X, Y;
            string[] valores = Console.ReadLine().Split(' ');
            X = int.Parse(valores[0]);
            Y = int.Parse(valores[1]);

            while (X != Y)
            {
                if (X < Y)
                {
                    Console.WriteLine("Crescente");
                }
                else
                {
                    Console.WriteLine("Decrescente");
                }
                valores = Console.ReadLine().Split(' ');
                X = int.Parse(valores[0]);
                Y = int.Parse(valores[1]);
            }
        }
    }
}