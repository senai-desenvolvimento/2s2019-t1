using System;
using EscolaDeRock.Interfaces;

namespace EscolaDeRock.Models
{
    public class Teclado : InstrumentoMusical, IMelodia, IHarmonia
    {
        public bool TocarAcordes()
        {
            Console.WriteLine("Tocando acordes de Teclado.");
            return true;
        }

        public bool TocarSolo()
        {
            Console.WriteLine("Tocando solo de Teclado");
            return true;
        }
    }
}
