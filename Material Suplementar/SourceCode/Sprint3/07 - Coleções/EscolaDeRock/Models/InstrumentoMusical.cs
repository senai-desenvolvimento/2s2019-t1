using System;
namespace EscolaDeRock.Models
{
    public class InstrumentoMusical
    {
        string[] notas = {"Do", "Ré", "Mi", "Fá", "Sol", "Lá", "Si"};

        protected string TocarMusica() {
            return notas[new Random().Next(notas.Length - 1)];
        }


    }
}