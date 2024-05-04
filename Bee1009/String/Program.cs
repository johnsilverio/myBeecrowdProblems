using System;
using System.Globalization;
namespace String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome = Console.ReadLine();
            double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double vendasEmDinheiro = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double valorComissao = (vendasEmDinheiro * 0.15) + salario;
            Console.WriteLine($"TOTAL = R$ {valorComissao.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}