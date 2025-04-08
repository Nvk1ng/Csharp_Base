using System;

namespace ex06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Fazer um programa que leia três valores com ponto flutuante de dupla precisão: A, B e C. Em seguida, calcule e 
            mostre:  
            a) a área do triângulo retângulo que tem A por base e C por altura.  
            b) a área do círculo de raio C. (pi = 3.14159)  
            c) a área do trapézio que tem A e B por bases e C por altura.  
            d) a área do quadrado que tem lado B.  
            e) a área do retângulo que tem lados A e B. 
            */

            double a, b, c, triangulo, circulo, trapezio, quadrado, retangulo;
            string[] vet = Console.ReadLine().Split(' ');
            a = double.Parse(vet[0]);
            b = double.Parse(vet[1]);
            c = double.Parse(vet[2]);

            triangulo = a * c / 2;
            circulo = 3.14159 * Math.Pow(c, 2);
            trapezio = (a + b) * c / 2;

            quadrado = Math.Pow(b, 2);
            retangulo = a * b;

            Console.WriteLine("TRIANGULO: " + triangulo.ToString("F3"));
            Console.WriteLine("CIRCULO: " + circulo.ToString("F3"));
            Console.WriteLine("TRAPEZIO: " + trapezio.ToString("F3"));
            Console.WriteLine("QUADRADO: " + quadrado.ToString("F3"));
            Console.WriteLine("RETANGULO: " + retangulo.ToString("F3"));
        }
    }
}