//Escreva um programa que, dada a pressão desejada digitada 
//pelo motorista e a pressão do pneu lida pela bomba, 
//indica a diferença entre a pressão desejada e a pressão lida.
using System;

class TESTE
{
    static void Main()
    {
        int A = int.Parse(Console.ReadLine());
        int B = int.Parse(Console.ReadLine());

        if (A != B)
        {
            Console.WriteLine("{0}", A - B);
        }
        else
        {
            Console.WriteLine("{0}", B - A);
        }
    }
}
