using System;
namespace Comparable {
    public class Pessoa : IComparable {
        public string nome { get; set; }
        public long cpf { get; set; }

        public int CompareTo(object obj)
        {   
            Pessoa pessoa = (Pessoa) obj;
            if (this.cpf == pessoa.cpf) {
                return 0;
            } else if (this.cpf > pessoa.cpf) {
                return 1;
            } else {
                return -1;
            }
        }

        // public override bool Equals(object obj) {
        //     Pessoa p = (Pessoa) obj;
        //     if (this.cpf == p.cpf) {
        //         return true;
        //     } else {
        //         return false;
        //     }
        // }

        public override string ToString() {
            return $"[Pessoa]Nome: {this.nome} / CPF: {this.cpf}";
        }
    }
}