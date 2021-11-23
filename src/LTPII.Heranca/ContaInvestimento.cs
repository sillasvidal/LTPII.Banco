using System;

namespace LTPII.Heranca
{
    public class ContaInvestimento : ContaCorrente
    {
        public ContaInvestimento(string numeroDaConta, 
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
            base.Depositar(valorDeposito + (valorDeposito * 0.1));
        }
    }
}