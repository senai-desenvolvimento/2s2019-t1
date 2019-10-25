using Reciclagem2.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Reciclagem2.Models
{
    class GuardaChuva : Lixo, IIndefinido
    {
        public GuardaChuva(string nome) : base(nome)
        {

        }
    }
}
