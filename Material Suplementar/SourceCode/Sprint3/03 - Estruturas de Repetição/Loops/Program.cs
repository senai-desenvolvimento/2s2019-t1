using System;
using System.Threading;
namespace Loops {
    class Program {
        static void Main (string[] args) {

            /******************************************
                                WHILE
            *******************************************/
            // bool usuarioAindaQuerJogar = true;

            // while (usuarioAindaQuerJogar) 
            // {
            //     Console.WriteLine("Ainda quer jogar?");
            //     string resposta = Console.ReadLine();
            //     usuarioAindaQuerJogar = resposta.Equals("sim") ? true : false;
            // }

            /**
                Tabuada: 1 while
             */

            // System.Console.WriteLine ("Escolha um número para calcular a tabuada");
            // int numero = int.Parse (Console.ReadLine ());
            // int mult = 0;
            // int max = 10;
            // while (mult <= max) {

            //     int resultado = numero * mult;
            //     System.Console.WriteLine ("{0} x {1} = {2}", numero, mult, resultado);

            //     if (mult == max) {
            //         Console.WriteLine("Deseja escolher outro número?");
            //         string resposta = Console.ReadLine();
            //         /** Código de "RESET" */
            //         if ("sim".Equals(resposta)) {
            //             System.Console.WriteLine ("Escolha um número para calcular a tabuada");
            //             numero = int.Parse (Console.ReadLine ());
            //             mult = 0;
            //         } else {
            //             System.Console.WriteLine ("Faloooou!");
            //         }

            //     } else {
            //         mult++;
            //     }
            // }
            // System.Console.WriteLine ("TADAAAAA!");
            // System.Console.WriteLine ("Deseja continuar?");

            /**
                Tabuada: 2 while
             */
            // bool fazTabuada = true;
            // while (fazTabuada) {
            //     System.Console.WriteLine ("Escolha um número para calcular a tabuada");
            //     int numero = int.Parse (Console.ReadLine ());
            //     System.Console.WriteLine ("Aguarde um momento...");

            //     /** Adicionar drama! */
            //     Thread.Sleep (2000);

            //     int mult = 0;
            //     while (mult <= 10) {
            //         int resultado = numero * mult;
            //         System.Console.WriteLine ("{0} x {1} = {2}", numero, mult, resultado);
            //         mult++;
            //     }
            //     System.Console.WriteLine ("TADAAAAA!");
            //     System.Console.WriteLine ("Deseja continuar?");
            //     string resposta = Console.ReadLine ();
            //     fazTabuada = resposta.Equals ("sim") ? true : false;
            // }

            // /**
            //     Menu
            //  */
            //  int codigo = 0;
            //  string usuario = "Jovem";
            //  while(codigo != 9 ) {
            //     System.Console.WriteLine("===========================");
            //     System.Console.WriteLine("  Bem-vindo(a) {0} ", usuario);
            //     System.Console.WriteLine("---------------------------");
            //     System.Console.WriteLine("|    1. Login             |");
            //     System.Console.WriteLine("|    2. Contato           |");
            //     System.Console.WriteLine("|    3. Comentários       |");
            //     System.Console.WriteLine("|    9. Sair              |");
            //     System.Console.WriteLine("===========================");

            //     System.Console.WriteLine("Por favor, escolha uma das opções acima digitando seu código.");

            //     if (int.TryParse(Console.ReadLine(), out codigo)) 
            //     {
            //         switch(codigo) 
            //         {
            //             case 1:
            //                 System.Console.Write("Digite seu usuario:");
            //                 usuario = Console.ReadLine();
            //                 System.Console.Write("Digite sua senha:");
            //                 Console.ReadLine();
            //                 System.Console.WriteLine("Logou!");

            //                 System.Console.Write("\n");

            //                 Thread.Sleep(1000);
            //                 break;
            //             case 2:
            //                 System.Console.WriteLine("Se liga nos contatinhos!");
            //                 System.Console.WriteLine("1 - Fulano");
            //                 System.Console.WriteLine("2 - Ciclano");
            //                 System.Console.WriteLine("3 - Beltrano");
            //                 System.Console.Write("Pressione ENTER para voltar a tela inicial");
            //                 Console.ReadLine();

            //                 System.Console.Write("\n");

            //                 Thread.Sleep(1000);
            //                 break;
            //             case 3:
            //                 System.Console.WriteLine("Olha o que tem falado de você! o.O");
            //                 System.Console.WriteLine("1 - Fulano: Parece Razoável...");
            //                 System.Console.WriteLine("2 - Ciclano: Não sei, e se soubesse, não falaria.");
            //                 System.Console.WriteLine("3 - Beltrano: Para o que serve isso aqui?");
            //                 System.Console.Write("Pressione ENTER para voltar a tela inicial");
            //                 Console.ReadLine();

            //                 System.Console.Write("\n");

            //                 Thread.Sleep(1000);
            //                 break;
            //             case 9:
            //                 System.Console.WriteLine("Adeus!");
            //                 System.Console.Write("\n");

            //                 Thread.Sleep(1000);
            //                 break;
            //             default:
            //                 System.Console.WriteLine("Opção inválida");
            //                 break;
            //         }
            //     } else {
            //         System.Console.WriteLine("Opção inválida");
            //     }

            //  }

            // /******************************************
            //                 DO WHILE
            // *******************************************/
            // bool jaAcordei = false;
            // do {

            //     Console.WriteLine("Pai, você já acordou?");
            //     string resposta = Console.ReadLine();

            //     jaAcordei = resposta.Equals("sim") ? true : false;
            // } while (!jaAcordei);

            /******************************************
                                FOR
            *******************************************/
            // for (int i = 0; i < 10; i++)
            // {
            //     Console.WriteLine("a");
            // }

            // for (int i = 0; i <= 100; i++)
            // {
            //     if (i % 2 == 0) {
            //         Console.ForegroundColor = ConsoleColor.DarkMagenta;
            //     } else {
            //         Console.ForegroundColor = ConsoleColor.Blue;
            //     }
            //     Console.WriteLine(i);
            // }

            // /** Triangler */
            // System.Console.WriteLine("Digite um número!");
            // int tamanhoTriangulo = int.Parse(Console.ReadLine());
            // System.Console.WriteLine("");
            // string estrelas = "";
            // for (int i = 0; i < tamanhoTriangulo; i++)
            // {
            //     estrelas += "*";
            //     System.Console.WriteLine(estrelas);
            // }

            // /** Multi Triangler */
            // System.Console.WriteLine ("Digite o tamanho do triângulo");
            // int tamanhoTriangulo = int.Parse (Console.ReadLine ());

            // System.Console.WriteLine ("Digite a quantidade de triângulos");
            // int qntTriangulos = int.Parse (Console.ReadLine ());

            // for (int i = 0; i < qntTriangulos; i++) {
            //     string estrelas = "";
            //     for (int j = 0; j < tamanhoTriangulo; j++) {
            //         estrelas += "*";
            //         System.Console.WriteLine (estrelas);
            //     }
            // }

            // /** Multi Triangler WITH STRINGS */
            // System.Console.WriteLine ("Digite o tamanho do triângulo");
            // int tamanhoTriangulo = int.Parse (Console.ReadLine ());

            // System.Console.WriteLine ("Digite a quantidade de triângulos");
            // int qntTriangulos = int.Parse (Console.ReadLine ());

            // for (int i = 0; i < qntTriangulos; i++) {
            //     for (string estrelas = "*"; estrelas.Length <= qntTriangulos; estrelas+= "*") {
            //         System.Console.WriteLine (estrelas);
            //     }
            // }

            // /** Game of PI */
            // for (int i = 0; i <= 100; i++)
            // {
            //     System.Console.WriteLine(((i % 4 != 0) ? i.ToString() : "PI"));
            // }

            // /******************************************
            //             FOR "estranho"
            // *******************************************/

            // for (bool eita = true; eita; )
            // {
            //     string resposta = Console.ReadLine();
            //     eita = resposta.Equals("sim") ? true : false;
            // }

            // for (;;) {
            //     System.Console.WriteLine("Weee");
            // }

            // /** For Duplo */
            // int linhas = 2;
            // int colunas = 2;
            // for (int i = 0; i <= linhas; i++) {
            //     for (int j = 0; j <= colunas; j++) {
            //         System.Console.WriteLine($"[{i},{j}]");
            //     }
            // }

            //     /** Exercicio */

            //     int totalMulheres = 0;
            //     int totalHomens = 0;
            //     int idadeHomens = 0;
            //     int idadeMulheres = 0;
            //     float pesoH = 0.0f;
            //     float pesoM = 0.0f;

            //     for (int pessoa = 1; pessoa <= 10; pessoa++) {

            //         System.Console.WriteLine ($"Pessoa {pessoa}:");

            //         // SEXO
            //         Console.ForegroundColor = ConsoleColor.Cyan;
            //         System.Console.WriteLine ("Qual é o seu sexo? ");

            //         Console.ForegroundColor = ConsoleColor.White;
            //         char sexo = char.Parse (Console.ReadLine ());

            //         // IDADE
            //         Console.ForegroundColor = ConsoleColor.Cyan;
            //         System.Console.WriteLine ("Qual é a sua idade? ");

            //         Console.ForegroundColor = ConsoleColor.White;
            //         int idade = int.Parse (Console.ReadLine ());

            //         // PESO
            //         Console.ForegroundColor = ConsoleColor.Cyan;
            //         System.Console.WriteLine ("Qual é o seu peso? ");

            //         Console.ForegroundColor = ConsoleColor.White;
            //         float peso = float.Parse (Console.ReadLine ());

            //         if ('m'.Equals (sexo)) {
            //             totalHomens++;
            //             idadeHomens += idade;
            //             pesoH += peso;

            //         } else {
            //             totalMulheres++;
            //             idadeMulheres += idade;
            //             pesoM += peso;
            //         }

            //     }

            //     System.Console.WriteLine ($" Total de Homens: {totalHomens}");
            //     System.Console.WriteLine ($" Total de Mulheres: {totalMulheres}");
            //     System.Console.WriteLine ($" Média idade Homens: {(idadeHomens / totalHomens)}");
            //     System.Console.WriteLine ($" Média idade Mulheres: {(idadeMulheres / totalMulheres)}");
            //     System.Console.WriteLine ($" Média peso Homens: {(pesoH / totalHomens)}");
            //     System.Console.WriteLine ($" Média peso Mulheres: {(pesoM / totalMulheres)}");
            // }

            // /******************************************
            //             Continue e Break
            // *******************************************/

            // string[] suspeitos = {"Cesar", "Tsukamoto", "Rusbé", "Culpado", "Bona", "Zé Mané", "Fulano"};

            // for (int i = 0; i < suspeitos.Length; i++)
            // {
            //     System.Console.WriteLine("Você é o " + suspeitos[i]);
            //     if (suspeitos[i].Equals("Culpado")) 
            //     {
            //         System.Console.WriteLine("TEJE PRESO!");
            //         break;
            //     }
            // }

            for (int i = 0; i < 10; i++)
            {
                if (i % 2 == 0)
                {
                    continue;
                }
                System.Console.WriteLine("Número " + i);
            }



        }
    }
}