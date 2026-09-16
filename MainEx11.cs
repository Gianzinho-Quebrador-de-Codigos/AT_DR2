using System;

namespace AT
{

    // Decidi fazer orientado a objetos para deixar o código mais organizado e fácil de entender.
    // Criei uma classe Contato para representar cada contato, e uma classe GerenciadorContatos para gerenciar
    // a lista de contatos e as operações do menu.
    internal class MainEx11
    {
        static void Main(string[] args)
        {
            // Cria o gerenciador de contatos
            GerenciadorContatosA gerenciador = new GerenciadorContatosA();

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
                        gerenciador.ListarContatos();
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
