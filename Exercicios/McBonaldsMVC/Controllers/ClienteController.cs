using McBonaldsMVC.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using McBonaldsMVC.ViewModels;


namespace McBonaldsMVC.Controllers
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

            if (cliente != null)
            {
                if (cliente.Email.Equals(usuario) && cliente.Senha.Equals(senha))
                {
                    switch (cliente.TipoCliente)
                    {
                        case 0:
                            HttpContext.Session.SetString(SESSION_EMAIL, usuario);
                            HttpContext.Session.SetString(SESSION_CLIENTE, cliente.Nome);
                            return RedirectToAction("Dashboard", "Administrador");
                        case 1:
                            HttpContext.Session.SetString(SESSION_EMAIL, usuario);
                            HttpContext.Session.SetString(SESSION_CLIENTE, cliente.Nome);
                            return RedirectToAction("Historico", "Cliente");
                    }
                }
                else
                {
                    // Errou alguma coisa
                    ViewData["Action"] = "Login";
                    return View("Falha");
                }
            }
            else
            {
                ViewData["Action"] = "Login";
                // Cliente não encontrado
                return View("Falha");
            }
            // TODO: Consertar essa lógica
            return null;
        }

        public IActionResult Historico()
        {
            var pedidos = pedidoRepository.ListarTodosPorCliente(HttpContext.Session.GetString(SESSION_EMAIL));
            return View(new HistoricoViewModel(this)
            {
                Pedidos = pedidos
            });
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Remove(SESSION_EMAIL);
            HttpContext.Session.Remove(SESSION_CLIENTE);
            HttpContext.Session.Clear();
            return RedirectToAction("Index", "Home");
        }
    }
}