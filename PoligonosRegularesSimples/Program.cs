//A entrada tem dois inteiros positivos: N e L, que são, respectivamente, 
//o número de lados e o comprimento de cada lado de um polígono 
//regular (3 ≤ N ≤ 1000000 and 1 ≤ L ≤ 4000).

using System;

namespace PoligonosRegularesSimples
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] v = Console.ReadLine().Split(' ');

            Console.WriteLine(int.Parse(v[0]) * int.Parse(v[1]));
        }
    }
}

/*
 using System; 

class Problem 
{
    static void Main(string[] args) 
    { 
        string[] v = Console.ReadLine().Split(' ');
        
        int N = int.Parse(v[0]);
        int L = int.Parse(v[1]);

        Console.WriteLine(N * L);
    }
}
 */