/**
Nome     : SaqueCertoWhile.cs
Objetivos: Ilustrar o uso de matrizes, laços de repetição e comandos de decisão.
Descrição: Criar um programa que simule o uso de um caixa eletronico, onde o 
           usuário pode entrar um valor, e o programa calcula o número de notas
           a serem entregues pelo dispositivo.
Obs      : Pode-se usar esse mesmo código para ilustrar o uso de outras estruturas
           de repetição. Como desafio adicional pode-se pedir aos alunos que 
           limitem o número de notas existentes no caixa eletrônico e recalcule
           quantidade de notas liberadas para o cliente dependendo da quantidade
           das notas existentes.
 */

using System;

public class SaqueCertoWhile{
    public static void Main(String[] args){
        
        int[] notas = { 100, 50, 20, 10, 5, 2, 1 };
        int valorNotas = 0;
        
        System.Console.Write ("Digite o valor do seu saque: ");
        int saque = int.Parse (Console.ReadLine ());
        DateTime data = DateTime.Now;
        
        for (int i = 0; i < notas.Length; i++){
            while(valorNotas<saque && (saque-valorNotas) >= notas[i]){
                valorNotas += notas[i];
                System.Console.WriteLine(notas[i]);
            }
        }
    }
}