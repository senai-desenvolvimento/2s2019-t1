using System;
using System.Collections.Generic;
using System.IO;
using McBonaldsMVC.Models;

namespace McBonaldsMVC.Repositories
{
    public class PedidoRepository : BaseRepository
    {
        public static uint CONT = 0;
        private const string PATH = "Database/Pedido.csv";
        private const string PATH_INDEX = "Database/Pedido_Id.csv";
        private List<Pedido> pedidos = new List<Pedido>();

        public PedidoRepository()
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

        public bool Inserir(Pedido pedido)
        {
            CONT++;
            File.WriteAllText(PATH_INDEX, CONT.ToString());

            string linha = PrepararRegistroCSV(pedido);
            File.AppendAllText(PATH, linha);

            return true;
        }

        public bool Atualizar(Pedido pedido)
        {
            var pedidosRecuperados = ObterRegistrosCSV(PATH);
            var clienteString = PrepararRegistroCSV(pedido);
            var linhaPedido = -1;
            var resultado = false;

            for (int i = 0; i < pedidosRecuperados.Length; i++)
            {
                if (clienteString.Equals(pedidosRecuperados[i]))
                {
                    linhaPedido = i;
                    resultado = true;
                }
            }
            if (linhaPedido >= 0)
            {
                pedidosRecuperados[linhaPedido] = clienteString;
                File.WriteAllLines(PATH, pedidosRecuperados);
            }

            return resultado;

        }

        public bool Apagar(ulong id)
        {

            var pedidosRecuperados = ObterRegistrosCSV(PATH);
            var linhaPedido = -1;
            var resultado = false;

            for (int i = 0; i < pedidosRecuperados.Length; i++)
            {
                if (id.Equals(pedidosRecuperados[i]))
                {
                    linhaPedido = i;
                    resultado = true;
                }
            }

            if (linhaPedido >= 0)
            {
                pedidosRecuperados[linhaPedido] = "";
                File.WriteAllLines(PATH, pedidosRecuperados);
            }

            return resultado;
        }

        public Pedido ObterPor(ulong id)
        {

            foreach (var item in ObterRegistrosCSV(PATH))
            {
                if (id.Equals(ExtrairCampo(id.ToString(), item)))
                {
                    return ConverterEmObjeto(item);
                }
            }
            return null;
        }

        public Pedido ObterPor(string email)
        {

            foreach (var item in ObterRegistrosCSV(PATH))
            {
                if (email.Equals(ExtrairCampo(email, item)))
                {
                    return ConverterEmObjeto(item);
                }
            }
            return null;
        }

        public List<Pedido> ListarTodos()
        {
            var linhas = ObterRegistrosCSV(PATH);
            foreach (var item in linhas)
            {
                Pedido pedido = ConverterEmObjeto(item);
                this.pedidos.Add(pedido);
            }
            return this.pedidos;
        }

        public List<Pedido> ListarTodosPorCliente(string emailCliente)
        {

            var linhas = ObterRegistrosCSV(PATH);
            foreach (var item in linhas)
            {
                Pedido pedido = ConverterEmObjeto(item);
                if (pedido.Cliente.Email.Equals(emailCliente))
                {
                    this.pedidos.Add(pedido);
                }
            }
            return this.pedidos;

        }

        private Pedido ConverterEmObjeto(string registro)
        {
            Pedido pedido = new Pedido();
            pedido.ID = ulong.Parse(ExtrairCampo("id", registro));
            pedido.Cliente.Nome = ExtrairCampo("clienteNome", registro);
            pedido.Cliente.Endereco = ExtrairCampo("clienteEndereco", registro);
            pedido.Cliente.Telefone = ExtrairCampo("clienteTelefone", registro);
            pedido.Cliente.Email = ExtrairCampo("clienteEmail", registro);
            pedido.Hamburguer.Nome = ExtrairCampo("hamburguerNome", registro);
            pedido.Hamburguer.Preco = double.Parse(ExtrairCampo("hamburguerPreco", registro));
            pedido.Shake.Nome = ExtrairCampo("shakeNome", registro);
            pedido.Shake.Preco = double.Parse(ExtrairCampo("shakePreco", registro));
            pedido.DataDoPedido = DateTime.Parse(ExtrairCampo("dataPedido", registro));
            pedido.PrecoTotal = double.Parse(ExtrairCampo("precoTotal", registro));
            pedido.Status = uint.Parse(ExtrairCampo("status", registro));

            return pedido;
        }

        private string PrepararRegistroCSV(Pedido pedido)
        {
            ulong id = pedido.ID == 0 ? CONT : pedido.ID;
            return $"id={id};clienteNome={pedido.Cliente.Nome};clienteEndereco={pedido.Cliente.Endereco};clienteTelefone={pedido.Cliente.Telefone};clienteEmail={pedido.Cliente.Email};hamburguerNome={pedido.Hamburguer.Nome};hamburguerPreco={pedido.Hamburguer.Preco};shakeNome={pedido.Shake.Nome};shakePreco={pedido.Shake.Preco};dataPedido={pedido.DataDoPedido};precoTotal={pedido.PrecoTotal};status={pedido.Status}\n";
        }
    }
}