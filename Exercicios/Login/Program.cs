using System;

namespace Login
{
    class Program
    {
        static void Main(string[] args)
        {
            string usuario;
            string senha;

            Console.Write("Usuário: ");
            usuario=Console.ReadLine();
            Console.Write("Senha: ");
            senha=Console.ReadLine();

            if ((usuario == "admin") && (senha == "admin")){
                Console.WriteLine("Bem vindo Admin");
            } else {
                Console.WriteLine("Olá usuário");
            }

        }
    }
}
