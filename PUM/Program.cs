using System;

namespace PUM
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            for (int i = 1; i <= N * 4; i++)
            {
                if (i % 4 != 0)
                {
                    Console.Write(i + " ");
                }
                else
                {
                    Console.Write("PUM\n");
                }
            }
        }
    }
}
/*
 using System;

namespace TESTE {
    class Program {
        static void Main(string[] args) {
        
            int N = int.Parse(Console.ReadLine());

            int primeiro = 1;
            for (int i = 1; i <= N; i++) {

               // Insira o seu código aqui


            }
        }
    }
}
 */