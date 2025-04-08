using System;
using System.Globalization;

namespace ex04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 
            Fazer um programa que leia o número de um funcionário, seu número de horas trabalhadas, o valor que recebe por 
            hora e calcula o salário desse funcionário. A seguir, mostre o número e o salário do funcionário, com duas casas 
            decimais. 
            */

            Console.WriteLine("Digite o número do funcionário: ");
            int numero = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o número de horas trabalhadas: ");
            int horas = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor que recebe por hora: ");
            double valor = double.Parse(Console.ReadLine());

            double salario = horas * valor;
            Console.WriteLine("O seu numero é: " + numero + "E o seu salário é R$: " + valor.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}