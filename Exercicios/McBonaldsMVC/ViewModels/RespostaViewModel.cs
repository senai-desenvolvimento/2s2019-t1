using McBonaldsMVC.Controllers;

namespace McBonaldsMVC.ViewModels
{
    public class RespostaViewModel : BaseViewModel
    {
        public RespostaViewModel(string mensagem) : base()
        {
            this.Mensagem = mensagem;
        }

        public RespostaViewModel(string mensagem, string nomeView) : base()
        {
            this.Mensagem = mensagem;
            this.NomeView = nomeView;
        }

        public string Mensagem {get;set;}

    }
}