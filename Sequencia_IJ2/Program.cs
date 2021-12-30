/*
Você deve fazer um programa que apresente a sequencia conforme o exemplo abaixo.

Entrada
Não há nenhuma entrada neste problema.

Saída
Imprima a sequencia conforme exemplo abaixo:
I=1 J=7
I=1 J=6
I=1 J=5
I=3 J=7
I=3 J=6
I=3 J=5
I=5 J=7
I=5 J=6
I=5 J=5
I=7 J=7
I=7 J=6
I=7 J=5
I=9 J=7
I=9 J=6
I=9 J=5
*/
using System;

class DIO
{
    static void Main(string[] args)
    {
        foreach (int i in new int[] { 1, 3, 5, 7, 9 })
        {
            foreach (int j in new int[] { 7, 6, 5 })
            {
                Console.WriteLine("I={0} J={1}", i, j);
            }
        }
    }
}
/*
using System; 

class DIO {

    static void Main(string[] args) { 

       for(           )
            {
                for(        )    //escreva seu código nos espaços em branco
                {
                    Console.WriteLine(       );
                }
            }
    }

}
*/