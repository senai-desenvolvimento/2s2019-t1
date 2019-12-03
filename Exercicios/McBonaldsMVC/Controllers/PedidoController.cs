using System;
using McBonaldsMVC.Enums;
using McBonaldsMVC.Models;
using McBonaldsMVC.Repositories;
using McBonaldsMVC.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace McBonaldsMVC.Controllers
{
    public class PedidoController : AbstractController
    {
        HamburguerRepository hamburguerRepository = new HamburguerRepository();
        ShakeRepository shakeRepository = new ShakeRepository();
        PedidoRepository pedidoRepository = new PedidoRepository();
        ClienteRepository clienteRepository = new ClienteRepository();

        [HttpGet]
        public IActionResult Index()
        {
            var hamburgueres = hamburguerRepository.ObterTodos();
            var shakes = shakeRepository.ObterTodos();

            PedidoViewModel pedido = new PedidoViewModel();
            pedido.Hamburgueres.AddRange(hamburgueres);
            pedido.Shakes.AddRange(shakes);

            var usuarioLogado = RecuperarUsuarioNomeDaSessao();
            if (string.IsNullOrEmpty(usuarioLogado))
            {
                pedido.UsuarioNome = "jovem";
            }
            else
            {
                pedido.UsuarioNome = usuarioLogado;
            }
            
            if (HttpContext.Session.GetString(SESSION_EMAIL) != null)
            {
                Cliente cliente = clienteRepository.ObterPor(HttpContext.Session.GetString(SESSION_EMAIL));
                pedido.UsuarioEmail = HttpContext.Session.GetString(SESSION_EMAIL);
                pedido.Cliente = cliente;
            }
            else
            {
                pedido.Cliente = new Cliente();
            }

            return View(pedido);
        }

        [HttpPost]
        public IActionResult Registrar(IFormCollection form)
        {
            Pedido pedido = new Pedido();

            // EXEMPLO 1 - Criação de objeto
            Shake shake = new Shake();
            shake.Nome = form["shake"];
            shake.Preco = shakeRepository.ObterPrecoDe(form["shake"]);
            
            pedido.Shake = shake;

            // EXEMPLO 2 - Criação de objeto
            Cliente cliente = new Cliente(
                form["nome"],
                form["endereco"],
                form["telefone"],
                form["email"]
            );

            pedido.Cliente = cliente;

            // EXEMPLO 3 - Criação de objeto
            var precoHamburguer = hamburguerRepository.ObterPrecoDe(form["hamburguer"]);
            Hamburguer hamburguer = new Hamburguer() {
                Nome = form["hamburguer"],
                Preco = precoHamburguer
            };

            pedido.Hamburguer = hamburguer;
            pedido.DataDoPedido = DateTime.Now;
            pedido.PrecoTotal = pedido.Hamburguer.Preco + pedido.Shake.Preco;

            if (pedidoRepository.Inserir(pedido))
            {
                return View("Sucesso", new RespostaViewModel($"Aguarde a aprovação pelos nossos atendentes!"));
            }
            else
            {
                return View("Falha", new RespostaViewModel($"Houve um erro na efetuação do pedido. Favor tentar novamente."));
            }

        }

        public IActionResult Aprovar(ulong id)
        {
            Pedido pedido = pedidoRepository.ObterPor(id);
            pedido.Status = (uint) StatusPedidoEnum.APROVADO;

            if (pedidoRepository.Atualizar(id, pedido))
            {
                return RedirectToAction("Dashboard", "Administrador");
            }
            else
            {
                return View("Falha", new RespostaViewModel($"Não foi possível aprovar este pedido!"));
            }
        }

        public IActionResult Reprovar(ulong id)
        {
            Pedido pedido = pedidoRepository.ObterPor(id);
            pedido.Status = (uint) StatusPedidoEnum.REPROVADO;

            if (pedidoRepository.Atualizar(id, pedido))
            {
                return RedirectToAction("Dashboard", "Administrador");
            }
            else
            {
                return View("Falha", new RespostaViewModel($"Não foi possível aprovar este pedido!"));
            }
        }

    }
}