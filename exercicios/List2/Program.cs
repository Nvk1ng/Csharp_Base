using System;

namespace List2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 
               Faça um programa para ler dois valores inteiros, e depois mostrar na tela a soma desses números com uma 
               mensagem explicativa, conforme exemplos. 
            */
            Console.WriteLine("Digite o primeiro numero inteiro: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo numero inteiro: ");
            int num2 = int.Parse(Console.ReadLine());

            int sum = num1 + num2;

            Console.WriteLine($"A some de {num1} + {num2} = {sum}");
        }

    }
}