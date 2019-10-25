using Reciclagem2.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Reciclagem2.Models
{
    class Latinha : Lixo, IMetal
    {
        public Latinha(string nome) : base(nome) { }
    }
}
