namespace McBonaldsMVC.Models
{
    public class Hamburguer : Produto
    {
        public Hamburguer()
        {

        }

        public Hamburguer(string nome, double preco)
        {
            this.Nome = nome;
            this.Preco = preco;
        }
    }
}