using System.Collections.Generic;
using System.IO;
using McBonaldsMVC.Models;

namespace McBonaldsMVC.Repositories
{
    public class ShakeRepository
    {
        private const string PATH = "Database/Shake.csv";
        public double ObterPrecoDe(string nomeShake)
        {
            var lista = ObterTodos();
            var preco = 0.0;
            foreach (var item in lista)
            {
                if(item.Nome.Equals(nomeShake))
                {
                    preco = item.Preco;
                    break;
                }
            }
            return preco;
        }
        public List<Shake> ObterTodos()
        {
            List<Shake> shakes = new List<Shake>();
            var linhas = File.ReadAllLines(PATH);

            foreach (var linha in linhas)
            {
                Shake s = new Shake();
                var dados = linha.Split(";");
                s.Nome = dados[0];
                s.Preco = double.Parse(dados[1]);

                shakes.Add(s);
            }
            return shakes;
        }
    }
}