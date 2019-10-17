using System;
using EscolaDeRock.Interfaces;

namespace EscolaDeRock.Models
{
    public class Baixo : InstrumentoMusical, IPercussao, IHarmonia
    {
        public bool ManterRitmo()
        {
            Console.WriteLine("Mantendo ritmo do Baixo.");
            return true;
        }

        public bool TocarAcordes()
        {
            Console.WriteLine("Tocando acordes de Baixo.");
            return true;
        }
    }
}
