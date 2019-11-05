using Microsoft.Win32;
using System.Collections.Generic;
using System.IO;
using System.Security.AccessControl;
using McBonaldsMVC.Models;
using System.Text.RegularExpressions;
using System;
using McBonaldsMVC.Enums;

namespace McBonaldsMVC.Repositories
{
    public class ClienteRepository : BaseRepository
    {
        public static uint CONT = 0;
        private const string PATH = "Database/Cliente.csv";
        private const string PATH_INDEX = "Database/Cliente_Id.csv";
        private List<Cliente> clientes = new List<Cliente>();

        public ClienteRepository()
        {
            if (!File.Exists(PATH_INDEX))
            {
                File.Create(PATH_INDEX).Close();
            }

            var ultimoIndice = File.ReadAllText(PATH_INDEX);
            uint indice = 0;
            uint.TryParse(ultimoIndice, out indice);
            CONT = indice;
        }

        public bool Inserir(Cliente cliente)
        {
            CONT++;
            File.WriteAllText(PATH_INDEX, CONT.ToString());

            var linha = new string[] { PrepararRegistroCSV(cliente) };
            File.AppendAllLines(PATH, linha);

            return true;
        }

        public bool Atualizar(Cliente cliente)
        {
            var clientesRecuperados = ObterRegistrosCSV(PATH);
            var clienteString = PrepararRegistroCSV(cliente);
            var linhaCliente = -1;
            var resultado = false;

            for (int i = 0; i < clientesRecuperados.Length; i++)
            {
                if (clienteString.Equals(clientesRecuperados[i]))
                {
                    linhaCliente = i;
                    resultado = true;
                }
            }
            if (linhaCliente >= 0)
            {
                clientesRecuperados[linhaCliente] = clienteString;
                File.WriteAllLines(PATH, clientesRecuperados);
            }

            return resultado;

        }

        public bool Apagar(ulong id)
        {

            var clientesRecuperados = ObterRegistrosCSV(PATH);
            var linhaCliente = -1;
            var resultado = false;

            for (int i = 0; i < clientesRecuperados.Length; i++)
            {
                if (id.Equals(clientesRecuperados[i]))
                {
                    linhaCliente = i;
                    resultado = true;
                }
            }

            if (linhaCliente >= 0)
            {
                clientesRecuperados[linhaCliente] = "";
                try
                {
                    File.WriteAllLines(PATH, clientesRecuperados);

                }
                catch (DirectoryNotFoundException dnfe)
                {
                    System.Console.WriteLine("Diretório não encontrado. Favor verificar.");
                    System.Console.WriteLine(dnfe.StackTrace);
                }
                catch (PathTooLongException ptle)
                {
                    System.Console.WriteLine("Nome do arquivo é muito grande.");
                    System.Console.WriteLine(ptle.StackTrace);
                }
            }

            return resultado;
        }

        public Cliente ObterPor(ulong id)
        {

            foreach (var item in ObterRegistrosCSV(PATH))
            {
                if (id.Equals(ExtrairValorDoCampo(id.ToString(), item)))
                {
                    return ConverterEmObjeto(item);
                }
            }
            return null;
        }

        public Cliente ObterPor(string email)
        {

            foreach (var item in ObterRegistrosCSV(PATH))
            {
                if (email.Equals(ExtrairValorDoCampo("email", item)))
                {
                    return ConverterEmObjeto(item);
                }
            }
            return null;
        }

        public List<Cliente> ListarTodos()
        {
            var linhas = ObterRegistrosCSV(PATH);
            foreach (var item in linhas)
            {
                Cliente cliente = ConverterEmObjeto(item);
                this.clientes.Add(cliente);
            }
            return this.clientes;
        }

        private Cliente ConverterEmObjeto(string registro)
        {

            Cliente cliente = new Cliente();
            System.Console.WriteLine("REGISTRO:" + registro);
            cliente.ID = ulong.Parse(ExtrairValorDoCampo("id", registro));
            cliente.Nome = ExtrairValorDoCampo("nome", registro);
            cliente.Email = ExtrairValorDoCampo("email", registro);
            cliente.Senha = ExtrairValorDoCampo("senha", registro);
            cliente.Endereco = ExtrairValorDoCampo("endereco", registro);
            cliente.Telefone = ExtrairValorDoCampo("telefone", registro);
            cliente.DataNascimento = DateTime.Parse(ExtrairValorDoCampo("data_nascimento", registro));
            cliente.TipoCliente = uint.Parse(ExtrairValorDoCampo("tipo_cliente", registro));

            return cliente;
        }

        private string PrepararRegistroCSV(Cliente cliente)
        {
            return $"id={CONT};nome={cliente.Nome};email={cliente.Email};senha={cliente.Senha};endereco={cliente.Endereco};telefone={cliente.Telefone};data_nascimento={cliente.DataNascimento};tipo_cliente={cliente.TipoCliente}";
        }


    }
}