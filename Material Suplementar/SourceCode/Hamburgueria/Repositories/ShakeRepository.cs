using System.Collections.Generic;
using System.IO;
using Hamburgueria.Models;

namespace Hamburgueria.Repositories
{
    public class ShakeRepository
    {
        public static uint CONT_SHAKE = 0;
        private const string PATH = "Database/Shake.csv";
        private List<Shake> shakes = new List<Shake> ();

        public double ObterPrecoDe(string nomeShake) 
        {
            var lista = ObterTodos();
            var preco = 0.0;
            foreach (var item in lista)
            {
                if (item.Nome.Equals(nomeShake)) 
                {
                    preco = item.Preco;
                }
                    
            }
            return preco;
        }

        public List<Shake> ObterTodos () {
            var linhas = ObterRegistros ();
            foreach (var item in linhas) {

                Shake shake = ConverterEmObj (item);

                this.shakes.Add (shake);
            }
            return this.shakes;
        }

        private Shake ConverterEmObj (string registro) {
            var registroSeparado = registro.Split (";");
            return new Shake (registroSeparado);
        }

        private string[] ObterRegistros () {
            return File.ReadAllLines (PATH);
        }

        private ulong ExtrairID (string registro) {
            return ulong.Parse (registro.Split () [0]);
        }
    }
}