/**
Nome     : GeradorAbobrinha.cs
Objetivos: Ilustrar o uso de matrizes, laços de repetição e uso do gerador de 
           números randomicos.
Descrição: Dada uma matriz 5x5 com palavras, solicite aos usuários mais cinco 
           palavras e a partir gere uma frase com palavras aleatórias.
Obs      : Pode-se modificar o execício de modo que as palavras sejam divididas
		   em classes e frase gerada respeite essas classes de modo a criar 
		   sentenças que façam sentido.
 */

using System;

class GeradorAbobrinha {
	static void Main (string[] args) {
		
		int maxPalavrasUsuario   = 5;
		int maxPalavrasFrase     = 5;
		string[] palavrasUsuario = new string[5];
		string[,] matrizPalavras = { 
			{ "eu"    , "você"  , "nós"      , ""       , "elas"    }, 
			{ "rusbé" , "nunca" , "quase"    , "talvez" , ""        }, 
			{ "passa" , "mexe"  , "ve"       , "use"    , "biridim" }, 
			{ "pela"  , "nesse" , ""         , "a"      , "em"      }, 
			{ "ponte" , "cabelo", "crocodilo", "marreta", ""        }
		};

		Console.WriteLine ("Escreve uma palavra aí, meu consagrado");

		for (int i = 0; maxPalavrasUsuario > 0; i++) {
			palavrasUsuario[i] = Console.ReadLine ();
			if (--maxPalavrasUsuario != 0) {
				Console.WriteLine ("Faltam " + maxPalavrasUsuario + ". Digite mais uma!");
			} else {
				Console.WriteLine ("Valeu, jovem! Agora deixa comigo.");
			}
		}

		Console.WriteLine (palavrasUsuario);

		for (int i = 0; i < matrizPalavras.GetLength (0); i++) {
			
			for (int j = 0; j < matrizPalavras.GetLength (0); j++) {
				if ("".Equals (matrizPalavras[i, j])) {

					matrizPalavras[i, j] = palavrasUsuario[j];
				}
			}
		}

		Console.WriteLine (matrizPalavras);

		string frase = "";
		Random random = new Random ();
		for (int i = 0; i < maxPalavrasFrase; i++) {
			frase += matrizPalavras[i, 
			random.Next (matrizPalavras.GetLength (0))] + " ";

		}

		Console.WriteLine ("Minha frase é: \n" + frase);
	}
}