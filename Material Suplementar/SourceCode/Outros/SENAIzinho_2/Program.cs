using System;
using System.Collections.Generic;
using SENAIzinho_2.classes;

namespace SENAIzinho_2 {
    class Program {

        enum MenuEnum : uint {

            CADASTRAR_ALUNO = 1,
            CADASTRAR_PROFESSOR,
            CADASTRAR_SALA,
            ALOCAR_ALUNO,
            REMOVER_ALUNO,
            ALOCAR_PROFESSOR,
            LISTAR_ALUNOS,
            LISTAR_SALAS,
            LISTAR_PROFESSORES,
            INICIAR_TURMA
            };

            static void Main (string[] args) {
                int limiteAlunos = 5;
                int limiteSalas = 2;
                int limiteProfessores = 2;

                Dictionary<string, Aluno> alunos = new Dictionary<string, Aluno>();
                Dictionary<int, Sala> salas = new Dictionary<int, Sala>();
                Dictionary<string, Professor> professores = new Dictionary<string, Professor>();

                string[] itensMenu = Enum.GetNames (typeof (MenuEnum));

                int alunosCadastrados = 0;
                int salasCadastradas = 0;
                int professoresCadastrados = 0;

                bool querSair = false;

            do {
                Console.Clear ();
                #region MENU_BUILDER
                // HEADER
                string menuBar = "===================================";
                System.Console.WriteLine (menuBar);
                Console.ForegroundColor = ConsoleColor.DarkRed;
                System.Console.WriteLine ("    Seja bem-vindo(a) ao SENAI     ");
                Console.ResetColor ();
                System.Console.WriteLine ("         Digite sua opção:         ");
                System.Console.WriteLine (menuBar);

                //BODY

                for (int i = 0; i < itensMenu.Length; i++) {
                    string espacosFim = "";
                    string bordaLinha = "||";
                    string paragrafoInicio = "   ";
                    string separadorOpcao = " - ";

                    string nomeTratado = itensMenu[i].Replace ("_", " ").ToLower ();
                    nomeTratado = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase (nomeTratado);
                    int espacoDezena = i / 10;
                    
                    string numeroOpcao = (i + 1).ToString();

                    if (espacoDezena < 1) {
                        paragrafoInicio = paragrafoInicio + " ";
                    }

                    int qntdeEspacos = menuBar.Length - (bordaLinha.Length * 2) - paragrafoInicio.Length - numeroOpcao.Length - separadorOpcao.Length - nomeTratado.Length;

                    for (int j = 0; j < qntdeEspacos; j++) {
                        espacosFim += " ";
                    }
                    
                    System.Console.WriteLine ($"{bordaLinha}{paragrafoInicio}{numeroOpcao}{separadorOpcao}{nomeTratado}{espacosFim}{bordaLinha}");
                }
                
                // FOOTER
                System.Console.WriteLine ("||           0 - Sair            ||");
                System.Console.WriteLine (menuBar);
                #endregion

                System.Console.Write ("Código: ");
                MenuEnum codigo = (MenuEnum) Enum.Parse (typeof (MenuEnum), Console.ReadLine ());

                string mensagem = "";

                switch (codigo) {
                    #region CADASTRAR_ALUNO
                    case MenuEnum.CADASTRAR_ALUNO:
                        if (limiteAlunos != alunosCadastrados) {
                            Aluno a = new Aluno ();
                            System.Console.Write ("Digite o nome do aluno: ");
                            a.Nome = Console.ReadLine ();

                            System.Console.Write ("Digite a data de nascimento: ");
                            a.DataNascimento = DateTime.Parse (Console.ReadLine ());

                            a.Curso = ExibirMenuCursos();

                            alunos.Add(a.Nome, a);

                            alunosCadastrados++;

                            MostrarMensagem ($"\nCadastro de {a.GetType().Name} concluído!", TipoMensagemEnum.SUCESSO);

                        } else {
                            MostrarMensagem ($"\nLimite de alunos cadastrados atingido", TipoMensagemEnum.ERRO);
                        }

                        break;
                    #endregion
                    #region CADASTRAR_SALA
                    case MenuEnum.CADASTRAR_SALA:
                        if (limiteSalas != salasCadastradas) {
                            System.Console.Write("Digite o numero da sala: ");
                            int numeroSala = int.Parse (Console.ReadLine ());

                            System.Console.Write("Digite a capacidade total da sala: ");
                            int capacidadeTotal = int.Parse (Console.ReadLine ());

                            Sala s = new Sala (capacidadeTotal, numeroSala);

                            salas.Add(s.NumeroSala, s);

                            salasCadastradas++;

                            MostrarMensagem ($"\nCadastro de {s.GetType().Name} concluído!", TipoMensagemEnum.SUCESSO);
                        } else {
                            MostrarMensagem ("\nNão há mais espaço para salas!", TipoMensagemEnum.ERRO);
                        }

                        break;
                        #endregion
                    #region ALOCAR_ALUNO
                    case MenuEnum.ALOCAR_ALUNO:
                        if (!ValidarAlocarOuRemover (alunosCadastrados, salasCadastradas, professoresCadastrados)) {
                            continue;
                        }

                        System.Console.WriteLine ("Digite o nome do aluno");
                        string nome = Console.ReadLine ();
                        
                        Aluno alunoAchado = null;

                        System.Console.WriteLine ("Digite o numero da sala");
                        int numSala = int.Parse (Console.ReadLine ());

                        Sala salaAchada = null;

                        if (alunos.TryGetValue(nome, out alunoAchado)  && salas.TryGetValue (numSala, out salaAchada)) {
                            if (salaAchada.AlocarAluno (alunoAchado, out mensagem)) {
                                MostrarMensagem (mensagem, TipoMensagemEnum.SUCESSO);
                                alunoAchado.NumeroSala = numSala;
                            } else {
                                MostrarMensagem (mensagem, TipoMensagemEnum.ALERTA);
                            }
                        } else {
                            MostrarMensagem ($"Não foi possível alocar {nome}! Verifique o número da sala e o nome do aluno", TipoMensagemEnum.ERRO);
                        }

                        break;
                        #endregion
                    #region REMOVER_ALUNO
                    case MenuEnum.REMOVER_ALUNO:
                        if (!ValidarAlocarOuRemover (alunosCadastrados, salasCadastradas, professoresCadastrados)) {
                            continue;
                        }

                        System.Console.WriteLine ("Digite o nome do aluno");
                        string nomeAluno = Console.ReadLine ();

                        
                        foreach (var item in salas.Values) {
                            if (item != null) {
                                if (item.RemoverAluno (nomeAluno, out mensagem)) {
                                    MostrarMensagem (mensagem, TipoMensagemEnum.SUCESSO);
                                } else {
                                    MostrarMensagem (mensagem, TipoMensagemEnum.ERRO);
                                }
                            }
                        }

                        break;
                        #endregion
                    #region LISTAR_SALAS
                    case MenuEnum.LISTAR_SALAS:

                        Console.ForegroundColor = ConsoleColor.Blue;
                        System.Console.WriteLine ("Listando todas as salas");
                        Console.ResetColor ();
                        foreach (var item in salas.Values) {
                            if (item != null) {
                                System.Console.WriteLine ("-----------------------------------------------------");
                                System.Console.WriteLine ($"Número da sala: {item.NumeroSala}");
                                System.Console.WriteLine ($"Vagas disponíveis: {item.CapacidadeAtual}");
                                System.Console.WriteLine ($"Alunos: {item.MostrarAlunos()}");
                                System.Console.WriteLine ("-----------------------------------------------------");
                            }
                        }

                        System.Console.WriteLine ("Aperte ENTER para voltar ao menu principal");
                        Console.ReadLine ();

                        break;
                        #endregion
                    #region LISTAR_ALUNOS
                    case MenuEnum.LISTAR_ALUNOS:

                        Console.ForegroundColor = ConsoleColor.Blue;
                        System.Console.WriteLine ("Listando todos os alunos");
                        Console.ResetColor ();
                        foreach (var item in alunos.Values) {
                            if (item != null) {
                                System.Console.WriteLine ("-----------------------------------------------------");
                                System.Console.WriteLine ($"Nome: {item.Nome}");
                                System.Console.WriteLine ($"Sala: {item.NumeroSala}");
                                System.Console.WriteLine ($"Curso: {item.Curso}");
                                System.Console.WriteLine ("-----------------------------------------------------");
                            }
                        }

                        System.Console.WriteLine ("Aperte ENTER para voltar ao menu principal");
                        Console.ReadLine ();

                        break;
                        #endregion
                    #region SAIR
                    case 0:
                        querSair = true;
                        MostrarMensagem ("Até logo!", TipoMensagemEnum.MENSAGEM);
                        break;
                        #endregion
                    #region CADASTRAR_PROFESSOR
                    case MenuEnum.CADASTRAR_PROFESSOR:
                        if (limiteProfessores != professoresCadastrados) {
                            Professor p = new Professor ();
                            System.Console.Write ("Digite o nome do professor: ");
                            p.Nome = Console.ReadLine ();

                            System.Console.Write("Digite a data de nascimento: ");
                            p.DataNascimento = DateTime.Parse (Console.ReadLine ());

                            p.Curso = ExibirMenuCursos();

                            professores.Add(p.Nome, p);

                            professoresCadastrados++;

                            MostrarMensagem ($"\nCadastro de {p.GetType().Name} concluído!", TipoMensagemEnum.SUCESSO);

                        } else {
                            MostrarMensagem ($"\nLimite de professores cadastrados atingido", TipoMensagemEnum.ERRO);
                        }

                        break;
                        #endregion
                    #region LISTAR_PROFESSORES
                    case MenuEnum.LISTAR_PROFESSORES:

                        Console.ForegroundColor = ConsoleColor.Blue;
                        System.Console.WriteLine ("Listando todos os professores");
                        Console.ResetColor ();
                        foreach (var item in professores.Values) {
                            if (item != null) {
                                System.Console.WriteLine ("-----------------------------------------------------");
                                System.Console.WriteLine ($"Nome: {item.Nome}");
                                System.Console.WriteLine ($"Sala: {item.NumeroSala}");
                                System.Console.WriteLine ($"Curso: {item.Curso}");
                                System.Console.WriteLine ("-----------------------------------------------------");
                            }
                        }

                        System.Console.WriteLine ("Aperte ENTER para voltar ao menu principal");
                        Console.ReadLine ();
                        break;
                        #endregion
                    #region INICIAR_TURMA
                    case MenuEnum.INICIAR_TURMA:

                        System.Console.WriteLine ("Digite o número da sala cuja turma deve começar:");
                        int codigoSala = int.Parse (Console.ReadLine ());
                        Sala salaTurma = null;

                        foreach (var item in salas.Values) {
                            if (item != null && item.NumeroSala == codigoSala) {
                                salaTurma = item;
                            }
                        }

                        if (salaTurma != null) {
                            if (salaTurma.PodeIniciarTurma (out mensagem)) {
                                MostrarMensagem (mensagem, TipoMensagemEnum.SUCESSO);
                            } else {
                                MostrarMensagem (mensagem, TipoMensagemEnum.ERRO);
                            }
                        } else {
                            MostrarMensagem ("Essa sala não existe", TipoMensagemEnum.ERRO);
                        }
                        break;
                        #endregion
                    #region ALOCAR_PROFESSOR
                    case MenuEnum.ALOCAR_PROFESSOR:
                        if (!ValidarAlocarOuRemover (alunosCadastrados, salasCadastradas, professoresCadastrados)) {
                            continue;
                        }

                        System.Console.WriteLine ("Digite o nome do professor");
                        string nomeProfessor = Console.ReadLine ();
                        Professor professorAchado = null;
                        

                        System.Console.WriteLine ("Digite o numero da sala");
                        int numSalaProfessor = int.Parse (Console.ReadLine ());

                        Sala salaAchadaProfessor = null;

                        if (professores.TryGetValue(nomeProfessor, out professorAchado) && salas.TryGetValue(numSalaProfessor, out salaAchadaProfessor)) {
                            if (salaAchadaProfessor.AlocarProfessor (professorAchado, out mensagem)) {
                                MostrarMensagem (mensagem, TipoMensagemEnum.SUCESSO);
                                professorAchado.NumeroSala = numSalaProfessor;
                            } else {
                                MostrarMensagem (mensagem, TipoMensagemEnum.ALERTA);
                            }
                        } else {
                            MostrarMensagem ($"Não foi possível alocar {nomeProfessor}! Verifique o número da sala e o nome do professor", TipoMensagemEnum.ERRO);
                        }

                        break;
                        #endregion
                    default:
                        MostrarMensagem ("Opção inexistente!", TipoMensagemEnum.ALERTA);
                        break;
                }

            } while (!querSair);
        }

