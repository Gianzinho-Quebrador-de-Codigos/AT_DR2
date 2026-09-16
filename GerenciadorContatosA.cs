using System;
using System.IO;

namespace AT
{
    internal class GerenciadorContatosA
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

            // Cria um objeto Contato com os dados informados
            Contato contato = new Contato(nome, telefone, email);

            // Abre o arquivo e adiciona o contato sem apagar os anteriores
            using (StreamWriter escritor = new StreamWriter("contatos.txt", true))
            {
                escritor.WriteLine(
                    $"{contato.Nome},{contato.Telefone},{contato.Email}"
                );
            }

            Console.WriteLine("\nContato cadastrado com sucesso!");
        }

        public void ListarContatos()
        {
            Console.Clear();
            Console.WriteLine("=== Contatos Cadastrados ===");

            // Verifica se o arquivo existe
            if (!File.Exists("contatos.txt"))
            {
                Console.WriteLine("Não achei o arquivo");
                return;
            }

            using (StreamReader leitor = new StreamReader("contatos.txt"))
            {
                string linha;
                bool possuiContatos = false;

                // Lê cada contato salvo no arquivo
                while ((linha = leitor.ReadLine()) != null)
                {
                    if (linha == "")
                    {
                        continue;
                    }

                    possuiContatos = true;
                    // Separa os dados usando a vírgula
                    string[] dados = linha.Split(',');

                    // Cria um objeto com os dados encontrados
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

                if (!possuiContatos)
                {
                    Console.WriteLine("Nenhum contato cadastrado.");
                }
            }
        }
    }
}