using Reciclagem2.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Reciclagem2.Models
{
    class PoteManteiga : Lixo, IPlastico
    {
    public PoteManteiga(string nome) : base(nome) { }
    }
}
