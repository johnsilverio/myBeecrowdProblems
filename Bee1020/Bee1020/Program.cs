using System;

namespace  Bee1020
{
    internal class Program 
    {
        static void Main(string[] args)
        {
            int dias = int.Parse(Console.ReadLine());

            int idadeAno = dias / 365;
            dias %= 365;
            Console.WriteLine($"{idadeAno} ano(s)");
            
            int idadeMeses = dias / 30;
            dias %= 30;
            Console.WriteLine($"{idadeMeses} mes(es)");

            int idadeDias = dias;
            Console.WriteLine($"{idadeDias} dia(s)");
        }
    }
}