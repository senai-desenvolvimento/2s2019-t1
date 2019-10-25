namespace Reciclagem2.Models
{
    public abstract class Lixo
    {
        private string _nome;

        public Lixo(string nome)
        {
            _nome = nome;
        }

        public virtual string Reciclar()
        {
            return _nome;
        }
    }
}
