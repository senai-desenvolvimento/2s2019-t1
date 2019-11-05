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

            var linha = new string[] { PrepararRegistroCSV(pedido) };
            File.AppendAllLines(PATH, linha);

            return true;
        }

        public bool Atualizar(ulong id, Pedido pedido)
        {
            var pedidosRecuperados = ObterRegistrosCSV(PATH);
            var clienteString = PrepararRegistroCSV(pedido);
            var linhaPedido = -1;
            var resultado = false;

            for (int i = 0; i < pedidosRecuperados.Length; i++)
            {
                if (id.ToString().Equals(ExtrairValorDoCampo("id", pedidosRecuperados[i])))
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
                string valor = ExtrairValorDoCampo("id", item);
                if (id.Equals(ulong.Parse(valor)))
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
                if (email.Equals(ExtrairValorDoCampo(email, item)))
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
                if (!string.IsNullOrEmpty(item))
                {
                    Pedido pedido = ConverterEmObjeto(item);
                    this.pedidos.Add(pedido);
                }
            }
            return this.pedidos;
        }

        public List<Pedido> ListarTodosPorCliente(string emailCliente)
        {

            var linhas = ObterRegistrosCSV(PATH);
            foreach (var item in linhas)
            {
                if (!string.IsNullOrEmpty(item))
                {
                    Pedido pedido = ConverterEmObjeto(item);
                    if (pedido.Cliente.Email.Equals(emailCliente))
                    {
                        this.pedidos.Add(pedido);
                    }
                }
            }
            return this.pedidos;

        }

        private Pedido ConverterEmObjeto(string registro)
        {
            Pedido pedido = new Pedido();
            pedido.ID = ulong.Parse(ExtrairValorDoCampo("id", registro));
            pedido.Cliente.Nome = ExtrairValorDoCampo("clienteNome", registro);
            pedido.Cliente.Endereco = ExtrairValorDoCampo("clienteEndereco", registro);
            pedido.Cliente.Telefone = ExtrairValorDoCampo("clienteTelefone", registro);
            pedido.Cliente.Email = ExtrairValorDoCampo("clienteEmail", registro);
            pedido.Hamburguer.Nome = ExtrairValorDoCampo("hamburguerNome", registro);
            pedido.Hamburguer.Preco = double.Parse(ExtrairValorDoCampo("hamburguerPreco", registro));
            pedido.Shake.Nome = ExtrairValorDoCampo("shakeNome", registro);
            pedido.Shake.Preco = double.Parse(ExtrairValorDoCampo("shakePreco", registro));
            pedido.DataDoPedido = DateTime.Parse(ExtrairValorDoCampo("dataPedido", registro));
            pedido.PrecoTotal = double.Parse(ExtrairValorDoCampo("precoTotal", registro));
            pedido.Status = uint.Parse(ExtrairValorDoCampo("status", registro));

            return pedido;
        }

        private string PrepararRegistroCSV(Pedido pedido)
        {
            ulong id = pedido.ID == 0 ? CONT : pedido.ID;
            return $"id={id};clienteNome={pedido.Cliente.Nome};clienteEndereco={pedido.Cliente.Endereco};clienteTelefone={pedido.Cliente.Telefone};clienteEmail={pedido.Cliente.Email};hamburguerNome={pedido.Hamburguer.Nome};hamburguerPreco={pedido.Hamburguer.Preco};shakeNome={pedido.Shake.Nome};shakePreco={pedido.Shake.Preco};dataPedido={pedido.DataDoPedido};precoTotal={pedido.PrecoTotal};status={pedido.Status}";
        }
    }
}