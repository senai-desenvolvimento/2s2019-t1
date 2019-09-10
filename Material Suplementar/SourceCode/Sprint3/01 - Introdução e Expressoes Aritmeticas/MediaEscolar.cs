/**
Nome     : MediaEscolar.cs
Objetivos: Mostra o uso dos operadores aritméticos basicos.
Descrição: Dados 3 números representado as notas semetrais de um aluno, calcule
           qual a média final do curso para esse indvíduo.
Obs      : Pode-se alterar esse exercício para que o usuário seja capaz de 
           entrar com as notas do semestre pelo prompt de comandos.
 */

using System;

class MediaEscolar
{
    static void Main(string[] args)
    {
        /* Nota do primeiro semestre */
        int n1 = 5;

        /* Nota do segundo semestre  */
        int n2 = 6;
        
        /* Nota do terceiro semestre */
        int n3 = 7;

        float resultadoSoma = n1 + n2 + n3;

        Console.WriteLine(resultadoSoma);

        float resultadoDivisao = resultadoSoma / 3;

        Console.WriteLine(resultadoDivisao);
    }
}