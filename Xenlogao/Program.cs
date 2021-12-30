/*
Entrada
A primeira linha consiste de um inteiro C que representa a quantidade 
de casos de teste. As linhas subsequentes contém um inteiro N (2 ≤ N ≤ 109) 
que representa a quantidade de esferas necessárias para invocar Xenlongão.

Saída
Seu programa deve exibir a quantidade mínima de esferas que Kogu tem que procurar.
*/
using System;

namespace Dio
{
    class Xenlongao
    {
        static void Main(string[] args)
        {
            int N;
            int C = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < C; i++)
            {
                N = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(N - (int)Math.Sqrt(N));
            }
        }
    }
}

/*
using System;
using System.Collections.Generic;
using System.Text;

namespace Dio
{
    class Xenlongao
    {
        static void Main(string[] args)
        {
            int N = Convert.ToInt32(Console.ReadLine());
            while(N-- > 0)
            {
                int val = ;
                int newval = ;          //complete com a sua lógica
                int resposta = ;
                Console.WriteLine(resposta);
            }
        }
    }
}
*/