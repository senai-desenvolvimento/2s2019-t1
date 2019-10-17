using System.Collections.Generic;
namespace EscolaDeRock.Models
{
    public class Deposito
    {
        public static Dictionary<int, InstrumentoMusical> Instrumentos = new Dictionary<int, InstrumentoMusical>() {
            { 1, new Baixo() },
            { 2, new Bateria() },
            { 3, new ContraBaixo() },
            { 4, new Guitarra() },
            { 5, new Teclado() },
            { 6, new Tambores() },
            { 7, new Violao() }

        };
    }
}