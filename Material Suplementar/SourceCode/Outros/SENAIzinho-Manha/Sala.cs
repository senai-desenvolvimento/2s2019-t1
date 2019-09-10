namespace SENAIzinho_Manha {
    public class Sala {
        public int numeroSala;
        public int capacidadeAtual;
        public int capacidadeTotal;
        public string[] alunos;

        public string AlocarAluno (string nomeAluno) {
            if (capacidadeAtual > 0) {
                capacidadeAtual--;
                for (int i = 0; i < alunos.Length; i++) {
                    if (alunos[i] == null || "".Equals(alunos[i])) 
                    {
                        alunos[i] = nomeAluno;
                        return $"Aluno {nomeAluno} alocado com sucesso!";
                    }    
                }
            } else {
                return $"Capacidade da sala {numeroSala} excedida!";
            }
            return "Não foi possível cadastrar";
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

        public string ExibirAlunos () {
            string nomesAlunos = "";
            foreach (var item in alunos) {
                if (item != null) {
                    nomesAlunos += item + " ";
                }
            }
            return nomesAlunos;
        }

    }
}