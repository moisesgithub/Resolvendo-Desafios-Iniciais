using System;

class MaiorPosicao
{
    static void Main(string[] args)
    {
        int num;
        int maior = 0;
        int posicao = 0;
        for (int i = 1; i <= 100; i++)
        {
            num = Convert.ToInt32(Console.ReadLine());
            if (num > maior)
            {
                maior = num;
                posicao = i;
            }
        }
        Console.WriteLine(maior);
        Console.WriteLine(posicao);
    }
}

/*
 using System; 

class TESTE {

    static void Main(string[] args) { 

            int n;
            int maior = 0;
            int posicao = 0;
            for(int i = 1; i <= 100 ; i++)
            {
                n = Convert.ToInt32(Console.ReadLine());
                if(n > maior)
                {
                    maior =           ;
                    posicao =       ;     //Complete o código nos espaços em branco
                } 
            }
            Console.WriteLine(maior);
            Console.WriteLine(posicao);

    }

}
 */