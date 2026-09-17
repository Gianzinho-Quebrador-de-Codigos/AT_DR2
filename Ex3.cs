using System;

class Ex3
{
    static void Main(string[] args)
    {
        int num1 = 0;
        int num2 = 0;
        // Solicita ao usuário que escolha dois números diferentes de zero
        while (num1 == 0 || num2 == 0)
        {
            Console.WriteLine("Escolha o primeiro número:");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Escolha o segundo número:");
            num2 = int.Parse(Console.ReadLine());

            // Verifica se algum dos números é zero
            if (num1 == 0 || num2 == 0)
            {
                Console.WriteLine("Os números não podem ser zero. Por favor, tente novamente.");
            }
        }

        // Solicita ao usuário que escolha uma operação
        Console.WriteLine("Escolha uma operação" +
            "(1. Soma, 2. Subtração, 3. Multiplicação, 4. Divisão):");
        string operacao = Console.ReadLine();

        // Realiza a operação escolhida
        double resultado = 0;
        switch (operacao)
        {
            case "1":
                resultado = num1 + num2;
                break;
            case "2":
                resultado = num1 - num2;
                break;
            case "3":
                resultado = num1 * num2;
                break;
            case "4":
                resultado = num1 / num2;
                break;
        }

        // Exibe o resultado
        Console.WriteLine("O resultado é: " + resultado);
    }
}
