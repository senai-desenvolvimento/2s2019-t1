using System;
using System.IO;
using McBonaldsMVC.Models;

namespace McBonaldsMVC.Repositories {
    public class ClienteRepository : RepositoryBase
    {
        private const string PATH = "Database/Cliente.csv";
        public ClienteRepository () {
            if (!File.Exists (PATH)) {
                File.Create (PATH).Close ();
            }
        }
        public bool Inserir (Cliente cliente) 
        {
            var linha = new string[] { PrepararRegistroCSV(cliente) };
            File.AppendAllLines(PATH, linha);
            
            return true;
        }

        public Cliente ObterPor(string email)
        {
            var linhas = File.ReadAllLines(PATH);
            foreach(var linha in linhas)
            {
                if(ExtrairValorDoCampo("email", linha).Equals(email))
                {
                    Cliente c = new Cliente();
                    c.Nome = ExtrairValorDoCampo("nome", linha);
                    c.Email = ExtrairValorDoCampo("email", linha);
                    c.Senha = ExtrairValorDoCampo("senha", linha);
                    c.Endereco = ExtrairValorDoCampo("endereco", linha);
                    c.Telefone = ExtrairValorDoCampo("telefone", linha);
                    c.DataNascimento = DateTime.Parse(ExtrairValorDoCampo("data_nascimento", linha));
                
                    return c;
                }
            }
            return null;
        }

        private string PrepararRegistroCSV(Cliente cliente)
        {
            return $"nome={cliente.Nome};email={cliente.Email};senha={cliente.Senha};endereco={cliente.Endereco};telefone={cliente.Telefone};data_nascimento={cliente.DataNascimento}";
        }

        
    }
}