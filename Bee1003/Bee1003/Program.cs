using System;
using System.Globalization;

namespace BeecrowdProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            // O nome das variáveis conforme o padrão proposto no enunciado.
            int A, B, soma;
            A = int.Parse(Console.ReadLine());
            B = int.Parse(Console.ReadLine());
            soma = A + B;

            Console.WriteLine($"SOMA = {soma}");
        }
    }
}