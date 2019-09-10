using Reciclagem.Interfaces;

namespace Reciclagem.Models
{
    public class Latinha : Lixo, IMetal
    {
        public string ReciclarFeitoMetal()
        {
            return this.GetType().Name;
        }
    }
}