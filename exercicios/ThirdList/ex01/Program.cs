using System;
using System.Drawing;
using System.Runtime.ConstrainedExecution;

namespace ex01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Escreva um programa que repita a leitura de uma senha até que ela seja válida. Para cada leitura de senha
            incorreta informada, escrever a mensagem "Senha Invalida".Quando a senha for informada corretamente deve ser
            impressa a mensagem "Acesso Permitido" e o algoritmo encerrado.Considere que a senha correta é o valor 2002.*/

            Console.WriteLine("Digite a senha correta: ");

            int password = int.Parse(Console.ReadLine());

            while (password != 202)
            {
                Console.WriteLine("Senha invalida");
                Console.WriteLine("Digite a senha correta: ");
                password = int.Parse(Console.ReadLine());

            }

            Console.WriteLine("Acesso permitido");
        }

    }
}