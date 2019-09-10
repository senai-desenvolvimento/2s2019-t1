/**
Nome     : InitMatriz.cs
Objetivos: Ilustrar o uso de matrizes, laços de repetição.
Descrição: Criar um programa que dado um vetor de inteiros com N posições, 
           permita que usuário digite esses N números através de um prompt na 
           console.
Obs      : Pode-se usar esse mesmo código para demonstrar o uso de outra estrutura
           de repetição além do FOR e do FOREACH, além disso, como desafio extra 
           pode-se pedir aos alunos para criarem uma interface de entrada para os 
           usuários.
 */

using System;

public class InitMartriz{

    static void Main(string[] args){

        int[] numeroCasas = new int[5];
        for (int i = 0; i < numeroCasas.Length; i++) {
            numeroCasas[i] = int.Parse(Console.ReadLine());
        }
        
        foreach (int numeroCasa in numeroCasas)
        {
            System.Console.Write($"{numeroCasa},");
        }
    }
}
