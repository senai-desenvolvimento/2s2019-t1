using System;
using System.Dynamic;

/**
    Classes, métodos, atributos, personalização do console, 
 */
namespace SENAIzinho {
    class Program {
        static void Main (string[] args) {

            #region PROBLEMA - Precisamos definir limites para alunos e salas!
            int limiteAlunos = 10;
            int limiteSalas = 5;
            #endregion
            Aluno[] alunos = new Aluno[limiteAlunos];
            Sala[] salas = new Sala[limiteSalas];
            int alunosCadastrados = 0;
            int salasCadastradas = 0;
            bool querSair = false;

            do {
                Console.Clear ();
                System.Console.WriteLine ("===================================");
                Console.ForegroundColor = ConsoleColor.DarkRed;
                System.Console.WriteLine ("        *** SENAIzinho ***         ");
                Console.ResetColor ();
                System.Console.WriteLine ("         Seja bem-vindo(a)         ");
                System.Console.WriteLine ("===================================");
                System.Console.WriteLine ("|| Digite sua opção:             ||");
                System.Console.WriteLine ("||  1 - Cadastrar Aluno          ||");
                System.Console.WriteLine ("||  2 - Cadastrar Sala           ||");
                System.Console.WriteLine ("||  3 - Alocar Aluno             ||");
                System.Console.WriteLine ("||  4 - Remover Aluno            ||");
                System.Console.WriteLine ("||  5 - Verificar Salas          ||");
                System.Console.WriteLine ("||  6 - Verificar Alunos         ||");
                System.Console.WriteLine ("||  0 - Sair                     ||");
                System.Console.WriteLine ("===================================");

                System.Console.Write ("Código: ");
                int codigo;
                if (int.TryParse (Console.ReadLine (), out codigo)) {
                    switch (codigo) {
                        // CADASTRO ALUNOS
                        case 1:
                            if (limiteAlunos != alunosCadastrados) {
                                Aluno aluno = new Aluno ();

                                System.Console.WriteLine ("Digite o nome do aluno");
                                aluno.nome = Console.ReadLine ();

                                System.Console.WriteLine ("Digite a data de nascimento (dd/mm/aaaa)");
                                aluno.dataNascimento = DateTime.Parse (Console.ReadLine ());

                                System.Console.WriteLine ("Digite o nome do curso");
                                aluno.curso = Console.ReadLine ();

                                alunos[alunosCadastrados] = aluno;

                                alunosCadastrados++;
                                #region PROBLEMA - Repetição de código
                                Console.ForegroundColor = ConsoleColor.Green;
                                System.Console.WriteLine ("Cadastro de Aluno concluído!");
                                Console.ResetColor ();

                                System.Console.WriteLine ("Aperte ENTER para voltar ao menu");
                                Console.ReadLine ();
                                #endregion

                            } else {
                                #region PROBLEMA - Repetição de código
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                System.Console.WriteLine ("Não há mais vagas para alunos!");
                                Console.ResetColor ();

                                System.Console.WriteLine ("Aperte ENTER para voltar ao menu");
                                Console.ReadLine ();
                                #endregion
                            }

                            break;
                        case 2:
                            // CADASTRO SALAS
                            if (limiteSalas != salasCadastradas) {

                                Sala sala = new Sala ();

                                System.Console.WriteLine ("Digite o número da sala");
                                sala.numeroSala = int.Parse (Console.ReadLine ());

                                System.Console.WriteLine ("Digite a capacidade total");
                                sala.capacidadeTotal = int.Parse (Console.ReadLine ());

                                sala.capacidadeAtual = sala.capacidadeTotal;

                                sala.alunos = new string[sala.capacidadeTotal];

                                salas[salasCadastradas] = sala;

                                salasCadastradas++;

                                #region PROBLEMA - Repetição de código
                                Console.ForegroundColor = ConsoleColor.Green;
                                System.Console.WriteLine ("Cadastro de Sala concluído!");
                                Console.ResetColor ();

                                System.Console.WriteLine ("Aperte ENTER para voltar ao menu");
                                Console.ReadLine ();
                                #endregion

                            } else {
                                #region PROBLEMA - Repetição de código
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                System.Console.WriteLine ("Não há mais espaço para salas!");
                                Console.ResetColor ();

                                System.Console.WriteLine ("Aperte ENTER para voltar ao menu");
                                Console.ReadLine ();
                                #endregion
                            }

                            break;
                        case 3:
                            // ALOCAR ALUNO
                            if (alunosCadastrados == 0) {
                                #region PROBLEMA - Repetição de código
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                System.Console.WriteLine ($"Não há alunos cadastrados");
                                Console.ResetColor ();

                                System.Console.WriteLine ("Aperte ENTER para voltar ao menu principal");
                                Console.ReadLine ();
                                #endregion
                                continue;
                            }

                            if (salasCadastradas == 0) {
                                #region PROBLEMA - Repetição de código
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                System.Console.WriteLine ("Não há salas cadastradas!");
                                Console.ResetColor ();

                                System.Console.WriteLine ("Aperte ENTER para voltar ao menu");
                                Console.ReadLine ();
                                #endregion
                                continue;
                            }

                            System.Console.WriteLine ("Digite o nome do aluno");
                            string nome = Console.ReadLine ();
                            Aluno alunoAchado = ProcurarAlunoPorNome (nome, alunos);

                            System.Console.WriteLine ("Digite o numero da sala");
                            int numSala = int.Parse (Console.ReadLine ());

                            Sala salaAchada = ProcurarSalaPorNumero (numSala, salas);

                            if (alunoAchado != null && salaAchada != null) {
                                if (salaAchada.AlocarAluno (nome, numSala)) {
                                    #region PROBLEMA - Repetição de código
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    System.Console.WriteLine ($"{nome} alocado!");
                                    Console.ResetColor ();
                                    #endregion
                                    alunoAchado.numeroSala = numSala;
                                } else {
                                    #region PROBLEMA - Repetição de código
                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                    System.Console.WriteLine ($"Não há mais vagas nessa sala");
                                    Console.ResetColor ();
                                    #endregion
                                }
                            } else {
                                #region PROBLEMA - Repetição de código
                                Console.ForegroundColor = ConsoleColor.Red;
                                System.Console.WriteLine ($"Não foi possível alocar {nome}! Verifique o número da sala e o nome do aluno");
                                Console.ResetColor ();
                                #endregion
                            }

                            System.Console.WriteLine ("Aperte ENTER para voltar ao menu principal");
                            Console.ReadLine ();

                            break;
                        case 4:
                            // REMOVER ALUNO
                            if (alunosCadastrados == 0) {
                                #region PROBLEMA - Repetição de código
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                System.Console.WriteLine ($"Não há alunos cadastrados");
                                Console.ResetColor ();

                                System.Console.WriteLine ("Aperte ENTER para voltar ao menu principal");
                                Console.ReadLine ();
                                #endregion
                                continue;
                            }
                            if (salasCadastradas == 0) {
                                #region PROBLEMA - Repetição de código
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                System.Console.WriteLine ($"Não há salas cadastradas");
                                Console.ResetColor ();

                                System.Console.WriteLine ("Aperte ENTER para voltar ao menu principal");
                                Console.ReadLine ();
                                #endregion
                                continue;
                            }

                            System.Console.WriteLine ("Digite o nome do aluno");
                            string nomeAluno = Console.ReadLine ();
                            
                            foreach (var item in salas) {

                                #region PROBLEMA -Tentar remover um aluno sem que haja uma sala
                                #endregion

                                if (item != null) {
                                    if (item.RemoverAluno (nomeAluno)) {
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        System.Console.WriteLine ($"{nomeAluno} removido!");
                                        Console.ResetColor ();
                                    } else {
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        System.Console.WriteLine ($"Não foi possível remover {nomeAluno}!");
                                        Console.ResetColor ();
                                    }
                                }
                            }

                            System.Console.WriteLine ("Aperte ENTER para voltar ao menu principal");
                            Console.ReadLine ();

                            break;
                        case 5:
                            Console.ForegroundColor = ConsoleColor.Blue;
                            System.Console.WriteLine ("Listando todas as salas");
                            Console.ResetColor ();
                            foreach (var item in salas) {
                                if (item != null) {
                                    System.Console.WriteLine ("-----------------------------------------------------");
                                    System.Console.WriteLine ($"Número da sala: {item.numeroSala}");
                                    System.Console.WriteLine ($"Vagas disponíveis: {item.capacidadeAtual}");
                                    System.Console.WriteLine ($"Alunos: {item.MostrarAlunos()}");
                                    System.Console.WriteLine ("-----------------------------------------------------");
                                }
                            }

                            System.Console.WriteLine ("Aperte ENTER para voltar ao menu principal");
                            Console.ReadLine ();

                            break;
                        case 6:
                            Console.ForegroundColor = ConsoleColor.Blue;
                            System.Console.WriteLine ("Listando todos os alunos");
                            Console.ResetColor ();
                            foreach (var item in alunos) {
                                if (item != null) {
                                    System.Console.WriteLine ("-----------------------------------------------------");
                                    System.Console.WriteLine ($"Nome: {item.nome}");
                                    System.Console.WriteLine ($"Sala: {item.numeroSala}");
                                    System.Console.WriteLine ("-----------------------------------------------------");
                                }
                            }

                            System.Console.WriteLine ("Aperte ENTER para voltar ao menu principal");
                            Console.ReadLine ();

                            break;
                        case 0:
                            querSair = true;
                            Console.ForegroundColor = ConsoleColor.Blue;
                            System.Console.WriteLine ("Até logo!");
                            Console.ResetColor ();
                            break;

                        default:

                            break;
                    }
                }

            } while (!querSair);
        }

        static Sala ProcurarSalaPorNumero (int numero, Sala[] colecao) {
            foreach (var item in colecao) {
                if (item != null && numero.Equals (item.numeroSala)) {
                    return item;
                }
            }

            return null;

        }
        static Aluno ProcurarAlunoPorNome (string nome, Aluno[] colecao) {

            foreach (var item in colecao) {
                if (item != null && nome.Equals (item.nome)) {
                    return item;
                }
            }

            return null;
        }
    }
}