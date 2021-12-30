/*
Escreva um algoritmo para calcular e escrever o valor de S, sendo S dado pela fórmula:
S = 1 + 1/2 + 1/3 + … + 1/100

Entrada
Não há nenhuma entrada neste problema.

Saída
A saída contém um valor correspondente ao valor de S.
O valor deve ser impresso com dois dígitos após o ponto decimal.
*/
using System;

class DIO
{
    static void Main(string[] args)
    {
        double s = 0;
        for (int i = 1; i <= 100; i++)
        {
            s += 1.0 / i;
        }
        Console.WriteLine("{0:0.00}", s);
    }
}
/*
using System; 

class DIO {

    static void Main(string[] args) { 

      double a, c, S= 0;
            for (      )
            {
                c =           ;  //coloque a sua lógica nos espaços em branco
                S +=        ;
            }
            var x=Math.Round(S,2);
            Console.WriteLine(      );

    }

}
*/