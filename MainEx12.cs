using System;

namespace AT
{
    internal class MainEx12
    {
        static void Main(string[] args)
        {
            // Cria o gerenciador de contatos
            GerenciadorContatosB gerenciador = new GerenciadorContatosB();

            int opcao;

            // Repete o menu até o usuário escolher sair
            do
            {
                gerenciador.ExibirMenu();

                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        gerenciador.AdicionarContato();
                        break;

                    case 2:
                        gerenciador.ModoExebicao();
                        break;

                    case 3:
                        Console.WriteLine("Saindo...");
                        break;

                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }

            } while (opcao != 3);
        }
    }
}


