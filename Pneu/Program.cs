//Desenvolva um programa que leia um valor inteiro n. 
//Este n refere-se à quantidade de linhas de saída que 
//serão apresentadas na execução do programa.

using System;

namespace TESTE 
{
    class Program 
    {
        static void Main(string[] args) 
        {
           int N = int.Parse(Console.ReadLine());
           
           for (int i = 1; i <= N *4; i++)
           {
               if (i % 4 == 0)
               {
                   Console.WriteLine("PUM");
               }
               else
               {
                   Console.WriteLine("P");
               }
           } 
        }
    }
}
