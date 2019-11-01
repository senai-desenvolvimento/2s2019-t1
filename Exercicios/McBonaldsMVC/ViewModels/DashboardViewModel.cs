using System.Collections.Generic;
using McBonaldsMVC.Controllers;
using McBonaldsMVC.Models;

namespace McBonaldsMVC.ViewModels
{
    public class DashboardViewModel : BaseViewModel
    {
        public DashboardViewModel(BaseController controller) : base(controller)
        {
            
        }

        public List<Pedido> Pedidos {get;set;}
        public uint PedidosAprovados {get; set;}
        public uint PedidosReprovados {get; set;}
        public uint PedidosPendentes {get; set;}
    }
}