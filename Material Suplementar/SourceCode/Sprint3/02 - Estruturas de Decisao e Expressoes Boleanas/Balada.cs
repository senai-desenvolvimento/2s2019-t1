/**
Nome     : Balada.cs
Objetivos: Exemplifica o uso dos comandos de decisão IF ELSE e ELSE IF em C#.
Descrição: Dados dois números digitados pelo usuário, relize uma operação 
           aritmética básica qualquer a ser determinada em tempo de edição.
Obs      : Pode-se modificar o execício de modo que além do usuário digitar os
           numeros, ele também seja capaz de escolher entre algumas operações 
           básicas.
 */

using System;

class Balada {
    static void Main (string[] args) {
        Console.WriteLine ("Bem-vindo(a) ao Barrados no Baile!");
        Console.WriteLine ("Você tem idade para ir a essa balada?");
        string respostaIdade = Console.ReadLine ();

        Console.WriteLine ("Você tem disponibilidade para ir a essa pocilga?");
        string respostaDisponibilidade = Console.ReadLine ();

        if ("sim".Equals (respostaIdade, StringComparison.CurrentCultureIgnoreCase) && "sim".Equals (respostaDisponibilidade, StringComparison.CurrentCultureIgnoreCase)) {
            Console.WriteLine ("Bora! Bora! Bora!");
            Console.WriteLine ("...mas antes me diga se você PAGOU a entrada ou TEM pulseira VIP?");
            string respostaEntrada = Console.ReadLine ();

            if ("paguei".Equals (respostaEntrada, StringComparison.CurrentCultureIgnoreCase) || "tenho".Equals (respostaEntrada, StringComparison.CurrentCultureIgnoreCase)) {
                Console.WriteLine ("Firmeza, amizade. SEXTOOOOU!");
            } else {
                Console.WriteLine ("Aí fica difícil, parça! Arruma um ou outro!");
            }
        } else {
            Console.WriteLine ("Melhor sorte na próxima, fii!");
        }
    }
}