using System.Collections.Generic;
using McBonaldsMVC.Controllers;
using McBonaldsMVC.Models;

namespace McBonaldsMVC.ViewModels
{
    public class HistoricoViewModel : BaseViewModel
    {
        public HistoricoViewModel() : base()
        {
            
        }

        public List<Pedido> Pedidos {get;set;}
        public string URLFoto {get;set;}
    }
}