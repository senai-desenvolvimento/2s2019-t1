using McBonaldsMVC.Enums;

namespace McBonaldsMVC.Models
{
    
    public class Hamburguer : Produto
    {
        public PontoCarneEnum PontoDaCarne {get;set;}
        
        public Hamburguer()
        {
            
        }

        public Hamburguer(string[] dados) 
        {
            this.Id = ulong.Parse(dados[0]);
            this.Nome = dados[1];
            this.Preco = double.Parse(dados[2]);
        }

        public override double AplicarDesconto()
        {
            return this.Preco * 1;
        }
    }
}