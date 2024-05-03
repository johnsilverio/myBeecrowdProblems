using System;
using System.Globalization;

namespace BeecrowdProblems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numeroDeFuncionario, numeroDeHorasTrabalhadas;
            double valorRecebidoHora, salario;
            Console.WriteLine("Numero de cadastro:");
            numeroDeFuncionario = int.Parse(Console.ReadLine());
            Console.WriteLine("Numero de horas trabalhadas:");
            numeroDeHorasTrabalhadas = int.Parse(Console.ReadLine());
            Console.WriteLine("Valor recebido por horas:");
            valorRecebidoHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            salario = numeroDeHorasTrabalhadas * valorRecebidoHora;

            Console.WriteLine($"NUMBER = {numeroDeFuncionario}");
            Console.WriteLine($"SALARY = U$ {salario.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}