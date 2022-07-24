using System;
using System.Collections.Generic;
using static CQueue.Program;

namespace CStack
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercício 3 - Livros");

            Stack<string> livros = new Stack <string>();

            livros.Push("Livro Harry Potter");
            livros.Push("Livro Senhor dos Anéis");
            livros.Push("Livro Jogos Vorazes");
            Console.WriteLine();

            foreach (String livro in livros)
            {
                Console.WriteLine($"{livro.ToString()}");
            }

            Console.WriteLine();
            Console.WriteLine($"Primeiro livro: {livros.Peek()}");
            Console.WriteLine();

            livros.Pop();
            Console.WriteLine();

            foreach (String livro in livros)
            {
                Console.WriteLine($"{livro.ToString()}");
            }

            Console.WriteLine();
            Console.WriteLine($"Qtd livros {livros.Count}");
            Console.WriteLine();

        }
    }
}
