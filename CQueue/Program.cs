using System;
using System.Collections;
using System.Collections.Generic;

namespace CQueue
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercício 2 - Pessoa");

            Queue<Pessoa> pessoas = new Queue<Pessoa>();

            pessoas.Enqueue(new Pessoa("Louise"));
            pessoas.Enqueue(new Pessoa("Tania"));
            pessoas.Enqueue(new Pessoa("Ricardo"));
            pessoas.Enqueue(new Pessoa("Ana"));
            pessoas.Enqueue(new Pessoa("Thais"));

            Console.WriteLine($"O primeiro da fila é: {pessoas.Dequeue()}");

            pessoas.Peek();

            Console.WriteLine($"O numero de pessoas na Fila é: {pessoas.Count}");


            foreach (Pessoa pessoa in pessoas)
            {
                Console.WriteLine(pessoa.ToString());
            }

        }

        public class Pessoa
        {
            public string Nome { get; set; }

            public Pessoa(string nome) //construtor
            {
                Nome = nome;
            }

            public override string ToString()
            {
                return $"Nome: {Nome}";
            }
        }
    }
}
