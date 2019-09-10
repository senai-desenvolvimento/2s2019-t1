using System;

namespace TsukaAirlines
{
    public class Passageiro
    {
        string nome;
        int numeroPassagem;
        DateTime data;

        public void setNome(string nome) {
            this.nome = nome;
        }

        public string getNome() {
            return this.nome;
        }



    }
}