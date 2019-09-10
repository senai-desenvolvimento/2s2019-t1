using System;

namespace JuntaNomes
{
    class Program
    {
        static void Main(string[] args)
        {

            DateTime nascimento = DateTime.Parse("26/06/1987");
            DateTime hoje = DateTime.Parse("26/06/2019");

            TimeSpan tempoVivido = (hoje - nascimento);
            DateTime idade = new DateTime()
                                        .Add(tempoVivido)
                                        .AddYears(-1);

            System.Console.WriteLine(idade.Year);
            

        }
    }
}
