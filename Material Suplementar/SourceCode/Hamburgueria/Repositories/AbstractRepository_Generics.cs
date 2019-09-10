using System.Linq.Expressions;
using System.Collections.Generic;
using System.IO;
using System;

namespace Hamburgueria.Repositories
{
    public abstract class AbstractRepository<T>
    {
        protected List<T> Conjunto = new List<T>();
        protected ulong CONT = 0;
        protected string PATH {
            get {
                return "Database/" + this.GetType().Name.Replace("Repository", "");
            }
        }
        
        public abstract bool Inserir (T t);

        public abstract bool Atualizar (T t);

        public abstract bool Apagar (ulong id);

        public abstract T ObterPor (ulong id);

        protected abstract T ConverterEmObjeto (string registro);

        protected abstract string PrepararRegistroCSV (T t, ulong CONT);

        public virtual List<T> ListarTodos () {
            var linhas = ObterRegistrosCSV ();

            foreach (var item in linhas) {
                T t = ConverterEmObjeto (item);
                this.Conjunto.Add (t);
            }

            return this.Conjunto;
        }

        protected string[] ObterRegistrosCSV () {
            return File.ReadAllLines (PATH);
        }

        protected string ExtrairCampo (string nomeCampo, string linha) {
            var chave = nomeCampo;
            var indiceChave = linha.IndexOf(chave);
            var indiceTerminal = linha.IndexOf(";", indiceChave);
            var valor = "";
            
            if (indiceTerminal != -1) {
                valor = linha.Substring(indiceChave, indiceTerminal - indiceChave);
            } else {
                valor = linha.Substring(indiceChave);
            }
            
            return valor;
        }
    }
}