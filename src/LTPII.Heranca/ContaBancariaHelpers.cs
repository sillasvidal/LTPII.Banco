using System;

namespace LTPII.Heranca
{
    ///É uma classe de ajuda
    public static class ContaBancariaHelper
    {
        public static void ImprimirDetalhes(this ContaBancaria conta)
        {
            Console.WriteLine("");
            Console.WriteLine($"{conta.GetType()}");
            Console.WriteLine($"Numero da conta..: {conta.NumeroDaConta}");
            Console.WriteLine($"Numero da agência: {conta.NumeroDaAgencia}");
            Console.WriteLine($"Saldo............: {conta.Saldo:C}");

            if (conta.GetType() == typeof(ContaCorrente))
            {
                Console.WriteLine($"Limite...........: {((ContaCorrente)conta).Limite:C}");
                Console.WriteLine($"Saldo+Limite.....: {((ContaCorrente)conta).Limite+((ContaCorrente)conta).Saldo:C}");
            }

            Console.WriteLine("");
        }
    }
}