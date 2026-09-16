using System;
using System.Collections.Generic;
using System.Text;

namespace AT
{
    internal class Ex5
    {
        static void Main(string[] args)
        {
            DateTime formatura = new DateTime(2028, 06, 30);

            Console.WriteLine("=== Contador de Tempo Para a Formatura! ===");
            Console.WriteLine("Digite a data atual (dd/mm/aaaa):");
            DateTime dataAtual = DateTime.Parse(Console.ReadLine());

            if (dataAtual > DateTime.Today)
            {
                Console.WriteLine("Ops! A data atual não pode ser uma data futura.");
                return;
            }

            if (dataAtual > formatura)
            {
                Console.WriteLine("Parabéns! Você já deveria estar formado!");
                return;
            }

            int anos = formatura.Year - dataAtual.Year;
            int meses = formatura.Month - dataAtual.Month;
            int dias = formatura.Day - dataAtual.Day;

            if (meses < 0)
            {
                anos--;
                meses += 12;
            }

            if (dias < 0)
            {
                meses--;
                dias += 30;
            }

            if (anos == 0 && meses <= 6)
            {
                Console.WriteLine(
                    $"A reta final chegou! Prepare-se para a formatura! " +
                    $"Faltam {anos} anos, {meses} meses e {dias} dias!"
                );
            }
            else
            {
                Console.WriteLine(
                    $"Faltam {anos} anos, {meses} meses e {dias} dias para a formatura!"
                );
            }
        }
    }
}
