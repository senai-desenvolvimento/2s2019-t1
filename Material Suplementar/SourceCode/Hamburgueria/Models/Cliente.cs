using System;

namespace Hamburgueria.Models
{
    public class Cliente
    {
        public ulong ID;
        public string Nome {get;set;}
        public string Endereco {get;set;}
        public string Telefone {get;set;}
        public string Senha {get;set;}
        public string Email {get;set;}
        public DateTime DataNascimento {get;set;}

        public Cliente () {
        }

        public Cliente (string[] registroCliente) 
        {
            this.ID = ulong.Parse(registroCliente[0]);
            this.Nome = registroCliente[1];
            this.Email = registroCliente[2];
            this.Senha = registroCliente[3];
            this.Endereco = registroCliente[4];
            this.Telefone = registroCliente[5];
            this.DataNascimento = DateTime.Parse(registroCliente[6]);
        }
        
    }
}