using McBonaldsMVC.Controllers;

namespace McBonaldsMVC.ViewModels
{
    public class RespostaViewModel : BaseViewModel
    {
        public RespostaViewModel(string mensagem) : base()
        {
            this.Mensagem = mensagem;
        }

        public string Mensagem {get;set;}

    }
}