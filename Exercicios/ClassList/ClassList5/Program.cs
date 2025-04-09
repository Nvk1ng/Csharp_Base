using System;
using System.Globalization;

namespace ClassList5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Aluno n = new Aluno();

            Console.Write("Digite o nome do aluno: ");
            n.Nome = Console.ReadLine();
            Console.WriteLine("Digite as tres notas do aluno : ");
            n.PirmeiroTrimestre = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            n.SegundoTrimestre = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            n.TerceiroTrimestre = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("NOTA FINAL = " + n.NotaFinal().ToString("F2", CultureInfo.InvariantCulture));

            if(n.Aprovado()){
                Console.WriteLine("APROVADO");
            }
            else{
                Console.WriteLine("REPROVADO");
                Console.WriteLine("FALTARAM " + n.NotaRestante().ToString("F2", CultureInfo.InvariantCulture) + " PONTOS");
            }
        }
    }
}