using System;
using System.Collections.Generic;
using System.Text;

namespace AT
{
    internal class Ex4
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite sua data de nascimento (dd/mm/aaaa):");
            DateTime nascimento = DateTime.Parse(Console.ReadLine());

            DateTime hoje = DateTime.Today;
            int anoAniversario = hoje.Year;

            if (hoje.Month > nascimento.Month || (hoje.Month == nascimento.Month && hoje.Day > nascimento.Day))
            {
                anoAniversario++;
            }

            DateTime proximoAniversario = new DateTime(anoAniversario, nascimento.Month, nascimento.Day);
            TimeSpan diferenca = proximoAniversario - hoje;

            if (nascimento.Year > hoje.Year)
            {
                Console.WriteLine("Ops! Parece que você não nasceu ainda hehe.");
            }
            else if (diferenca.Days == 0)
            {
                Console.WriteLine("Hoje é o seu aniversário! Feliz aniversário!!");
            }
            else if (diferenca.Days < 7)
            {
                Console.WriteLine(
                    $"Pera pera, seu aniversário é nessa semana!! " +
                    $"Faltam {diferenca.Days} dias para o seu aniversário!"
                );
            }
            else
            {
                Console.WriteLine(
                    $"Faltam {diferenca.Days} dias para o seu aniversário!"
                );
            }
        }
    }
}
