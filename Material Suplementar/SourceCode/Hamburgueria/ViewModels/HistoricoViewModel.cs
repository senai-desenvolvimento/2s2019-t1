using System.Collections.Generic;
using Hamburgueria.Controllers;
using Hamburgueria.Models;

namespace Hamburgueria.ViewModels
{
    public class HistoricoViewModel : BaseViewModel
    {
        public HistoricoViewModel(BaseController controller) : base(controller)
        {
            
        }

        public List<Pedido> Pedidos {get;set;}
    }
}