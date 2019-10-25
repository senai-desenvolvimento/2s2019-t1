using Reciclagem2.Interfaces;
using Reciclagem2.Models;
using System;

namespace Reciclagem2
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcao = 0;
            int itens = Lixeira.lixos.Count;
            do
            {
                opcao = ExibeMenu();
                if ((opcao >=1) && (opcao <=itens))
                {
                    Lixo lixo = Lixeira.lixos[opcao];
                    LataDeLixo(lixo);
                    Console.ReadLine();
                }
            } while (opcao != 0);
        }

        private static int ExibeMenu()
        {
            int opcao = 0;
            int conta = 1;
            Console.Clear();
            Console.WriteLine("Centro de Reciclagem");
            foreach (Lixo lixo in Lixeira.lixos.Values)
            {
                Console.WriteLine($"{conta} - {lixo.Reciclar()}");
                conta++;
            }
            Console.WriteLine("0 - Para terminar");
            Console.Write("Entre com o tipo do lixo: ");
            int.TryParse(Console.ReadLine(),out opcao);
            Console.WriteLine();
            return opcao;
        }

        static void LataDeLixo(Lixo lixo)
        {
            var lixoInterface = lixo.GetType().GetInterfaces().GetValue(0);

            if (lixoInterface.Equals(typeof(IVidro)))
            {
                IVidro material = (IVidro)lixo;
                string mensagem = $"{material.Reciclar()} deve ir para a lixeira Verde";
                ImprimeMensagem(ConsoleColor.Green, ConsoleColor.White, mensagem);
            }
            else if (lixoInterface.Equals(typeof(IPlastico)))
            {
                IPlastico material = (IPlastico)lixo;
                string mensagem = $"{material.Reciclar()} deve ir para a lixeira Vermelha";
                ImprimeMensagem(ConsoleColor.Red, ConsoleColor.White, mensagem);
            }
            else if (lixoInterface.Equals(typeof(IPapel)))
            {
                IPapel material = (IPapel)lixo;
                string mensagem = $"{material.Reciclar()} deve ir para a lixeira Azul";
                ImprimeMensagem(ConsoleColor.Blue, ConsoleColor.White, mensagem);
            }
            else if (lixoInterface.Equals(typeof(IOrganico)))
            {
                IOrganico material = (IOrganico)lixo;
                string mensagem = $"{material.Reciclar()} deve ir para a lixeira Marrom";
                ImprimeMensagem(ConsoleColor.Black, ConsoleColor.White, mensagem);
            }
            else if (lixoInterface.Equals(typeof(IMetal)))
            {
                IMetal material = (IMetal)lixo;
                string mensagem = $"{material.Reciclar()} deve ir para a lixeira Amarela";
                ImprimeMensagem(ConsoleColor.Yellow, ConsoleColor.Black, mensagem);
            }
            else if (lixoInterface.Equals(typeof(IIndefinido)))
            {
                IIndefinido material = (IIndefinido)lixo;
                string mensagem = $"{material.Reciclar()} deve ir para a lixeira Cinza";
                ImprimeMensagem(ConsoleColor.Gray, ConsoleColor.White, mensagem);
            }
        }

        static void ImprimeMensagem(ConsoleColor background, ConsoleColor foreground, string mensagem)
        {
            Console.BackgroundColor = background;
            Console.ForegroundColor = foreground;
            Console.WriteLine(mensagem);
            Console.ResetColor();
        }
    }
}
