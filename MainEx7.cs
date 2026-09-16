using System;
using System.Collections.Generic;
using System.Text;

namespace AT
{
    internal class MainEx7
    {
        static void Main(string[] args)
        {
            ContaBancaria conta = new ContaBancaria("João Silva", 500.0m);
            conta.ExibirSaldo();
            conta.Depositar(500.0m);
            conta.ExibirSaldo();
            conta.Sacar(200.0m);
            conta.ExibirSaldo();
            conta.Sacar(2000.0m); // Tentativa de saque maior que o saldo
        }
    }
}
