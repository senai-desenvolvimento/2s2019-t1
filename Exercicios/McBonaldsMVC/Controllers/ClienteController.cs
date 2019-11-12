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

        }

        [HttpGet]
        public IActionResult Login()
        {
            return View(new BaseViewModel() {
                NomeView = "Login"
            });
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
                        case 1:
                            HttpContext.Session.SetString(SESSION_EMAIL, usuario);
                            HttpContext.Session.SetString(SESSION_CLIENTE, cliente.Nome);
                            return RedirectToAction("Historico", "Cliente");
                        default:
                            HttpContext.Session.SetString(SESSION_EMAIL, usuario);
                            HttpContext.Session.SetString(SESSION_CLIENTE, cliente.Nome);
                            return RedirectToAction("Dashboard", "Administrador");
                    }
                }
                else
                {
                    return View("Falha", new RespostaViewModel($"Usuário ou senha estão errados"));
                }
            }
            else
            {
                return View("Falha", new RespostaViewModel($"Usuário {usuario} não foi encontrado"));
            }
        }

        public IActionResult Historico()
        {

            var pedidos = pedidoRepository.ListarTodosPorCliente(HttpContext.Session.GetString(SESSION_EMAIL));
            
            // EXEMPLO 3 - Criação de objetos
            return View(new HistoricoViewModel()
            {
                Pedidos = pedidos,
                NomeView = "Histórico",
                UsuarioEmail = RecuperarUsuarioEmailDaSessao(),
                UsuarioNome = RecuperarUsuarioNomeDaSessao()
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