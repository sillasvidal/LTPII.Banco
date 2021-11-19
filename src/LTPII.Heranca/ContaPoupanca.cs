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

        public ContaPoupanca()
        : base(new Random().Next(999, 99999).ToString(),
               new Random().Next(999, 99999).ToString(),
               0.00)
        {
            
        }
    }
}