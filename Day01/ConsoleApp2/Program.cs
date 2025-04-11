using System;

namespace ConsoleApp2

{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Entradada de dados pelo usuario tipo string  

            string frase = Console.ReadLine();
            
            string x = Console.ReadLine();
            string y = Console.ReadLine();
            string z = Console.ReadLine();

            string[] vet = Console.ReadLine().Split(' ');
            string a = vet[0];
            string b = vet[1];
            string c = vet[2];


            Console.WriteLine("-----------------------");
            Console.WriteLine("Voce Digitou:");
            Console.WriteLine(frase);
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);
            Console.WriteLine($"{a} {b} {c}");


           

        }
    }
}