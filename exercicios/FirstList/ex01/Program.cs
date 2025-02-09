using System;
using System.Globalization;

namespace ex01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Fazer um programa para executar  a seguinte interação com o usuário, lendo valores destacados em vermelho e depois mostrados na tela
             * Entre com seu nome completo: 
             * ALEX GREEN
             * quantos quartos tem a sua casa:
             * 3
             * Entre com o preço do produto:
             * 500.50
             * Entre com seu ultimo nome, idade e altura (mesma linha):
             * Grenn 21 1.73*/

            Console.WriteLine("Entre com o seu nome completo: ");
            string name = Console.ReadLine();

            Console.WriteLine("Quantos quartos tem na sua casa: ");
            int rooms = int.Parse(Console.ReadLine());

            Console.WriteLine("Entre com o preço do produto: ");
            float preco = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre com o seu ultimo nome, idade e altura: ");
            string[] vet = Console.ReadLine().Split(' ');
            string lastname = vet[0];
            int age = int.Parse(vet[1]);
            double height = double.Parse(vet[2], CultureInfo.InvariantCulture);

            Console.WriteLine(name);
            Console.WriteLine(rooms);
            Console.WriteLine(preco);
            Console.WriteLine($"{lastname} {age} {height}");
        }
    }
}