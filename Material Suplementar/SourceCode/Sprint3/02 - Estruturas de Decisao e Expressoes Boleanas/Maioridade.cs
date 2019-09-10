using System;

class Maioridade {
    static void Main (string[] args) {

        int anoAtual = 2019;
        int anoNascimento = 1987;

        if (anoAtual - anoNascimento > 30) { 
            Console.WriteLine("Já trintou!"); 
        } 
        else if (anoAtual - anoNascimento > 18) { 
            Console.WriteLine("Já é maior de idade");
        }
        else { 
            Console.WriteLine("Ainda não é maior de idade");
        }
        
        Console.WriteLine ("Terminou, mizeravi!");
    }
}