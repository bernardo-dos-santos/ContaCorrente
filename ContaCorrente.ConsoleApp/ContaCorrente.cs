using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaCorrente.ConsoleApp
{
    public class ContaCorrente
    {
        public decimal saldo;
        public int numeroConta;
        public int limite;
        public Movimentacoes[] movimentacoes = new Movimentacoes[100];

        public decimal Sacar(decimal saque)
        {
            saldo -= saque;
            return saldo;
        }
        public decimal Depositar(decimal deposito)
        {
            saldo += deposito;
            return saldo;
        }

    }
}
