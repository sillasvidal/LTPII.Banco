using System;

namespace LTPII.Heranca 
{
    public class ContaCorrente : ContaBancaria
    {        
        public double Limite { get; private set; }

        public ContaCorrente(string numeroDaConta, 
                             string numeroDaAgencia,
                             double saldo,
                             double limite) 
                             : base (numeroDaConta, numeroDaAgencia, saldo)
        {
            Limite = limite;
        }
    }
}