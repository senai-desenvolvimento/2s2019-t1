using System;

namespace Triangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write ("Digite o tamanho do triângulo: ");
            int tamanhoTriangulo = int.Parse (Console.ReadLine ());
            Console.WriteLine();
            string estrelas = "";
            for (int j = 0; j < tamanhoTriangulo; j++) {
                estrelas += "*";
                Console.WriteLine (estrelas);
            }
            Console.WriteLine();
        }   
    }
}
