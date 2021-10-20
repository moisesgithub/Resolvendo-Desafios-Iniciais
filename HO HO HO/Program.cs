using System;

namespace HO_HO_HO
{
    class Program
    {
        static void Main(string[] args)
        {
            _ = int.TryParse(Console.ReadLine(), out int n);

            for (int i = 0; i < n - 1; i++)
            {
                Console.Write("Ho ");
            }
            if (n != 0)
            {
                Console.WriteLine("Ho!");
            }            
        }
    }
}

/*
 using System;

namespace _52._36_URI_1759 {
    class Program {
        static void Main(string[] args) {
           
            int N = int.Parse(Console.ReadLine());

            //Exibir "Ho" do papai noel
            for (int i = 0; i < N; i++) {
                if (             ) {
                    Console.Write("Ho ");                  //Complete o código no espaço em branco
                }
                else{
                    Console.WriteLine("Ho!");
                }
            }
        }
    }
}
 */
