using System;

/**
Tabuada: 1 while
*/

namespace Tabuada1
{
    public class program {
        public static void Main(string args[]) {
            System.Console.WriteLine ("Escolha um número para calcular a tabuada");
            int numero = int.Parse (Console.ReadLine ());
            int mult = 0;
            int max = 10;
            while (mult <= max) {
                int resultado = numero * mult;
                System.Console.WriteLine ("{0} x {1} = {2}", numero, mult, resultado);
                if (mult == max) {
                    Console.WriteLine("Deseja escolher outro número?");
                    string resposta = Console.ReadLine();
                    /** Código de "RESET" */
                    if ("sim".Equals(resposta)) {
                        System.Console.WriteLine ("Escolha um número para calcular a tabuada");
                        numero = int.Parse (Console.ReadLine ());
                        mult = 0;
                    } else {
                        System.Console.WriteLine ("Faloooou!");
                    }
                } else {
                    mult++;
                }
            }   
            System.Console.WriteLine ("TADAAAAA!");
            System.Console.WriteLine ("Deseja continuar?");
        }
    }
}
