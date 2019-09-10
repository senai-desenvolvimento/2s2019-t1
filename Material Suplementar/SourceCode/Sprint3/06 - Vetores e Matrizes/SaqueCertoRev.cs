/**
Nome     : SaqueCertoRev.cs
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

public class SaqueCertoRev{
    static void Main(string[] args){

        int[] notas = { 1, 2, 5, 10, 20, 50, 100 };

        System.Console.Write ("Digite o valor do seu saque: ");
        int saque = int.Parse (Console.ReadLine ());
        DateTime data = DateTime.Now;
        
        // Usa o FOR reverso para calcular as notas.
        for (int i = notas.Length - 1; i >= 0  ; i--) {
            int qntdNotas = saque / notas[i];
            int restante = saque % notas[i];
            saque = restante;
            
            if(qntdNotas != 0) {
                System.Console.WriteLine($" Você recebeu {qntdNotas} nota(s) de {notas[i]} em {data:HH:mm}");
            }
        }
        
    }
}

