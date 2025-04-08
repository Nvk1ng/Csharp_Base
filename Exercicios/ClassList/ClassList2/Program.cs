using System;
using System.Globalization;
using System.Runtime.CompilerServices;

namespace ClassList2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoa p1 = new Pessoa();
            Pessoa p2 = new Pessoa();

            Console.WriteLine("Digite o nome da primeira pessoa: ");
            p1.Nome = Console.ReadLine();
            Console.WriteLine("Digite o salario d primeira pessoa: ");
            p1.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Digite o nome da segunda pessoa: ");
            p2.Nome = Console.ReadLine();
            Console.WriteLine("Digite o salario da segunda pessoa: ");
            p2.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double mediaSalario = (p1.Salario + p2.Salario) / 2.0;

            Console.WriteLine("Salario médio: " + mediaSalario.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}