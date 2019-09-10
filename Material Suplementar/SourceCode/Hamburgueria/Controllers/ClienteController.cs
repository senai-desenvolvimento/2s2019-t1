using System.Security.Claims;
using System.Net;
using System.Runtime.InteropServices;
using Hamburgueria.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Hamburgueria.ViewModels;
using Hamburgueria.Utils;

namespace Hamburgueria.Controllers
{
    public class ClienteController : BaseController
    {
        private ClienteRepository repository = new ClienteRepository();

        private PedidoRepository pedidoRepository = new PedidoRepository();

        public ClienteController()
        {
            this.NomeView = "Cliente";
        }

        [HttpGet]
        public IActionResult Login() 
        {
            return View();
        }

        [HttpPost]

        public IActionResult Login(IFormCollection form) 
        {
            var usuario = form["email"];
            var senha = form["senha"];
            var cliente = repository.ObterPor(usuario);

            if (cliente != null && cliente.Email.Equals(usuario) && cliente.Senha.Equals(senha))
            {
                HttpContext.Session.SetString(SESSION_EMAIL, usuario);
                HttpContext.Session.SetString(SESSION_CLIENTE, cliente.Nome);
                
                return RedirectToAction("Historico","Cliente");
            } 
            else 
            {
                ViewData["Action"] = "Login";
                return View("Falha");
            }
            
        }

        public IActionResult Historico()
        {
            var pedidos = pedidoRepository.ListarTodosPorCliente(HttpContext.Session.GetString(SESSION_EMAIL));
            return View(new HistoricoViewModel(this){
                Pedidos = pedidos
            });
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Remove(SESSION_EMAIL);
            HttpContext.Session.Remove(SESSION_CLIENTE);
            HttpContext.Session.Clear();
            return RedirectToAction("Index","Home");
        }
    }
}