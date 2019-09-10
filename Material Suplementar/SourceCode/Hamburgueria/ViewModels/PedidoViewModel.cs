using System.Collections.Generic;
using Hamburgueria.Controllers;
using Hamburgueria.Models;

namespace Hamburgueria.ViewModels
{
    public class PedidoViewModel : BaseViewModel
    {
        public List<Hamburguer> Hamburgueres {get;set;}
        public List<Shake> Shakes {get; set;}
        public Cliente Cliente {get;set;}

        public PedidoViewModel(BaseController controller) : base(controller)
        {
            this.Hamburgueres = new List<Hamburguer>();
            this.Shakes = new List<Shake>();
        }
    }
}