using System;
using System.Globalization;

namespace BeecrowdProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declaração de variáveis para armazenar o raio e a área do círculo.
            double raio, area;

            // Lê o raio do círculo do console, usando o ponto como separador decimal.
            raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            // Calcula a área do círculo. A constante Pi é aproximada como 3.14159.
            area = 3.14159 * Math.Pow(raio, 2);

            // Imprime a área formatada para quatro casas decimais.
            Console.WriteLine($"A={area.ToString("F4", CultureInfo.InvariantCulture)}");
        }
    }
}
