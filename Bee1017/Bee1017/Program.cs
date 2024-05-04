using System;
using System.Globalization;

namespace Bee1017
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tempoGastoEmHoras = int.Parse(Console.ReadLine());
            int velociadeMedia = int.Parse(Console.ReadLine());
            double litrosGastros = (tempoGastoEmHoras * velociadeMedia) / 12.00;
            
            Console.WriteLine(litrosGastros.ToString("F3"), CultureInfo.InvariantCulture);
        }
    }
}