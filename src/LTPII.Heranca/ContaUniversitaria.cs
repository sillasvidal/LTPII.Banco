using System;

namespace LTPII.Heranca
{
    public class ContaUniversitaria : ContaCorrente
    {
        public ContaUniversitaria(string numeroDaConta, 
                                  string numeroDaAgencia,
                                  double saldo,
                                  double limite) 
                                  : base (numeroDaConta, numeroDaAgencia, saldo, limite)
        {
            if (limite > 100)
            Console.WriteLine("Limite não permitido para o tipo de conta.");
        }

        public override void Depositar(double valorDeposito)
        {
            if (valorDeposito > 1000)
            {
                Console.WriteLine("Valor de depósito máximo: R$1.000,00");
                return;
            }

            base.Depositar(valorDeposito);
        }

        public override double Sacar(double valorSaque)
        {
            var valorDisponivelParaSaque = this.Saldo * 0.9;

            if (valorSaque > valorDisponivelParaSaque)
            {
                Console.WriteLine("Limite de saque excedido.");
                return 0.0;
            }

            return base.Sacar(valorSaque);
        }
    }
}