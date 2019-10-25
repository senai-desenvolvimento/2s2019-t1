using System;
using System.Collections.Generic;
using System.Text;

namespace Reciclagem2.Models
{
    public class Lixeira
    {
        public static Dictionary<int, Lixo> lixos = new Dictionary<int, Lixo> {
            {1, new Garrafa("Garrafa de Vidro")},
            {2, new Papelao("Papelão")},
            {3, new PoteManteiga("Pote de Manteiga")},
            {4, new GuardaChuva("Guarda Chuva")},
            {5, new GarrafaPET("Garrafa PET")},
            {6, new Latinha("Latinha")},
        };
    }
}
