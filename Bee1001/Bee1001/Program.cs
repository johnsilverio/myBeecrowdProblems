using System;

namespace BeecrowdProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declaração e leitura de dois números inteiros do console.
            int A = int.Parse(Console.ReadLine());
            int B = int.Parse(Console.ReadLine());

            // Calcula a soma dos dois números.
            int X = A + B;

            // Exibe o resultado da soma formatado.
            Console.WriteLine($"X = {X}");
        }
    }
}