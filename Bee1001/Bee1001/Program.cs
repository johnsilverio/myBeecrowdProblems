﻿using System;

namespace BeecrowdProbles
{
    class Program
    {
        static void Main(string[] args)
        {
            int A, B;
            A = int.Parse(Console.ReadLine());
            B = int.Parse(Console.ReadLine());
            int X = A + B;

            Console.WriteLine($"X = {X}");
        }
    }
}