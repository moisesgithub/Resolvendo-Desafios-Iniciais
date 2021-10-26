//Desenvolva um programa para ler as coordenadas (M,N) 
//de uma quantidade indeterminada de pontos no sistema cartesiano. 
//Para cada ponto escrever o quadrante a que ele pertence. 
//O algoritmo será encerrado quando pelo menos uma de duas 
//coordenadas for NULA (nesta situação sem escrever mensagem alguma).

using System;

class TESTE
{
    public static void Main()
    {
        int x, y;
        while (true)
        {
            string[] s = Console.ReadLine().Split(' ');
            x = int.Parse(s[0]);
            y = int.Parse(s[1]);

            if (x == 0 || y == 0)
                break;
            else if (x > 0 && y > 0)
                Console.WriteLine("primeiro");
            else if (x > 0 && y < 0)
                Console.WriteLine("quarto");
            else if (x < 0 && y < 0)
                Console.WriteLine("terceiro");
            else if (x < 0 && y > 0)
                Console.WriteLine("segundo");
        }
        Console.ReadLine();
    }
}