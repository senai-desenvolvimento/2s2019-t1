using System;
using SENAIzinho_2.classes;
using SENAIzinho_2.interfaces;

namespace SENAIzinho_2.classes
{
    public class Professor : Funcionario, IDocente
    {
        public string Curso {get; set;}
        public int NumeroSala {get; set;}

        public bool DarAula()
        {
            System.Console.WriteLine("Dizia eu que a aritmética...");
            return true;
        }

        public override void Trabalhar()
        {
            System.Console.WriteLine("Vamos lá, pessoal! Bora fazer o exercício");
        }
    }
}