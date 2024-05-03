using System;
using System.Globalization;

namespace BeecrowdProblems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] peca1 = Console.ReadLine().Split(' ');
            int codigoPeca1 = int.Parse(peca1[0]);
            int numeroDePeca1 = int.Parse(peca1[1]);
            double valorDaPeca1 = double.Parse(peca1[2], CultureInfo.InvariantCulture);

            string[] peca2 = Console.ReadLine().Split(' ');
            int codigoPeca2 = int.Parse(peca2[0]);
            int numeroDePeca2 = int.Parse(peca2[1]);
            double valorDaPeca2 = double.Parse(peca2[2], CultureInfo.InvariantCulture);
            
            double valorAPagar = (numeroDePeca1 * valorDaPeca1) + (numeroDePeca2*valorDaPeca2);

            Console.WriteLine($"VALOR A PAGAR: R$ {valorAPagar.ToString("F2", CultureInfo.InvariantCulture)}");

        }
    }
}