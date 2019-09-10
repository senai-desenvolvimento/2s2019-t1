using System;
using System.Collections.Generic;

namespace Comparable
{
    class Program
    {

        private static List<string> nomes = new List<string>();
        private static List<Pessoa> pessoas = new List<Pessoa>();


        static void Main(string[] args)
        {

            nomes.Add("Pedro");
            nomes.Add("Maria");

            foreach (var item in nomes)
            {
                System.Console.WriteLine(item);
            }
            System.Console.WriteLine("----------------------------------------------------");
            nomes.Remove("Maria");
            foreach (var item in nomes)
            {
                System.Console.WriteLine(item);
            }
            System.Console.WriteLine("----------------------------------------------------");
            Pessoa p1 = new Pessoa();
            p1.nome = "João";
            p1.cpf = 456;

            Pessoa p2 = new Pessoa();
            p2.nome = "Ciclano";
            p2.cpf = 123L;

            Pessoa p3 = new Pessoa();
            p3.nome = "Fulano";
            p3.cpf = 123L;

            pessoas.Add(p1);
            pessoas.Add(p2);
            pessoas.Add(p3);

            foreach (var item in pessoas)
            {
                System.Console.WriteLine(item);
            }
            System.Console.WriteLine("----------------------------------------------------");
            pessoas.Remove(p3);
            foreach (var item in pessoas)
            {
                System.Console.WriteLine(item);
            }

        }
    }
}
