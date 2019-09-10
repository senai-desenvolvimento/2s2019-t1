/**
Nome     : Operadores.cs
Objetivos: Mostra o uso dos operadores aritmeticos básicos em C#.
Descrição: Dados dois números inteiros, reliza as operações aritiméticas básicas
           existentes no C#.
Obs      : Pode-se modificar o execício de modo que o usuário possa digitar os
           numeros ou escolher qual a operação a ser realizada.
 */

using System;

class Program
{
    static void Main(string[] args)
    {

        int n1 = 10;
        int n2 = 5;

        Console.WriteLine("Operadores Aritmeticos:");

        /* SOMA */
        int soma = n1 + n2;
        Console.WriteLine($"Soma: {n1} + {n2} = {soma}");

        /* SUBTRAÇÃO */
        int sub = n1 - n2;
        Console.WriteLine($"Subtração: {n1} - {n2} = {sub}");

        /* DIVISÃO */
        int div = n1 / n2;
        Console.WriteLine($"Divisão: {n1} / {n2} = {div}");

        /* MULTIPLICAÇÃO */
        int mult = n1 * n2;
        Console.WriteLine($"Multiplicação: {n1} * {n2} = {div}");

        /* RESTO */
        int mod = n1 % n2;
        Console.WriteLine($"Resto Divisão: {n1} % {n2} = {mod}");
        Console.WriteLine();

        /** Incremento e Decremento Unário Pos */
        int x = 10; // 10
        Console.WriteLine("Operadores Unários:");
        Console.WriteLine("Incremento Pos: " + x++);
        Console.WriteLine("Incremento Pre: " + ++x);
        Console.WriteLine("Decremento Pos: " + x--);
        Console.WriteLine("Decremento Pre: " + --x); 
    }
}