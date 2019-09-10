/**
Nome     : SomaMatriz.cs
Objetivos: Ilustrar o uso de matrizes e laços de repetição.
Descrição: Criar um programa que dada uma matriz 3x3 de inteiros aleatórios, 
           realize a soma de todos os números exibindo o total na tela.
Obs      : Pode-se usar esse mesmo código para ilustrar o uso de outras 
           estruturas de repetição e como realizar a inicialização automática 
           de uma matriz multidimensional.
           Como desafio adicional pode-se pedir aos alunos que exibam os 
           elementos da matriz no formato 3x3 na tela.
 */

using System;

public class SomaMartiz{
    
    static void Main(string[] args){

        int[,] matrix = {
                            {1, 2, 3},
                            {4, 5 ,6},
                            {7, 8, 9}
                        };
        int soma = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(0); j++)
            {
                soma += matrix[i,j];
            }
        }
        System.Console.WriteLine("Soma: " + soma);
    }
}