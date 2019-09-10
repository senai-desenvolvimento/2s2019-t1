/**
Nome     : Variáveis.cs
Objetivos: Mostra os tipos de variáveis mais comuns em C# e a sua faixa de valores.
Descrição: Exibe na console os tipos de variáveis e suas faixas de valores.
Obs      : 
 */

using System;

class variaveis
{
    static void Main(string[] args)
    {
        /**
        TIPOS VALOR 
        https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/value-types
        */

        /**
        Inteiros com sinal 
        */
        Console.WriteLine("Inteiros com Sinal");
        Console.WriteLine($"sbyte -  8 bits: {sbyte.MinValue} ~ {sbyte.MaxValue}");
        Console.WriteLine($"short - 16 bits: {short.MinValue} ~ {short.MaxValue}");
        Console.WriteLine($"int   - 32 bits: {int.MinValue} ~ {int.MaxValue}");
        Console.WriteLine($"long  - 64 bits: {long.MinValue} ~ {long.MaxValue}");
        Console.WriteLine();

        /**
        Inteiros sem sinal 
        */
        Console.WriteLine("Inteiros sem Sinal");
        Console.WriteLine($"byte   -  8 bits: {byte.MinValue} ~ {byte.MaxValue}");
        Console.WriteLine($"ushort - 16 bits: {ushort.MinValue} ~ {ushort.MaxValue}");
        Console.WriteLine($"uint   - 32 bits: {uint.MinValue} ~ {uint.MaxValue}");
        Console.WriteLine($"ulong  - 64 bits: {ulong.MinValue} ~ {ulong.MaxValue}");
        Console.WriteLine();
        
        /** 
        Unicode characters 
        */ 
        Console.WriteLine("char - 16 bits: 0000 ~ FFFF");
        Console.WriteLine();

        /**
        IEEE ponto flutuante 
        */
        Console.WriteLine("IEEE Ponto Flutuante");
        Console.WriteLine($"float  - 32 bits: {float.MinValue} ~ {float.MaxValue}");
        Console.WriteLine($"double - 64 bits: {double.MinValue} ~ {double.MaxValue}");
        Console.WriteLine($"decimal - 128 bits: {decimal.MinValue} ~ {decimal.MaxValue}");
        Console.WriteLine();

        /**
        Boleano 
        */
        Console.WriteLine("Boleano");
        Console.WriteLine($"bool: True ~ False");
        Console.WriteLine();

        /** Abaixo temos exemplos de variáveis */
        var varString = "É nada";
        Console.WriteLine($"O tipo de {varString} é {varString.GetType()}");
        var varInt = 2019;
        Console.WriteLine($"O tipo de {varInt} é {varInt.GetType()}");
        var varFloat = 126.43;
        Console.WriteLine($"O tipo de {varFloat} é {varFloat.GetType()}");
    }
}

