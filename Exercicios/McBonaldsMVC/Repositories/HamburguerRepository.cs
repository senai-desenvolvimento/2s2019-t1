using System.Collections.Generic;
using System.IO;
using McBonaldsMVC.Models;

namespace McBonaldsMVC.Repositories
{
    public class HamburguerRepository
    {
        public static uint CONT_HAMBURGUER = 0;
        private const string PATH = "Database/Hamburguer.csv";
        private List<Hamburguer> hamburgueres = new List<Hamburguer> ();

        public List<Hamburguer> ObterTodos () 
        {
            var linhas = ObterRegistros ();
            foreach (var item in linhas) 
            {
                Hamburguer hamburguer = ConverterEmObj (item);
                this.hamburgueres.Add (hamburguer);
            }
            return this.hamburgueres;
        }

        public double ObterPrecoDe(string nomeHamburguer) 
        {
            var lista = ObterTodos();
            var preco = 0.0;
            foreach (var item in lista)
            {
                if (item.Nome.Equals(nomeHamburguer)) 
                {
                    preco = item.Preco;
                }
                    
            }
            return preco;
        }

        private Hamburguer ConverterEmObj (string registro) {
            var registroSeparado = registro.Split (";");
            return new Hamburguer (registroSeparado);
        }

        private string[] ObterRegistros () {
            return File.ReadAllLines (PATH);;
        }

        private ulong ExtrairID (string registro) {
            return ulong.Parse (registro.Split () [0]);
        }
    }
}