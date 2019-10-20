using System;
using ByteBank2.Models;

namespace ByteBank2
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaCorrente1 = new ContaCorrente(1, 1, "Alexandre");
            ContaCorrente contaCorrente2 = new ContaCorrente(1, 2, "Cesar");

            DepositarConta(contaCorrente1);
            DepositarConta(contaCorrente2);
            SacarConta(contaCorrente1);
            SacarConta(contaCorrente2);

            ContaEspecial contaEspecial1 = new ContaEspecial(1, 2, "Cesar");
            contaEspecial1.SetLimite(1000);
            DepositarConta(contaEspecial1);
            SacarConta(contaEspecial1);

            TransferirEntreContas(contaEspecial1, contaCorrente2);
        }

        #region Depositos em conta.
        public static void DepositarConta(ContaBancaria contaBancaria)
        {
            Console.WriteLine("ByteBank - Deposito");
            Console.WriteLine("-------------------");
            Console.WriteLine();
            string usuario = contaBancaria.Titular;
            Console.WriteLine($"Conta: {contaBancaria.GetType()}");
            Console.WriteLine($"Bem vindo - {usuario}");
            Console.WriteLine($"Agencia: {contaBancaria.Agencia}   Conta: {contaBancaria.NumeroConta}");
            Console.WriteLine($"Saldo: {contaBancaria.Saldo}");
            Console.Write("Digite o valor do Deposito: ");
            double valor = double.Parse(Console.ReadLine());
            if (contaBancaria.Deposito(valor))
            {
                Console.WriteLine("Depósito Concluído.");
                Console.WriteLine($"Saldo atual: {contaBancaria.Saldo}");
            }
            else
            {
                Console.WriteLine("Falha ao realizar o depósito.");
            }

            Console.WriteLine();
        }
        #endregion

        #region Saques em conta.
        public static void SacarConta(ContaBancaria contaBancaria)
        {
            string usuario = contaBancaria.Titular;
            Console.WriteLine("ByteBank - Saque");
            Console.WriteLine("----------------");
            Console.WriteLine();
            Console.WriteLine($"Conta: {contaBancaria.GetType()}");
            Console.WriteLine($"Bem vindo - {usuario}");
            Console.WriteLine($"Agencia: {contaBancaria.Agencia}   Conta: {contaBancaria.NumeroConta}");
            Console.WriteLine($"Saldo: {contaBancaria.Saldo}");
            Console.Write("Qual o valor do Saque? ");
            double valor = double.Parse(Console.ReadLine());
            if (contaBancaria.Saque(valor))
            {
                Console.WriteLine("Saque realizado com sucesso. Retire as notas");
            }
            else
            {
                Console.WriteLine("Não foi possivel realizar a operação");

            }
            Console.WriteLine($"Saldo atual: {contaBancaria.Saldo}");
            Console.WriteLine();
        }
        #endregion

        #region Transferência entre contas.
        public static void TransferirEntreContas(ContaBancaria conta1, ContaBancaria conta2)
        {
            string usuario = conta1.Titular;
            Console.WriteLine("ByteBank - Transferencia");
            Console.WriteLine("------------------------");
            Console.WriteLine();
            Console.WriteLine($"Conta: {conta1.GetType()}");
            Console.WriteLine($"Bem vindo - {usuario}");
            Console.WriteLine($"Agencia: {conta1.Agencia}   Conta: {conta1.NumeroConta}");
            Console.WriteLine($"Saldo origem: {conta1.Saldo}");
            Console.WriteLine($"Saldo destino: {conta2.Saldo}");
            Console.Write("Digite o valor da transferência: ");
            double valor = double.Parse(Console.ReadLine());

            if (conta1.Transferencia(conta2, valor))
            {
                Console.WriteLine("Tranferencia efetuada com sucesso.");
                Console.WriteLine($"Saldo origem: {conta1.Saldo}");
                Console.WriteLine($"Saldo destino: {conta2.Saldo}");
            }
            else
            {
                Console.WriteLine("Operação não pode ser realizada.");
            }
            Console.WriteLine();
        }
        #endregion
    }




}
