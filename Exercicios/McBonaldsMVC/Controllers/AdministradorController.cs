using System;
using McBonaldsMVC.Enums;
using McBonaldsMVC.Repositories;
using McBonaldsMVC.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace McBonaldsMVC.Controllers
{
    public class AdministradorController : AbstractController
    {
        PedidoRepository pedidoRepository = new PedidoRepository();

        public AdministradorController()
        {
        }

        [HttpGet]
        public IActionResult Dashboard()
        {
            DashboardViewModel dvm = new DashboardViewModel();

            var pedidos = pedidoRepository.ListarTodos();
            // Barrar Pedidos Aprovados e Reprovados
            foreach (var item in pedidos)
            {
                if (item.Status == (uint) StatusPedidoEnum.PENDENTE) 
                {
                    dvm.Pedidos.Add(item);
                }
            }

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
            dvm.NomeView = "Dashboard";
            dvm.UsuarioEmail = RecuperarUsuarioEmailDaSessao();
            
            return View(dvm);
        }
    }
}