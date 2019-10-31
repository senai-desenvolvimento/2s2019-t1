
using McBonaldsMVC.Controllers;
using Microsoft.AspNetCore.Http;

namespace McBonaldsMVC.ViewModels
{
    public class BaseViewModel
    {
        public string NomeView {get;set;}
        public string UsuarioNome {get;set;}
        public string UsuarioEmail {get;set;}

        public BaseViewModel (BaseController controller) 
        {
            this.UsuarioEmail = controller.UserEmail;
            this.UsuarioNome = controller.UserName;
            this.NomeView = controller.NomeView;
        }
        
    }
}