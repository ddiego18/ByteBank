using System;
using ByteBank.Modelos;

namespace SistemaInterno
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente(1014, 155320);
            Console.WriteLine(conta.Saldo);

            conta.Sacar(50.0);

            Console.WriteLine(conta.Saldo);

            conta.Sacar(200.0);

            Console.WriteLine(conta.Saldo);
        }
    }
}
