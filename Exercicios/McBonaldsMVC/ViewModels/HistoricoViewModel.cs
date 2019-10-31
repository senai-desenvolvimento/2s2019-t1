using System.Collections.Generic;
using McBonaldsMVC.Controllers;
using McBonaldsMVC.Models;

namespace McBonaldsMVC.ViewModels
{
    public class HistoricoViewModel : BaseViewModel
    {
        public HistoricoViewModel(BaseController controller) : base(controller)
        {
            
        }

        public List<Pedido> Pedidos {get;set;}
    }
}