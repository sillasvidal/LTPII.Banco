using System;

namespace LTPII.Heranca
{
    class Program
    {
        static void Main(string[] args)
        {
            var contaDoSillas = new ContaCorrente("8888", "10101", 1000000, 1000000);

            contaDoSillas.ImprimirSaldo();

            var contadoLucyano = new ContaPoupanca("2222", "121212", 25.00);

            contadoLucyano.ImprimirSaldo();
            
            // DECLARAÇÃO                     //INSTÂNCIA 
            ContaBancaria contaqualquer = new ContaCorrente("292929", "23123213", 1000, 1000);

            contaqualquer.ImprimirSaldo();
        }
    }
}
