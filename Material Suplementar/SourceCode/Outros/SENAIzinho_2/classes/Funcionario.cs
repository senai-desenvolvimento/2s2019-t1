using System;

namespace SENAIzinho_2.classes
{
    public abstract class Funcionario
    {
        public static ulong Id {get; private set;}
        public string Nome {get; set;}
        public DateTime DataNascimento {get; set;}

        public Funcionario() {
            Id = Id++;
        }

        public abstract void Trabalhar();

        public virtual double ValorSalario() {
            return 500.0;
        }

    }
}