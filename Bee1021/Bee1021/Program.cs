using System;
using System.Globalization;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;
            
            double valor = double.Parse(Console.ReadLine());

            int[] notas = { 100, 50, 20, 10, 5, 2 };
            double[] moedas = { 1, 0.50, 0.25, 0.10, 0.05, 0.01 };
            
            Console.WriteLine("NOTAS:");
            foreach (int nota in notas)
            {
                int quantidadeNotas = (int)(valor / nota);
                Console.WriteLine($"{quantidadeNotas} nota(s) de R$ {nota:F2}");
                valor %= nota;
                valor = Math.Round(valor, 2);
            }

            
            Console.WriteLine("MOEDAS:");
            foreach (double moeda in moedas)
            {
                int quantidadeMoedas = (int)(valor / moeda);
                Console.WriteLine($"{quantidadeMoedas} moeda(s) de R$ {moeda:F2}");
                valor %= moeda;
                valor = Math.Round(valor, 2);
            }
        }
    }
}