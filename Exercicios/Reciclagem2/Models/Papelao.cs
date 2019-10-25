using Reciclagem2.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Reciclagem2.Models
{
    class Papelao : Lixo, IPapel
    {
        public Papelao(string nome) : base(nome) { }
    }
}
