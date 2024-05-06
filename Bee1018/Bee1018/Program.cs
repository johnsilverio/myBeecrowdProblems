using System;

namespace Bee1018
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int valorInteiro = int.Parse(Console.ReadLine());
            
            Console.WriteLine(valorInteiro);

            int valor100 = valorInteiro / 100;
            valorInteiro %= 100;
            Console.WriteLine($"{valor100} nota(s) de R$ 100,00");
            
            int valor50 = valorInteiro / 50;
            valorInteiro %= 50;
            Console.WriteLine($"{valor50} nota(s) de R$ 50,00");

            int valor20 = valorInteiro / 20;
            valorInteiro %= 20;
            Console.WriteLine($"{valor20} nota(s) de R$ 20,00");
            
            int valor10 = valorInteiro / 10;
            valorInteiro %= 10;
            Console.WriteLine($"{valor10} nota(s) de R$ 10,00");
            
            int valor5 = valorInteiro / 5;
            valorInteiro %= 5;
            Console.WriteLine($"{valor5} nota(s) de R$ 5,00");
            
            int valor2 = valorInteiro / 2;
            valorInteiro %= 2;
            Console.WriteLine($"{valor2} nota(s) de R$ 2,00");
            
            int valor1 = valorInteiro / 1;
            valorInteiro %= 1;
            Console.WriteLine($"{valor1} nota(s) de R$ 1,00");
        }
    }
}