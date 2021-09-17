using System;

namespace LTPII.Heranca
{
    public abstract class ContaBancaria
    {
        public string NumeroDaConta { get; private set; }
        public string NumeroDaAgencia { get; private set; }
        public double Saldo { get; private set; }

        public ContaBancaria(string numeroDaConta, 
                             string numeroDaAgencia,
                             double saldo)
        {
            NumeroDaConta = numeroDaConta;
            NumeroDaAgencia = numeroDaAgencia;
            Saldo = saldo;            
        }
    }
}