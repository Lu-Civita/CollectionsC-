using System;
using System.Collections.Generic;

namespace Clist
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercício 1 - Animais");

            List<string> lista = new List<string>();

            lista.Add("Onça");
            lista.Add("Jacaré");
            lista.Add("Gato");
            lista.Add("Cachorro");

            lista.Insert(1,"Pássaro");

            lista.Remove("Cachorro");

            lista.RemoveAt(2);

            foreach (string nome in lista)
            {
                Console.WriteLine($"O animal é: {nome} ");
            }
        }
    }
}
