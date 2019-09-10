using SENAIzinho_2.classes;

namespace SENAIzinho_2 {
    public class Sala {
        public int CapacidadeAtual { get; private set; }
        public int CapacidadeTotal { get; }
        public int NumeroSala { get; private set; }
        public Aluno[] Alunos { get; }
        public Professor[] Professores { get; }
        public Sala (int capacidade, int numeroSala) {
            this.CapacidadeTotal = capacidade;
            this.CapacidadeAtual = capacidade;
            this.Alunos = new Aluno[capacidade];
            this.Professores = new Professor[2];
            this.NumeroSala = numeroSala;
        }

        public bool AlocarAluno (Aluno aluno, out string mensagem) {
            if (CapacidadeAtual != 0) {
                CapacidadeAtual--;
                Alunos[CapacidadeAtual] = aluno;
                mensagem = $"Aluno {aluno.Nome} cadastrado com sucesso!";
                return true;
            } else {
                mensagem = "Não há vagas!";
                return false;
            }
        }

        public bool RemoverAluno (string nome, out string mensagem) {
            for (int i = 0; i < Alunos.Length; i++) {
                if (Alunos[i] != null && nome.Equals (Alunos[i])) {
                    Alunos[i] = null;
                    CapacidadeAtual++;
                    mensagem = $"Aluno {nome} removido com sucesso!";
                    return true;
                }
            }
            mensagem = $"Não foi possível remover o aluno {nome}";
            return false;
        } 

        public bool PodeIniciarTurma (out string mensagem) {
            if (TemProfessor () && TemAluno ()) {
                mensagem = $"Turma da sala {NumeroSala} foi iniciada com sucesso!";
                return true;
            } else {
                mensagem = $"Turma não pode ser iniciada!";
                return false;
            }
        }

        public bool TemProfessor () {
            foreach (var item in Professores) {
                if (item != null)
                    return true;
            }
            return false;
        }

        public bool TemAluno () {
            foreach (var item in Alunos) {
                if (item != null)
                    return true;
            }
            return false;
        }

        public bool AlocarProfessor (Professor professor, out string m) {
            if (this.Professores[0] == null) {
                this.Professores[0] = professor;
                m = $"Professor {professor.Nome} alocado com sucesso!";
                return true;
            } else if (this.Professores[1] == null) {
                this.Professores[1] = professor;
                m = $"Professor {professor.Nome} alocado com sucesso!";
                return true;
            } else {
                m = $"Não foi possível alocar o professor {professor.Nome}";
                return false;
            }
            
        }

        public string MostrarAlunos () {
            string todos = "";
            foreach (var item in Alunos) {
                if (item != null) {
                    todos += item.Nome + " ";
                }
            }
            return todos;
        }

    }
}