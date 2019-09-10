/**
Nome     : Calculadora.cs
Objetivos: Mostra o uso dos operadores aritmeticos básicos em C#.
Descrição: Dados dois números digitados pelo usuário, relize uma operação 
           aritmética básica qualquer a ser determinada em tempo de edição.
Obs      : Pode-se modificar o execício de modo que além do usuário digitar os
           numeros, ele também seja capaz de escolher entre algumas operações 
           básicas.
 */

using System;

class Calculadora
{
    static void Main(string[] args)
    {
        int n1 = int.Parse(Console.ReadLine());
        int n2 = int.Parse(Console.ReadLine());

        int resultado = n1 % n2;
        Console.WriteLine("O resultado é {0} ", resultado);
    }
}
