using System;

namespace TsukaAirlines {
    class Program {
        static void Main (string[] args) {

            bool querSair = false;
            Passageiro[] passageiros = new Passageiro[2];
            int numPassageiros = 0;
            System.Console.WriteLine ("Seja bem-vindo(a) à Tsukamoto Airlines");

            do {

                System.Console.WriteLine ("Escolha uma opção:");
                System.Console.WriteLine ("1 - Registrar Passageiro");
                System.Console.WriteLine ("2 - Exibir passageiros");
                System.Console.WriteLine ("0 - Sair");

                int codigo = int.Parse (Console.ReadLine ());

                switch (codigo) {
                    case 1:
                        Passageiro p = new Passageiro ();
                        System.Console.WriteLine ("Digite o seu nome");
                        p.setNome (Console.ReadLine ());

                        passageiros[numPassageiros] = p;
                        numPassageiros++;
                        System.Console.WriteLine ("Cadastro concluído!");
                        break;
                    case 2:
                        System.Console.WriteLine ("Todos os passageiros cadastrados:");
                        foreach (var passageiro in passageiros) {
                            if (passageiro != null) {
                                System.Console.WriteLine (passageiro.getNome ());
                            }
                        }
                        break;
                }

            } while (!querSair);
        }
    }
}