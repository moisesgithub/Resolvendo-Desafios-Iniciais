﻿/*
Leia quatro valores inteiros A, B, C e D. A seguir, calcule e 
mostre a diferença do produto de A e B pelo produto de C e D 
segundo a fórmula: DIFERENCA = (A * B - C * D).
*/
using System;

namespace DIFERENCA
{
    class Program
    {
        static void Main(string[] args)
        {
            int A, B, C, D, DIFERENCA;

            A = int.Parse(Console.ReadLine());
            B = int.Parse(Console.ReadLine());
            C = int.Parse(Console.ReadLine());
            D = int.Parse(Console.ReadLine());

            DIFERENCA = A * B - C * D;
            Console.WriteLine("DIFERENCA = " + DIFERENCA);
        }
    }
}
