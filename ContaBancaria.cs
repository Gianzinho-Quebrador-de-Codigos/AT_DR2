using System;

namespace AT
{
    internal class ContaBancaria
    {
        public string titular;

        // Saldo privado para impedir alterações diretas fora da classe, eu usaria double,
        // mas como o enunciado pediu decimal, vou usar decimal mesmo.
        private decimal saldo;

        public ContaBancaria(string titular, decimal saldo)
        {
            this.titular = titular;
            this.saldo = saldo;
        }

        // Realiza um depósito na conta
        public void Depositar(decimal valor)
        {
            // Impede depósitos com valores negativos ou iguais a zero
            if (valor <= 0)
            {
                Console.WriteLine("O valor do depósito deve ser positivo!");
                return;
            }

            // Adiciona o valor ao saldo
            saldo += valor;
            Console.WriteLine($"Depósito de R$ {valor:F2} realizado com sucesso!");
        }

        // Realiza um saque da conta
        public void Sacar(decimal valor)
        {
            // Impede saques com valores negativos ou iguais a zero
            if (valor <= 0)
            {
                Console.WriteLine("O valor do saque deve ser positivo!");
                return;
            }

            // Verifica se existe saldo suficiente antes de realizar o saque
            if (saldo >= valor)
            {
                saldo -= valor;
                Console.WriteLine($"Saque de R$ {valor:F2} realizado com sucesso!");
            }
            else
            {
                Console.WriteLine("Saldo insuficiente para realizar o saque!");
            }
        }

        // Exibe os dados da conta sem permitir acesso direto ao saldo
        public void ExibirSaldo()
        {
            Console.WriteLine($"Titular: {titular}");
            Console.WriteLine($"Saldo atual: R$ {saldo:F2}");
        }
    }
}