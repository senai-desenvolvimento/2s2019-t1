using Reciclagem.Interfaces;

namespace Reciclagem.Models
{
    public class Papelao : Lixo, IPapel
    {
        public string ReciclarFeitoPapel()
        {
            return this.GetType().Name;
        }
    }
}