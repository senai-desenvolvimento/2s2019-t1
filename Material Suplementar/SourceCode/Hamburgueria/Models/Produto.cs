using System;

namespace Hamburgueria.Models
{
    public abstract class Produto
    {
        protected ulong Id { get;set; }
        public string Nome { get; set; }
        public double Preco { get; set; }
        public DateTime DataFabricacao { get; set; }
        
        public abstract double AplicarDesconto();

        public virtual bool VerificarVencimentoDeProduto()
        {
            if (this.DataFabricacao.Subtract(DateTime.Today).Days > 1) {
                return true;
            }
            return false;
        }


    }
}