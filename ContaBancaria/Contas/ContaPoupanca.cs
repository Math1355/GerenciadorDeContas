using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ContaBancaria.Contas
{
    public class ContaPoupanca : Conta
    {
        public ContaPoupanca(string titular, int agencia, int conta) : base(titular, agencia, conta)
        {
        }

        public double RegistrarRendimento()
        {
            return Saldo * 0.10;
        }
    }
}