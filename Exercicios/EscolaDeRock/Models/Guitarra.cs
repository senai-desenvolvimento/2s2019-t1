using System;
using EscolaDeRock.Interfaces;

namespace EscolaDeRock.Models
{
    public class Guitarra : InstrumentoMusical, IMelodia, IHarmonia
    {
        public bool TocarAcordes()
        {
            Console.WriteLine("Tocando acordes de Guitarra.");
            return true;
        }

        public bool TocarSolo()
        {
            Console.WriteLine("Tocando solo de Guitarra.");
            return true;
        }
    }
}
