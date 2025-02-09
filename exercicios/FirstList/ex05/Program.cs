using System;
using System.Globalization;

namespace ex05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*  
            Fazer um programa para ler o código de uma peça 1, o número de peças 1, o valor unitário de cada peça 1, o 
            código de uma peça 2, o número de peças 2 e o valor unitário de cada peça 2. Calcule e mostre o valor a ser pago
            */

            Console.WriteLine("Digite o codigo da peça 1, o numero de peças e o valor unitario de cada peça");
            string[] peca1 = Console.ReadLine().Split(' ');
            int codigo1 = int.Parse(peca1[0]);
            int numero1 = int.Parse(peca1[1]);
            double valor1 = double.Parse(peca1[2]);

            Console.WriteLine("Digite o codigo da peça 2, o numero de peças e o valor unitario de cada peça");
            string[] peca2 = Console.ReadLine().Split(' ');
            int codigo2 = int.Parse(peca2[0]);
            int numero2 = int.Parse(peca2[1]);
            double valor2 = double.Parse(peca2[2]);

            double total = (numero1 * valor1) + (numero2 * valor2);

            Console.WriteLine("O valor total da sua compra foi R$" + total.ToString("F3", CultureInfo.InvariantCulture));





        }
    }
}