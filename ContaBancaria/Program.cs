using ContaBancaria.Contas;
using System;
using System.Globalization;

namespace ContaBancaria
{
    class Program
    {
        static void Main(string[] args)
        {
            // TITULAR, AGENCIA, CONTA
            Conta conta1 = new Conta("João da Silva", 8468, 165165);

            Console.WriteLine("Titular: " + conta1.titular);
            Console.WriteLine("Agencia: " + conta1.agencia);
            Console.WriteLine("Conta: " + conta1.conta);
            Console.WriteLine("Tipo de conta: Correte ");

            conta1.Depositar(120);
            conta1.Sacar(15);
            Console.WriteLine("Sua taxa de manutenção e R$ 10, seu saldo atual e de: " + conta1.Taxa());
            Console.WriteLine("---------------------------------------");

            Conta conta2 = new Conta("Maria Gomes", 8462, 1548964);

            Console.WriteLine("Titular: " + conta2.titular);
            Console.WriteLine("Agencia: " + conta2.agencia);
            Console.WriteLine("Conta: " + conta2.conta);
            Console.WriteLine("Tipo de conta: Poupança");

            conta2.Depositar(300);
            conta2.Sacar(45);
            Console.WriteLine("Seu rendimento e de 10%, no total foi R$" + conta2.Rendimento());

            Console.WriteLine("Precione enter para finalizar");
            Console.ReadLine();
        }
    }
}