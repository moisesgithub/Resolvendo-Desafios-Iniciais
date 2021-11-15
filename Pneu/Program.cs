/*
Leia 2 valores de ponto flutuante de dupla precisão A e B, 
que correspondem a 2 notas de um aluno. A seguir, calcule a média do aluno, 
sabendo que a nota A tem peso 3.5 e a nota B tem peso 7.5 (A soma dos pesos portanto é 11). 
Assuma que cada nota pode ir de 0 até 10.0, sempre com uma casa decimal.
*/
using System;
class Media
{
    static void Main(string[] args)
    {
        double a, b, mediaP;

        a = double.Parse(Console.ReadLine());
        b = double.Parse(Console.ReadLine());

        mediaP = (a * 3.5 + b * 7.5) / 11;

        Console.WriteLine("MEDIA = " + mediaP.ToString("0.00000"));
    }
}