using System;
using McBonaldsMVC.Enums;

namespace McBonaldsMVC.Models
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
        public uint TipoCliente {get; set;}

        public Cliente () {
            this.TipoCliente = (uint) TipoClienteEnum.USUARIO;
        }

        // Construtor simples, só pra montar um cliente do objeto Pedido
        public Cliente(string nome, string endereco, string telefone, string email)
        {
            this.Nome = nome;
            this.Endereco = endereco;
            this.Telefone = telefone;
            this.Email = email;
        }

        // Construtor usado para monstar o objeto a partir da extração do CSV
        public Cliente (string[] registroCliente) 
        {
            this.ID = ulong.Parse(registroCliente[0]);
            this.Nome = registroCliente[1];
            this.Email = registroCliente[2];
            this.Senha = registroCliente[3];
            this.Endereco = registroCliente[4];
            this.Telefone = registroCliente[5];
            this.DataNascimento = DateTime.Parse(registroCliente[6]);
            this.TipoCliente = (uint) TipoClienteEnum.USUARIO;
        }

    }
}