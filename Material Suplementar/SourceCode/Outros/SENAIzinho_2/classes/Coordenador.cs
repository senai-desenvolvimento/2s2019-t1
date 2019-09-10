using SENAIzinho_2.interfaces;

namespace SENAIzinho_2.classes
{
    public class Coordenador : Funcionario, IDocente
    {
        
        public bool DarAula()
        {
            System.Console.WriteLine("Dizia eu que a aritmética...");
            return true;
        }

        public override void Trabalhar()
        {
            System.Console.WriteLine("Pessoal, vamos usar o BOM SENSO!");
        }
    }
}