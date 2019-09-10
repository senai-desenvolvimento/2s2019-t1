using EscolaDeRock.Interfaces;

namespace EscolaDeRock.Models
{
    public class Bateria : InstrumentoMusical, IPercussao
    {
        public bool ManterRitmo()
        {
            System.Console.WriteLine("Mantendo ritmo da Bateria");
            return true;
        }
    }
}