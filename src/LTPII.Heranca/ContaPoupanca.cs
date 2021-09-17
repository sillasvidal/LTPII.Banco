using System;

namespace LTPII.Heranca 
{
    public class ContaPoupanca : ContaBancaria
    {
        public ContaPoupanca(string numeroDaConta, 
                             string numeroDaAgencia,
                             double saldo)
                             : base(numeroDaConta, numeroDaAgencia, saldo)
        {
            
        }
    }
}