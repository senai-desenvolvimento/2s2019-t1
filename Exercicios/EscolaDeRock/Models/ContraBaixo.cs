using System;
using EscolaDeRock.Interfaces;

namespace EscolaDeRock.Models
{
    class ContraBaixo:InstrumentoMusical,IPercussao,IHarmonia
    {
        public bool ManterRitmo()
        {
            Console.WriteLine("Mantendo ritmo do Contrabaixo.");
            return true;
        }

        public bool TocarAcordes()
        {
            Console.WriteLine("Tocando acordes de Contrabaixo.");
            return true;
        }
    }
}
