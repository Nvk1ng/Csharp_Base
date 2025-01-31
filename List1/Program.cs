using System;
using System.Globalization;

namespace List1
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

            /* 
               Faça um programa para ler dois valores inteiros, e depois mostrar na tela a soma desses números com uma 
               mensagem explicativa, conforme exemplos. 
            */


            /*  
            Faça um programa para ler o valor do raio de um círculo, e depois mostrar o valor da área deste círculo com quatro 
            casas decimais conforme exemplos. 
            Fórmula da área: area = π . raio2 
            Considere o valor de π = 3.14159 
            */

            /*
            Fazer um programa para ler quatro valores inteiros A, B, C e D. A seguir, calcule e mostre a diferença do produto 
            de A e B pelo produto de C e D segundo a fórmula: DIFERENCA = (A * B - C * D).
            */

            /* 
            Fazer um programa que leia o número de um funcionário, seu número de horas trabalhadas, o valor que recebe por 
            hora e calcula o salário desse funcionário. A seguir, mostre o número e o salário do funcionário, com duas casas 
            decimais. 
            */

            /*  
            Fazer um programa para ler o código de uma peça 1, o número de peças 1, o valor unitário de cada peça 1, o 
            código de uma peça 2, o número de peças 2 e o valor unitário de cada peça 2. Calcule e mostre o valor a ser pago
            */

            /* Fazer um programa que leia três valores com ponto flutuante de dupla precisão: A, B e C. Em seguida, calcule e 
            mostre:  
            a) a área do triângulo retângulo que tem A por base e C por altura.  
            b) a área do círculo de raio C. (pi = 3.14159)  
            c) a área do trapézio que tem A e B por bases e C por altura.  
            d) a área do quadrado que tem lado B.  
            e) a área do retângulo que tem lados A e B. 
            */




        }
    }
}