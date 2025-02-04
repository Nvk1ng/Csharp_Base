using System;
using System.Globalization;

namespace List3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*  
            Faça um programa para ler o valor do raio de um círculo, e depois mostrar o valor da área deste círculo com quatro 
            casas decimais conforme exemplos. 
            Fórmula da área: area = π . raio2 
            Considere o valor de π = 3.14159 
            */

            float pi = 3.14159f;
            Console.WriteLine("Digite o valor do raio do circulo: ");
            double raio = double.Parse(Console.ReadLine());

            double area = pi * Math.Pow(raio, 2);

            Console.WriteLine("o valor da area do circulo é igual a:" + area.ToString("F4", CultureInfo.InvariantCulture));


        }
    }
}