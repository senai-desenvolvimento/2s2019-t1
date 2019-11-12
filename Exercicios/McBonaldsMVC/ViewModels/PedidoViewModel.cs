using System.Collections.Generic;
using McBonaldsMVC.Controllers;
using McBonaldsMVC.Models;

namespace McBonaldsMVC.ViewModels
{
    public class PedidoViewModel : BaseViewModel
    {
        public List<Hamburguer> Hamburgueres {get;set;}
        public List<Shake> Shakes {get; set;}
        public Cliente Cliente {get;set;}

        public PedidoViewModel() : base()
        {
            this.Hamburgueres = new List<Hamburguer>();
            this.Shakes = new List<Shake>();
        }
    }
}