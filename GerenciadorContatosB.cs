using System;
using System.Collections.Generic;
using System.Text;

namespace AT
{
    internal class GerenciadorContatosB
    {
        public void ExibirMenu()
        {
            Console.WriteLine("\n=== Gerenciador de Contatos ===");
            Console.WriteLine("1. Adicionar novo contato");
            Console.WriteLine("2. Listar contatos cadastrados");
            Console.WriteLine("3. Sair");
            Console.Write("Escolha uma opção: ");
        }

        public void AdicionarContato()
        {
            Console.Clear();

            Console.Write("Nome: ");
            string nome = Console.ReadLine();

            Console.Write("Telefone: ");
            string telefone = Console.ReadLine();

            Console.Write("E-mail: ");
            string email = Console.ReadLine();

            Contato contato = new Contato(nome, telefone, email);

            using (StreamWriter escritor = new StreamWriter("contatos.txt", true))
            {
                escritor.WriteLine(
                    $"{contato.Nome},{contato.Telefone},{contato.Email}"
                );
            }

            Console.WriteLine("\nContato cadastrado com sucesso!");
        }

        public void ModoExebicao()
        {
            Console.WriteLine("\n=== Selecionar Modo De Exibição ===");
            Console.WriteLine("1. Markdown");
            Console.WriteLine("2. Tabela");
            Console.WriteLine("3. Texto Puro");
            Console.Write("Escolha uma opção: ");

            int modoExibicao = int.Parse(Console.ReadLine());

            if (modoExibicao < 1 || modoExibicao > 3)
            {
                Console.WriteLine("Opção inválida! Voltando ao menu principal.");
                return;
            }

            if (modoExibicao == 1)
            {
                ListaMarkdown listar = new ListaMarkdown();
                listar.ListarContatos();
            }
            else if (modoExibicao == 2)
            {
                ListaTabela listar = new ListaTabela();
                listar.ListarContatos();
            }
            else if (modoExibicao == 3)
            {
                ListarContatos();
            }
        }

        public virtual void ListarContatos()
        {
            Console.Clear();
            Console.WriteLine("=== Contatos Cadastrados ===");

            if (!File.Exists("contatos.txt"))
            {
                Console.WriteLine("Não achei o arquivo");
                return;
            }

            using (StreamReader leitor = new StreamReader("contatos.txt"))
            {
                string linha;

                while ((linha = leitor.ReadLine()) != null)
                {
                    if (linha == "")
                        continue;

                    string[] dados = linha.Split(',');

                    Contato contato = new Contato(
                        dados[0],
                        dados[1],
                        dados[2]
                    );

                    Console.WriteLine(
                        $"Nome: {contato.Nome} | " +
                        $"Telefone: {contato.Telefone} | " +
                        $"Email: {contato.Email}"
                    );
                }
            }
        }
    }
}
