namespace SENAIzinho {
    public class Sala {
        public int capacidadeAtual;
        public int capacidadeTotal;
        public int numeroSala;
        public string[] alunos;

        public string AlocarAluno (string nomeAluno) {
            if (capacidadeAtual > 0) {
                capacidadeAtual--;
                for (int i = 0; i < alunos.Length; i++) {
                    if (alunos[i] == null ||"".Equals (alunos[i])) {
                        alunos[i] = nomeAluno;
                        return $"Aluno {nomeAluno} alocado com sucesso!";
                    }
                }
            } else {
                return $"Capacidade da sala {numeroSala} excedida!";
            }
            return "Não foi possível alocar o aluno";
        }

        public string RemoverAluno (string nomeAluno) {
            for (int i = 0; i < alunos.Length; i++) {
                if (alunos[i] != null && nomeAluno.Equals (alunos[i])) {
                    alunos[i] = "";
                    capacidadeAtual++;
                    return $"Aluno {nomeAluno} removido com sucesso!";
                }
            }
            return $"{nomeAluno} não foi encontrado";
        }

        public string MostrarAlunos () {
            string todos = "";
            foreach (var item in alunos) {
                todos += item + " ";
            }
            return todos;
        }
    }
}