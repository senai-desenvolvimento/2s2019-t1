using System;

namespace salario
{
    class Program
    {
        static void Main(string[] args)
        {
            double salario;
            double aumento;

            Console.Write("Qual o seu salário: ");
            salario = double.Parse(Console.ReadLine());

            if (salario < 500){
                aumento = salario * 0.3;

                salario += aumento;
                
                Console.WriteLine("Parabéns, você ganhou um aumento!");
                Console.WriteLine($"Seu novo salário é de R$ {salario:F2}");

            } else {
                Console.WriteLine("Desculpe, sem aumento salarial para você!");
            }
        }
    }
}
