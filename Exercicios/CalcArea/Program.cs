using System;

namespace CalcArea
{
    class Program
    {
        static void Main(string[] args)
        {
            string forma="";
            do{

                Console.WriteLine("Calcula Área");
                Console.WriteLine("1 - Circulo");
                Console.WriteLine("2 - Quadrado");
                Console.WriteLine("3 - Retângulo");
                Console.WriteLine("4 - Triângulo");
                Console.WriteLine("5 - Losango");
                Console.WriteLine("6 - Trapézio");
                Console.WriteLine("fim para terminar.");
                Console.Write("Selecione uma forma: ");
                forma = Console.ReadLine();

                switch(forma){
                    case "1":
                        Console.Write("Qual o raio da circunferência? ");
                        double r = double.Parse(Console.ReadLine());
                        double areaCirc = 3.14 * r * r;
                        Console.WriteLine("A área da Circunferência é " + areaCirc);
                        break;
                    case "2":
                        Console.Write("Qual o lado do Quadrado? ");
                        double l = double.Parse(Console.ReadLine());
                        double areaQuad = l * l;
                        Console.WriteLine("A área do Quadrado é " + areaQuad);
                        break;
                    case "3":
                        Console.Write("Digite o primeiro lado do Retângulo: ");
                        double l1 = double.Parse(Console.ReadLine());
                        Console.Write("Digite o segundo lado do Retângulo: ");
                        double l2 = double.Parse(Console.ReadLine());
                        double areaRet = l1 * l2;
                        Console.WriteLine("A área do Retângulo é " + areaRet);
                        break;
                    case "4":
                        Console.Write("Qual a base do Triângulo? ");
                        double baseTri = double.Parse(Console.ReadLine());
                        Console.Write("Qual a altura do Triângulo? ");
                        double hTri = double.Parse(Console.ReadLine());
                        double areaTri = (baseTri * hTri)/2;
                        Console.WriteLine("A área do Triângulo é " + areaTri);
                        break;
                    case "5":
                        Console.Write("Digite a diagonal maior do Losango: ");
                        double dMaior = double.Parse(Console.ReadLine());
                        Console.Write("Digite o diagonal menor do Losango: ");
                        double dMenor = double.Parse(Console.ReadLine());
                        double areaLos = (dMaior * dMenor)/2;
                        Console.WriteLine("A área do Losango é " + areaLos);
                        break;
                    case "6":
                        Console.Write("Digite a base maior do Trapézio: ");
                        double bMaior = double.Parse(Console.ReadLine());
                        Console.Write("Digite a base menor do Trapézio: ");
                        double bMenor = double.Parse(Console.ReadLine());
                        Console.Write("Qual a altura do Trapézio: ");
                        double hTrap = double.Parse(Console.ReadLine());
                        double areaTrap = ((bMaior + bMenor) * hTrap)/2;
                        Console.WriteLine("A área do Trapézio é " + areaTrap);
                        break;
                }
                Console.WriteLine();
            }while(forma != "fim");
        }
    }
}
