using System.Collections.Generic;

namespace Reciclagem.Models
{
    public class Lixeira
    {
        public static Dictionary<int, Lixo> lixos = new Dictionary<int, Lixo> {
            {1, new Garrafa()},
            {2, new Papelao()},
            {3, new PoteManteiga()},
            {4, new GuardaChuva()},
            {5, new GarrafaPET()},
            {6, new Latinha()},
        };
    }
}