using System;

namespace ExCorrecaoSala {
    class Program {
        static void Main (string[] args) {
            Aluno[] alunos = new Aluno[4];
            Sala[] salas = new Sala[1];
            bool sair = false;
            int contadorAluno = 0, contadorSala = 0;
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
                System.Console.WriteLine ("Escolha uma opção");

                int codigo = int.Parse (Console.ReadLine ());

                switch (codigo) {
                    case 1:
                        //cadastrar aluno
                        if (contadorAluno < 4) {
                            Aluno a = new Aluno ();
                            Console.WriteLine ("Digite o nome do aluno:");
                            a.Nome = Console.ReadLine ();
                            Console.WriteLine ("Digite a Data de Nascimento:");
                            a.DataNascimento = DateTime.Parse (Console.ReadLine ());
                            Console.WriteLine ("Digite o nome do Curso:");
                            a.Curso = Console.ReadLine ();
                            Console.WriteLine ("Digite o numero da sala");
                            a.NumeroSala = int.Parse (Console.ReadLine ());
                            alunos[contadorAluno] = a;
                            contadorAluno++;

                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine ("Cadastro efetuado com sucesso");
                            Console.ResetColor ();
                        } //fim if

                        break;

                    case 2:
                        //cadastrar sala

                        if (contadorSala < 1) {
                            Sala s = new Sala ();
                            Console.WriteLine ("Digite o número da sala:");
                            s.NumeroSala = int.Parse (Console.ReadLine ());
                            Console.WriteLine ("Digite a capacidade total:");
                            s.CapacidadeTotal = int.Parse (Console.ReadLine ());
                            s.CapacidadeAtual = s.CapacidadeTotal;
                            s.Alunos = new string[s.CapacidadeTotal];
                            salas[contadorSala] = s;
                            contadorSala++;

                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine ("Cadastro efetuado com sucesso");
                            Console.ResetColor ();

                            Console.WriteLine ("Aperte a tecla ENTER para voltar ao menu");
                            Console.ReadLine ();

                        } //fim if
                        break;
                    case 3:
                        if (contadorAluno == 0) {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine ($"Não há aluno cadastrado");
                            Console.ResetColor ();

                            Console.WriteLine ("Aperte a tecla ENTER para voltar ao menu");
                            Console.ReadLine ();
                            continue;
                        }

                        if (contadorSala == 0) {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine ($"Não há sala cadastrada");
                            Console.ResetColor ();

                            Console.WriteLine ("Aperte a tecla ENTER para voltar ao menu");
                            Console.ReadLine ();
                            continue;
                        }

                        Console.WriteLine ("Digite o nome do aluno");
                        string nomeAlunoAloc = Console.ReadLine ();
                        Aluno alunoRecuperadoAloc = null;
                        foreach (Aluno item in alunos) {
                            if (item != null && nomeAlunoAloc.Equals (item.Nome)) {
                                alunoRecuperadoAloc = item;
                                break;
                            }
                        }

                        if (alunoRecuperadoAloc == null) {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine ($"Não há aluno cadastrado com o nome {nomeAlunoAloc}");
                            Console.ResetColor ();

                            Console.WriteLine ("Aperte a tecla ENTER para voltar ao menu");
                            Console.ReadLine ();
                            continue;
                        }

                        Console.WriteLine ("Digite o numero da sala");
                        int numeroSalaAloc = int.Parse (Console.ReadLine ());
                        Sala salaRecuperadaAloc = null;
                        foreach (Sala item in salas) {
                            if (item != null && numeroSalaAloc.Equals (item.NumeroSala)) {
                                salaRecuperadaAloc = item;
                                break;
                            }
                        }

                        if (salaRecuperadaAloc == null) {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine ($"Não há sala cadastrada com o numero {numeroSalaAloc}");
                            Console.ResetColor ();

                            Console.WriteLine ("Aperte a tecla ENTER para voltar ao menu");
                            Console.ReadLine ();
                            continue;
                        }

                        Console.ForegroundColor = ConsoleColor.Blue;
                        System.Console.WriteLine(salaRecuperadaAloc.AlocarAluno (alunoRecuperadoAloc.Nome));
                        Console.ResetColor ();

                        Console.WriteLine ("Aperte a tecla ENTER para voltar ao menu");
                        Console.ReadLine ();

                        break;
                    case 4:
                        if (contadorAluno == 0) {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine ($"Não há aluno cadastrado");
                            Console.ResetColor ();

                            Console.WriteLine ("Aperte a tecla ENTER para voltar ao menu");
                            Console.ReadLine ();
                            continue;
                        }

                        if (contadorSala == 0) {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine ($"Não há sala cadastrada");
                            Console.ResetColor ();

                            Console.WriteLine ("Aperte a tecla ENTER para voltar ao menu");
                            Console.ReadLine ();
                            continue;
                        }

                        Console.WriteLine ("Digite o nome do aluno");
                        string nomeAlunoRem = Console.ReadLine ();
                        Aluno alunoRecuperadoRem = null;
                        foreach (Aluno item in alunos) {
                            if (item != null && nomeAlunoRem.Equals (item.Nome)) {
                                alunoRecuperadoRem = item;
                                break;
                            }
                        }

                        if (alunoRecuperadoRem == null) {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine ($"Não há aluno cadastrado com o nome {nomeAlunoRem}");
                            Console.ResetColor ();

                            Console.WriteLine ("Aperte a tecla ENTER para voltar ao menu");
                            Console.ReadLine ();
                            continue;
                        }

                        Console.WriteLine ("Digite o numero da sala");
                        int numeroSalaRem = int.Parse (Console.ReadLine ());
                        Sala salaRecuperadaRem = null;
                        foreach (Sala item in salas) {
                            if (item != null && numeroSalaRem.Equals (item.NumeroSala)) {
                                salaRecuperadaRem = item;
                                break;
                            }
                        }

                        if (salaRecuperadaRem == null) {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine ($"Não há sala cadastrada com o numero {numeroSalaRem}");
                            Console.ResetColor ();

                            Console.WriteLine ("Aperte a tecla ENTER para voltar ao menu");
                            Console.ReadLine ();
                            continue;
                        }

                        Console.ForegroundColor = ConsoleColor.Blue;
                        System.Console.WriteLine(salaRecuperadaRem.RemoverAluno (alunoRecuperadoRem.Nome));
                        Console.ResetColor ();

                        Console.WriteLine ("Aperte a tecla ENTER para voltar ao menu");
                        Console.ReadLine ();

                        break;

                    case 5:
                        //Listar salas
                        foreach (var item in salas) {
                            if (item != null) {

                                Console.WriteLine ("----------------");
                                Console.WriteLine ($"Número da sala {item.NumeroSala}");
                                Console.WriteLine ($"Vagas Disponíveis {item.CapacidadeAtual}");
                                Console.WriteLine ("----------------");
                            } //fim if

                        } //fim foreach
                        Console.WriteLine ("Aperte entre para continuar");
                        Console.ReadLine ();
                        break;

                    case 6:
                        foreach (var item in alunos) {
                            if (item != null) {
                                Console.WriteLine ("----------------");
                                Console.WriteLine ($"Nome do aluno: {item.Nome}");
                                Console.WriteLine ($"Curso: {item.Curso}");
                                Console.WriteLine ("----------------");
                            }

                        }
                        Console.WriteLine ("Aperte entre para continuar");
                        Console.ReadLine ();
                        break;
                    default:

                        break;
                }

            } while (!sair);
        }
    }
}