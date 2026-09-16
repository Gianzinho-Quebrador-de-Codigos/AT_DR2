using System;
using System.Collections.Generic;
using System.Text;

namespace AT
{
    internal class MainEx8
    {
        static void Main(string[] args)
        {
            Gerente gerente = new Gerente("Maria Souza", "Gerente de Vendas", 5000.0);
            Console.WriteLine($"Nome: {gerente.GetNome()}");
            Console.WriteLine($"Cargo: {gerente.GetCargo()}");
            Console.WriteLine($"Salário: {gerente.GetSalario()}");
        }
    }
}
