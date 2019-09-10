using System.ComponentModel;
using System;
using System.Collections.Generic;

namespace Listas
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> lista = new List<string>();
            
            lista.Add("Cesar");
            lista.Add("Fulano");
            
            System.Console.WriteLine(lista.Count);

            lista.Remove("Cesar");
            System.Console.WriteLine(lista.Count);
        }
    }
}
