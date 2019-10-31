using System;
using McBonaldsMVC.Enums;

namespace McBonaldsMVC.Models
{
    public class Shake : Produto
    {
        public CoberturaShakeEnum Cobertura {get;set;}

        public Shake()
        {

        }

        public Shake(string[] dados) 
        {
            this.Id = ulong.Parse(dados[0]);
            this.Nome = dados[1];
            this.Preco = double.Parse(dados[2]);
        }

        public override double AplicarDesconto()
        {
            return this.Preco * 0.15;
        }

        public override bool VerificarVencimentoDeProduto()
        {
            if (this.DataFabricacao.Subtract(DateTime.Today).Days > 2) {
                return true;
            }
            return false;
        } 
    }
}