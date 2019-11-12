using McBonaldsMVC.Enums;

namespace McBonaldsMVC.Models
{
    
    public class Hamburguer : Produto
    {
        //TODO: Implementar essa opção
        public PontoCarneEnum PontoDaCarne {get;set;}
        
        public Hamburguer()
        {
            
        }

        public Hamburguer(string nome, double preco)
        {
            this.Nome = nome;
            this.Preco = preco;
        }

        // Construtor usado para monstar o objeto a partir da extração do CSV
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