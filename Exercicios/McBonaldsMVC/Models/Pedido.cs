using System;

namespace McBonaldsMVC.Models
{
    public class Pedido
    {
        public Cliente Cliente {get;set;}

        public Hamburguer Hamburguer {get;set;}

        public Shake Shake {get;set;}

        public DateTime DataDoPedido {get;set;}

        public double PrecoTotal {get;set;}

        public Pedido()
        {
            this.Cliente = new Cliente();
            this.Hamburguer = new Hamburguer();
            this.Shake = new Shake();
        }
    }
}