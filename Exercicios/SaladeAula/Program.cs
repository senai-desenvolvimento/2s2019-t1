using System;

namespace SaladeAula
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno aluno1 = new Aluno("Alexandre","123.456.789-0","Prog1");
            Aluno aluno2 = new Aluno("Cesar", "987.654.321-9");
            string nome_do_aluno = aluno1.nome;
            string cpf_do_aluno = aluno1.cpf;
            Console.WriteLine($"O nome do aluno1 é {nome_do_aluno}");
            Console.WriteLine($"O CPF do aluno1 é: {cpf_do_aluno}");
            Console.WriteLine($"O curso do aluno1 é: {aluno1.curso}");
            double[] notas = aluno1.getNotas();
            Console.Write("Notas: ");
            for (int i = 0; i < 4; i++)
            {
                Console.Write(notas[i] + " ");
            }
            Console.WriteLine();
            aluno1.setNotas(6,8.0);

            Console.Write("Notas: ");
            for (int i = 0; i < 4; i++)
            {
                Console.Write(notas[i] + " ");
            }
            Console.WriteLine();

            Console.WriteLine($"O nome do aluno2 é {aluno2.nome}");
            Console.WriteLine($"O CPF do aluno2 é: {aluno2.cpf}");
            Console.WriteLine($"O curso do aluno2 é: {aluno2.curso}");
        }
    }
}
