using EscolaDeRock.Interfaces;

namespace EscolaDeRock.Models
{
    public class Piano : InstrumentoMusical,  IMelodia, IHarmonia
    {
        public bool TocarAcordes()
        {
            System.Console.WriteLine("Tocando acordes do Piano");
            return true;
        }

        public bool TocarSolo()
        {
           System.Console.WriteLine("Tocando solo acordes da Guitarra");
            return true;
        }
    }
}