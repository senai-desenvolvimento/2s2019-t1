/**
Nome     : ParImpar.cs
Objetivos: Ilustrar o uso de matrizes, laços de repetição e comandos de decisão.
Descrição: Criar um programa que dado um vetor com números inteiros aleatórios, 
           determine quais deles são impares, imprimindo todos os números impares 
           encontrados além da quantidade de números impares encontrados.
Obs      : Pode-se usar esse mesmo código para o cálculo de numeros pares ao invés
           dos impares, usar um gerador de números aleatórios para a inicialização 
           do vetor ou se utilizar de outra estrutura de repetição que não o FOR, 
           como o FOREACH, por exemplo.
 */

using System;


public class ParImpar {
    static void Main (string[] args) {
        int[] numeros = { 1, 2, 3, 4, 5, 15, 756, 123, 9687, 1824, 52, 8674, 165, 8721, 1862 };
        int impares = 0;
        for (int i = 0; i < numeros.Length; i++) {
            if (numeros[i] % 2 != 0) {
                impares++;
                System.Console.WriteLine (numeros[i]);
            }
        }
        System.Console.WriteLine($"Total:{impares}");
    }
}