namespace ExCorrecaoSala {
    public class Sala {
        public int NumeroSala{get;set;}
        public int CapacidadeAtual{get;set;}
        public int CapacidadeTotal{get;set;}
        public string[] Alunos{get;set;}

        public string AlocarAluno(string nomeAluno) {
            if (CapacidadeAtual != 0) {
                CapacidadeAtual--;
                Alunos[CapacidadeAtual] = nomeAluno;
                return $"Aluno {nomeAluno} cadastrado com sucesso!";
            } else {
                return "Não há vagas!";
            }
        }

        public string RemoverAluno(string nomeAluno){
            for (int i = 0; i < Alunos.Length; i++)
            {
                if(Alunos[i] != null && nomeAluno.Equals(Alunos[i]))
                {
                    Alunos[i] = null;
                    CapacidadeAtual++;
                    return $"Aluno {nomeAluno} removido com sucesso!";
                } 
            }
            return $"Não foi possível remover o aluno {nomeAluno}";
        }
        
    }
}