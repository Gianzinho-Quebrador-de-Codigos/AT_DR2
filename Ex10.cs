using System;
using System.Collections.Generic;
using System.Text;

namespace AT
{
    internal class Ex10
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Jogo da adivinhação! Adivinhe um número entre 1 e 50.");

            Random random = new Random();

            // Gera um número aleatório entre 1 e 50
            int numeroAleatorio = random.Next(1, 51);

            // Permite que o usuário tenha até 5 tentativas
            for (int i = 0; i < 5; i++)
            {
                Console.Write($"{i + 1}ª tentativa - Digite seu palpite: ");
                int palpite = int.Parse(Console.ReadLine());

                // Verifica se o número digitado está entre 1 e 50
                if (palpite < 1 || palpite > 50)
                {
                    Console.WriteLine("Por favor, digite um número entre 1 e 50.");
                    i--;// Decrementa o contador para não contar essa tentativa
                    continue;
                }

                // Verifica se o usuário acertou o número
                if (palpite == numeroAleatorio)
                {
                    Console.WriteLine("Parabéns! Você acertou o número!");
                    break;
                }
                else
                {
                    // Verifica se o usuário chegou na última tentativa
                    if (i == 4)
                    {
                        Console.WriteLine("Fim do jogo! Você não conseguiu adivinhar o número.");
                    }
                    else
                    {
                        Console.WriteLine("Errado! Tente novamente.");
                    }
                }
            }
        }
    }
}
