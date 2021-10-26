//Guilherme adora brincar com pipas, pipas de várias cores, formas e tamanhos. 
//Ele tem percebido que para as pipas possuírem maior estabilidade, e 
//dessa forma voarem mais alto, elas devem possuir um barbante bem esticado 
//ligando todos os pares de pontas não vizinhas.

//Apesar de ser uma criança bastante criativa e astuta, 
//Guilherme não sabe como determinar a quantidade de barbantes que ele terá que 
//utilizar para tornar uma pipa de n lados, estável. Você pode ajudá-lo?.

using System;

class GuilhermeSuasPipas
{
    static void Main(string[] args)
    {
        long n = long.Parse(Console.ReadLine());
        long resposta = (n * (n - 3)) / 2;

        Console.WriteLine(resposta);
    }
}

/*
 using System; 
 
class TESTE {
 
    static void Main(string[] args) { 
        long N = long.Parse(Console.ReadLine());
        long resposta = (          )) /      ;  //Digite sua lógica aqui
        Console.WriteLine(resposta);
    }
    
}
 */