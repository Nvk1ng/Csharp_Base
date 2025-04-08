using System;

namespace ex02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Fazer um programa para ler um número inteiro e dizer se este número é par ou ímpar. 

            Console.WriteLine("Digite um numero inteiro");
            int num1 = int.Parse(Console.ReadLine());

            if (num1 % 2 == 0)
            {
                Console.WriteLine("É PAR!!");
            }
            else
            {
                Console.WriteLine("É IMPAR!!");
            }

        }
    }
}