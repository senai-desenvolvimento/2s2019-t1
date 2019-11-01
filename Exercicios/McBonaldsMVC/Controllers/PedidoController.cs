using System;
using McBonaldsMVC.Models;
using McBonaldsMVC.Repositories;
using McBonaldsMVC.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace McBonaldsMVC.Controllers {
    public class PedidoController : BaseController {

        HamburguerRepository hamburguerRepository = new HamburguerRepository ();
        ShakeRepository shakeRepository = new ShakeRepository ();
        PedidoRepository pedidoRepository = new PedidoRepository ();
        ClienteRepository clienteRepository = new ClienteRepository ();

        [HttpGet]
        public IActionResult Index () {
            var hamburgueres = hamburguerRepository.ObterTodos ();
            var shakes = shakeRepository.ObterTodos ();

            PedidoViewModel pedido = new PedidoViewModel (this);
            pedido.Hamburgueres.AddRange (hamburgueres);
            pedido.Shakes.AddRange (shakes);

            if (TempData["SessionCliente"] == null) 
            {
                ViewData["SessionCliente"] = "jovem";
            } else 
            {
                ViewData["SessionCliente"] = TempData["SessionCliente"];
            }
            if (HttpContext.Session.GetString (SESSION_EMAIL) != null) {
                Cliente cliente = clienteRepository.ObterPor (HttpContext.Session.GetString (SESSION_EMAIL));
                ViewData["User"] = HttpContext.Session.GetString (SESSION_EMAIL);
                pedido.Cliente = cliente;
            } else {
                pedido.Cliente = new Cliente ();
            }

            return View (pedido);
        }

        [HttpPost]
        public IActionResult RegistrarPedido (IFormCollection form) {
            Pedido pedido = new Pedido ();

            Cliente cliente = new Cliente ();
            cliente.Nome = form["nome"];
            cliente.Endereco = form["endereco"];
            cliente.Telefone = form["telefone"];
            cliente.Email = form["email"];

            pedido.Cliente = cliente;

            Hamburguer hamburguer = new Hamburguer ();
            hamburguer.Nome = form["hamburguer"];
            hamburguer.Preco = hamburguerRepository.ObterPrecoDe (form["hamburguer"]);
            pedido.Hamburguer = hamburguer;

            Shake shake = new Shake ();
            shake.Nome = form["shake"];
            shake.Preco = shakeRepository.ObterPrecoDe (form["shake"]);
            pedido.Shake = shake;

            pedido.DataDoPedido = DateTime.Now;

            pedido.PrecoTotal = pedido.Hamburguer.Preco + pedido.Shake.Preco;

            pedidoRepository.Inserir (pedido);

            ViewData["Action"] = "Pedido";
            // ViewData["User"] = HttpContext.Session.GetString (SessionEmail);

            return View ("Sucesso");
        }

    }
}