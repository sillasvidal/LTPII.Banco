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
            Console.WriteLine("Limite não permite para o tipo de conta.");
        }
    }
}