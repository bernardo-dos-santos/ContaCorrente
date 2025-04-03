namespace ContaCorrente.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta1 = new ContaCorrente();
            conta1.numeroConta = 1;
            conta1.saldo = 3500;
            conta1.limite = 1000;

            conta1.movimentacoes = new Movimentacoes[100];

            conta1.Sacar(200);
            conta1.Depositar(300);
            conta1.Depositar(500);
            conta1.Sacar(200);

            ContaCorrente conta2 = new ContaCorrente();
            conta2.saldo = 300;
            conta2.numeroConta = 13;
            conta2.limite = 0;

            conta2.movimentacoes = new Movimentacoes[100];

            conta1.ExibirExtrato();

        }
    }
}
