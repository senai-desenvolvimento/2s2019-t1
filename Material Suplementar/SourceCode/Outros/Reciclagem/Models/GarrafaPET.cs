using Reciclagem.Interfaces;

namespace Reciclagem.Models
{
    public class GarrafaPET : Lixo, IPlastico
    {
        public string ReciclarFeitoPlastico()
        {
            return this.GetType().Name;
        }
    }
}