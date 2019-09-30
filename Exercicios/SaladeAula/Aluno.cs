using System;
using System.Collections.Generic;
using System.Text;

namespace SaladeAula
{
    class Aluno
    {
        //Atributos da Classe Alunos.
        public string nome { get; set; }    //Nome do aluno
        public string dtNasc { get; set; }  //Data de Nascimento do Aluno
        public string cpf { get; set; }     //Documento de identificação do Aluno
        public string curso { get; set; }   //Curso.
        private double[] notas = { 0, 0, 0, 0 };    //Vetor contendo as notas bimestrais

        //Construtores
        public Aluno(string nome,string cpf)
        {
            this.nome = nome;
            this.cpf  = cpf;
        }

        public Aluno(string nome, string cpf, string curso)
        {
            this.nome = nome;
            this.cpf = cpf;
            this.curso = curso;
        }

        //Métodos de Acesso
        public double[] getNotas()
        {
            return notas;
        }

        public void setNotas(int bimestre, double nota)
        {
            int i = bimestre - 1;
            if ((i < 0) || (i > 4))
            {
                //Condição de Erro;
                throw new ArgumentOutOfRangeException($"{nameof(setNotas)} must be between 1 and 4.");
            }
            else if (nota < 0 || nota > 10)
            {
                //Condição de Erro;
                throw new ArgumentOutOfRangeException($"{nameof(setNotas)} must be between 0 and 10.");
            }
            else
            {
                notas[i] = nota;
            }
        }
   
        //Metodos
        void Estudar() { }
        void Conversar() { }
        void Perguntar() { }
        void Chorar_Prazos() { }
        void Chorar_Notas() { }
        void Chorar_Pelos_Cantos() { }

    }
}
