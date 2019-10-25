using Reciclagem2.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Reciclagem2.Models
{
    class GarrafaPET : Lixo, IPlastico
    {
        public GarrafaPET(string nome) : base(nome)
        {

        }
    }
}
