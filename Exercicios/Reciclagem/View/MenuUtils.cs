using System;

namespace Reciclagem.View
{
    public class MenuUtils<T>
    {
        public static int ExibirMenuPadrao()
        {
            string[] itensMenu = Enum.GetNames(typeof(T));
            string barraMenu = "===================================";

            #region HEADER
            System.Console.WriteLine(barraMenu);
            Console.ForegroundColor = ConsoleColor.DarkRed;
            System.Console.WriteLine("          VAMOS RECICLAR?          ");
            Console.ResetColor();
            System.Console.WriteLine("         Digite sua opção:         ");
            System.Console.WriteLine(barraMenu);
            #endregion

            #region BODY
            string bordaLinha = "||";
            string separadorOpcao = " - ";
            for (int i = 0; i < itensMenu.Length; i++)
            {
                string espacosFim = "";
                string paragrafoInicio = "   ";

                string titulo = TratarTituloMenu(itensMenu[i]);
                int espacoDezena = i / 10;

                string numeroOpcao = (i + 1).ToString();

                if (espacoDezena < 1)
                {
                    paragrafoInicio = paragrafoInicio + " ";
                }

                int qntdeEspacos = barraMenu.Length - (bordaLinha.Length * 2) - paragrafoInicio.Length - numeroOpcao.Length - separadorOpcao.Length - titulo.Length;

                for (int j = 0; j < qntdeEspacos; j++)
                {
                    espacosFim += " ";
                }
                System.Console.WriteLine($"{bordaLinha}{paragrafoInicio}{numeroOpcao}{separadorOpcao}{titulo}{espacosFim}{bordaLinha}");

            }

            #endregion
            #region FOOTER
            System.Console.WriteLine("-----------------------------------");
            System.Console.WriteLine("        Digite 0 para sair         ");
            System.Console.WriteLine(barraMenu);
            #endregion

            #region CODIGO
            int codigo = -1;
            System.Console.Write("Digite o código desejado: ");
            int.TryParse(Console.ReadLine(), out codigo);

            return codigo;
            #endregion

        }

        public static int ExibirMenuEspecial()
        {

            string[] itensMenu = Enum.GetNames(typeof(T));
            string barraMenu = "===================================";
            int opcaoSelecionada = 0;
            string paragrafo = "   ";
            string marcadorOpcao = "- ";
            string marcadorOpcaoDestaque = "> ";
            int codigo = -1;

            #region TEMPLATE

            #endregion

            #region HEADER
            Console.Clear();
            System.Console.WriteLine(barraMenu);
            Console.BackgroundColor = ConsoleColor.DarkCyan;
            Console.ForegroundColor = ConsoleColor.Black;
            System.Console.WriteLine("     Seja bem-vindo(a) Vocal!      ");
            System.Console.WriteLine("        Escolha uma formação:      ");
            Console.ResetColor();
            System.Console.WriteLine(barraMenu);
            #endregion

            #region BODY
            for (int i = 0; i < itensMenu.Length; i++)
            {
                string titulo = TratarTituloMenu(itensMenu[i]);
                int qntdEspacosFim = barraMenu.Length - paragrafo.Length - marcadorOpcao.Length - itensMenu[i].Length;
                string espacosFim = "";
                for (int j = 0; j < qntdEspacosFim; j++)
                {
                    espacosFim += " ";
                }
                if (opcaoSelecionada == i)
                {
                    DestacarOpcao($"{paragrafo}{marcadorOpcaoDestaque}{itensMenu[opcaoSelecionada].Replace("-", ">").Replace(i.ToString(), titulo)}{espacosFim}");
                }
                else
                {
                    System.Console.WriteLine($"{paragrafo}{marcadorOpcaoDestaque}{itensMenu[i].Replace(i.ToString(), titulo)}{espacosFim}");
                }
            }
            #endregion

            #region FOOTER
            #endregion

            var key = Console.ReadKey(true).Key;

            switch (key)
            {
                case ConsoleKey.UpArrow:
                    opcaoSelecionada = opcaoSelecionada == 0 ? opcaoSelecionada : --opcaoSelecionada;

                    break;
                case ConsoleKey.DownArrow:
                    opcaoSelecionada = opcaoSelecionada == itensMenu.Length - 1 ? opcaoSelecionada : ++opcaoSelecionada;

                    break;
                case ConsoleKey.Enter:
                    codigo = opcaoSelecionada;
                    break;
            }
            return codigo;
        }

        private static void DestacarOpcao(string opcao)
        {
            Console.BackgroundColor = ConsoleColor.DarkRed;
            System.Console.WriteLine(opcao);
            Console.ResetColor();
        }

        private static string TratarTituloMenu(string titulo)
        {
            return System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(titulo.Replace("_", " ").ToLower());
        }
    }
}