using System;

namespace LTPII.Heranca
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Criar sistema bancário com as classes 
            conta corrente, 
            conta poupança e 
            conta investimento 
            
            características: numero da conta, agencia, saldo e limite, rendimento */

            /* Classe é o que representa o conjunto de objetos (de forma generica). */
            /* Objeto é uma instancia da classe representando um objeto específico.*/

            var minhaConta = new ContaCorrente("101010", "909090", 0.00, 0.00);
            var minhaPoupanca = new ContaPoupanca("202020", "808080", 1.00);

            var contaUniversitaria = new ContaUniversitaria("8888", "5555", 0.00, 101.00);
            
            Console.WriteLine("Conta Corrente");
            Console.WriteLine($"Numero da conta..: {minhaConta.NumeroDaConta}");
            Console.WriteLine($"Numero da agência: {minhaConta.NumeroDaAgencia}");
            Console.WriteLine($"Saldo............: {minhaConta.Saldo:C}");
            Console.WriteLine($"Limite...........: {minhaConta.Limite:C}");
            
            Console.WriteLine("");

            Console.WriteLine("Conta Poupança");
            Console.WriteLine($"Numero da conta..: {minhaPoupanca.NumeroDaConta}");
            Console.WriteLine($"Numero da agência: {minhaPoupanca.NumeroDaAgencia}");
            Console.WriteLine($"Saldo............: {minhaPoupanca.Saldo:C}");

            //Console.ReadLine();
        }
    }
}
