using System;

namespace Intervalo2
{
    class Program
    {
        static void Main(string[] args)
        {
            int tc, a, i;

            int Interval = 0;
            int outInterval = 0;

            tc = int.Parse(Console.ReadLine());

            for (i = 0; i < tc; i++)
            {
                a = int.Parse(Console.ReadLine());

                if (a == 1)
                {
                    Interval++;
                }
                else
                {
                    outInterval++;
                }
            }
            Console.WriteLine("{0} in", Interval);
            Console.WriteLine("{0} out", outInterval);
            Console.ReadLine();
        }
    }    
}

/*
 using System; 

class TESTE {

        public static void Main()
        {
           
            int tc, a, i;

            int Interval = 0;
            int outInterval = 0;

            tc = int.Parse(Console.ReadLine());

            for (i = 0; i < tc; i++)
            {
                a = int.Parse(Console.ReadLine());

                if (                           )
                {
                                   ; 
                }
                else                           //Insira sua lógica nos espaços em branco
                {
                                    ;
                }

            }
            Console.WriteLine("{0} in", Interval);
            Console.WriteLine("{0} out", outInterval);


            Console.ReadLine();
        }
}
 */