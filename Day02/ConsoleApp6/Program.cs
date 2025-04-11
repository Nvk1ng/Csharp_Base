using System;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quanto numeros inteiros voce vai digitar: ");
            int N = int.Parse(Console.ReadLine());

            int soma = 0;

            for (int i = 1; i <= N; i++)
            {
                Console.WriteLine($"valor #{i}: ");
                int valor = int.Parse(Console.ReadLine());
                soma += valor;
            }

            Console.WriteLine($"Soma igual: {soma}");
        }
    }
}