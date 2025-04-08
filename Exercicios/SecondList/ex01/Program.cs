using System;

namespace ex01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Fazer um programa para ler um número inteiro, e depois dizer se este número é negativo ou não. 

            Console.WriteLine("Ditie um numero inteiro: ");
            int num1 = int.Parse(Console.ReadLine());

            if (num1 >= 0)
            {
                Console.WriteLine("Inteiro!");
            }
            else
            {
                Console.WriteLine("Negativo");
            }
        }
    }
}