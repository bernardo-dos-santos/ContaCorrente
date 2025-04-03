using Microsoft.Win32;
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
        public Movimentacoes[] movimentacoes;
        public int contarMovimentacoes = 0;
        public decimal Sacar(decimal saque)
        {
            saldo -= saque;

            RegistrarMovimentacoes("Saque", saque);
            return saldo;

        }
        public decimal Depositar(decimal deposito)
        {
            saldo += deposito;
            RegistrarMovimentacoes("Depósito", deposito);
            return saldo;
        }
        public bool VerificarLimite(decimal saque)
        {
            if (saque <= limite)
                return true;
            return false;
        }

        public void RegistrarMovimentacoes(string tipo, decimal valor)
        {
            if(contarMovimentacoes < movimentacoes.Length)
            {
                movimentacoes[contarMovimentacoes] = new Movimentacoes
                {
                    Tipo = tipo,
                    valorUsado = valor
                };
                contarMovimentacoes++;

            }
        }

        public void ExibirExtrato()
        {
            for (int i = 0; i < movimentacoes.Length; i++)
            {                
                    Console.WriteLine($"{movimentacoes[i].Tipo} de R${movimentacoes[i].valorUsado}");
            }
        }
        public void Transferencia(ContaCorrente contaSaida, decimal valor, ContaCorrente contaEntrada)
        {
            contaSaida.saldo = contaSaida.saldo - valor;
            contaEntrada.saldo += valor;

            RegistrarMovimentacoes("Transferência", valor);
        }
    }
}
