﻿namespace ContaCorrente.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta1 = new ContaCorrente();
            conta1.numeroConta = 1;
            conta1.saldo = 900;
            conta1.limite = 3500;

            conta1.movimentacoes = new Movimentacoes[100];

            conta1.Sacar(200);
            conta1.Depositar(300);

        }
    }
}
