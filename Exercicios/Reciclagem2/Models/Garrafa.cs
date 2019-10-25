using Reciclagem2.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Reciclagem2.Models
{
    class Garrafa : Lixo, IVidro
    {
        public Garrafa(string nome) : base(nome)
        { 
        }
    }
}
