/**
Nome     : SaqueCerto.cs
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
            
public class SaqueCerto{
    static void Main(string[] args){

        int[] notas = { 100, 50, 20, 10, 5, 2, 1 };

        System.Console.Write ("Digite o valor do seu saque: ");
        int saque = int.Parse (Console.ReadLine ());
        DateTime data = DateTime.Now;

        //============================================
        //    Usando o for progressivo
        //============================================

        for (int i = 0; i < notas.Length; i++) {
            int qntdNotas = saque / notas[i];
            int excedente = saque % notas[i];
            saque = excedente;

            if (qntdNotas != 0)
            {
                System.Console.WriteLine ($"Você recebeu:{qntdNotas} em notas de {notas[i]} em {data:dd/MM/yyyy}");    
            }
        }
    }
}