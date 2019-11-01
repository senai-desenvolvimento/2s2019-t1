using McBonaldsMVC.Enums;
using McBonaldsMVC.Repositories;
using McBonaldsMVC.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace McBonaldsMVC.Controllers
{
    public class AdministradorController : BaseController
    {
        PedidoRepository pedidoRepository = new PedidoRepository();


        public AdministradorController()
        {
            this.NomeView = "Cliente";
        }

        [HttpGet]
        public IActionResult Dashboard()
        {
            DashboardViewModel dvm = new DashboardViewModel(this);

            var pedidos = pedidoRepository.ListarTodos();
            dvm.Pedidos = pedidos;

            foreach (var pedido in pedidos)
            {
                switch(pedido.Status)
                {
                    case (uint) StatusPedidoEnum.APROVADO:
                        dvm.PedidosAprovados++;
                    break;
                    case (uint) StatusPedidoEnum.REPROVADO:
                        dvm.PedidosReprovados++;
                    break;
                    case (uint) StatusPedidoEnum.PENDENTE:
                        dvm.PedidosPendentes++;
                    break;
                }
            }
            
            ViewData["NomeView"] = "Dashboard";
            return View(dvm);
        }
    }
}