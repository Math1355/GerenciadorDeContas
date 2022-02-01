using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaBancaria.Contas
{
    public class Conta
    {
        public string titular { get; set; }
        public int agencia { get; set; }
        public int conta { get; set; }

        private double saldo;
        
        public double Saldo
        {
            get
            {
                return saldo;
            }
            set
            {
                if (value < 0)
                {
                    return;
                }
                saldo = value;
            }
        }

        public Conta(string titular, int agencia, int conta)
        {
            this.titular = titular;
            this.agencia = agencia;
            this.conta = conta;
        }
        public Conta(int agencia, int conta)
        {
            this.agencia = agencia;
            this.conta = conta;
        }

        public bool Sacar(double valor)
        {
            if (saldo < valor)
            {
                return false;
            }

            saldo -= valor;
            Console.WriteLine(titular + " sacou R$" + valor + ". Seu saldo atual e de R$" + saldo);
            return true;
        }

        public void Depositar(double valor)
        {
            saldo += valor;
            Console.WriteLine(titular + " depositou R$" + valor + ". Seu saldo atual e de R$" + saldo);
        }
        public void Consultar()
        {
            Console.WriteLine(" Seu saldo atual e de R$" + saldo);
        }

        public double Taxa()
        {
            return saldo -= 10;
        }

        public double Rendimento()
        {
            return saldo * 0.10;
        }

    }
}
