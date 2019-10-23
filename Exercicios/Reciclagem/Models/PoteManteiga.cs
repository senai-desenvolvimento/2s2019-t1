using Reciclagem.Interfaces;

namespace Reciclagem.Models
{
    public class PoteManteiga : Lixo, IPlastico
    {
        public string ReciclarFeitoPlastico()
        {
            return this.GetType().Name;
        }
    }
}