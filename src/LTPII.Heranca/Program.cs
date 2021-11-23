using System;

namespace LTPII.Heranca
{
    class Program
    {
        static void Main(string[] args)
        {
            var contaUniversitaria = new ContaUniversitaria("123123", "654321", 10000, 100);
            var contaInvestimento = new ContaInvestimento("654321", "123123", 5000, 100);

            contaUniversitaria.ImprimirDetalhes();
            contaInvestimento.ImprimirDetalhes();

            contaUniversitaria.Depositar(1000);
            contaUniversitaria.ImprimirDetalhes();

            contaUniversitaria.Sacar(9000);
            contaUniversitaria.ImprimirDetalhes();

            contaInvestimento.Depositar(1000);
            contaInvestimento.ImprimirDetalhes();
        }
    }
}
