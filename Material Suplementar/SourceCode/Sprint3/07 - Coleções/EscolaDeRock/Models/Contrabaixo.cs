using EscolaDeRock.Interfaces;

namespace EscolaDeRock.Models
{
    public class Contrabaixo : InstrumentoMusical, IPercussao, IHarmonia
    {
        public bool ManterRitmo()
        {
            System.Console.WriteLine("Mantendo ritmo do Contrabaixo");
            return true;
        }

        public bool TocarAcordes()
        {
            System.Console.WriteLine("Tocando acordes do Contrabaixo");
            return true;
        }
    }
}