using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ContaBancaria.Contas
{
    public class ContaCorrente : Conta
    {
        public ContaCorrente(string titular, int agencia, int conta) : base(titular, agencia, conta)
        {
        }

        public double RegistrarTaxa()
        {
            return Saldo;
        }
    }
}