        static bool ValidarAlocarOuRemover (int alunosCadastrados, int salasCadastradas, int professoresCadastrados) {
            if (alunosCadastrados == 0) {
                MostrarMensagem ("Não há alunos cadastrados", TipoMensagemEnum.ALERTA);
                return false;
            }

            if (salasCadastradas == 0) {
                MostrarMensagem ("Não há salas cadastradas", TipoMensagemEnum.ALERTA);
                return false;
            }

            if (professoresCadastrados == 0) {
                MostrarMensagem ("Não há professores cadastrados", TipoMensagemEnum.ALERTA);
                return false;
            }

            return true;
        }
        static void MostrarMensagem (string mensagem, TipoMensagemEnum tipoMensagem) {

            switch (tipoMensagem) {
                case TipoMensagemEnum.ERRO:
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
                case TipoMensagemEnum.SUCESSO:
                    Console.ForegroundColor = ConsoleColor.Green;
                    break;
                case TipoMensagemEnum.ALERTA:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    break;
                case TipoMensagemEnum.MENSAGEM:
                    Console.ForegroundColor = ConsoleColor.Blue;
                    break;
                default:
                    break;
            }

            System.Console.WriteLine (mensagem);
            Console.ResetColor ();

            System.Console.WriteLine ("\nAperte ENTER para voltar ao menu principal");
            Console.ReadLine ();
        }
        static Sala ProcurarSalaPorNumero (int numero, Sala[] colecao) {
            foreach (var item in colecao) {
                if (item != null && numero.Equals (item.NumeroSala)) {
                    return item;
                }
            }
            return null;
        }
        static Aluno ProcurarAlunoPorNome (string nome, Aluno[] colecao) {
            foreach (var item in colecao) {
                if (item != null && nome.Equals (item.Nome)) {
                    return item;
                }
            }
            return null;
        }
        static Professor ProcurarProfessorPorNome (string nome, Professor[] professores) {
            foreach (var item in professores) {
                if (item != null && nome.Equals (item.Nome)) {
                    return item;
                }
            }
            return null;
        }
        static string ExibirMenuCursos() {
            bool cursoEscolhido = false;
            string curso = "";
            do {
                System.Console.WriteLine (" ===================================");
                System.Console.WriteLine (" #    Digite o código do curso     #");
                System.Console.WriteLine (" #     1 - DESENVOLVIMENTO         #");
                System.Console.WriteLine (" #     2 - REDES                   #");
                System.Console.WriteLine (" ===================================");
                System.Console.Write ("Código: ");
                int codigoCurso = int.Parse(Console.ReadLine());

                switch(codigoCurso) {
                    case 1:
                        curso = "DESENVOLVIMENTO";
                        cursoEscolhido = true;
                    break;
                    case 2:
                        curso = "REDES";
                        cursoEscolhido = true;
                    break;
                    default:
                        MostrarMensagem("Esse código não existe!", TipoMensagemEnum.ERRO);
                    break;
                }
                
            } while(!cursoEscolhido);
            return curso;
        }
    }
}