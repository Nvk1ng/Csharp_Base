﻿namespace ConsoleApp13{
    class Program{
        static void Main(string[] args){

            Produto p = new Produto("TV", 500.00, 10);

            p.Nome = "TV 4K";

            Console.WriteLine(p.Nome);
            Console.WriteLine(p.Preco);
        }
    }
}