using System;

namespace AT
{
    internal class Ex9A
    {
        // Array com capacidade para 5 produtos
        private Produto[] produtos = new Produto[5];

        // Quantos produtos já foram cadastrados
        private int quantidadeProdutos = 0;

        public void ExibirMenu()
        {
            Console.Clear();
            Console.WriteLine("\n=== Gerenciador de Estoque ===");
            Console.WriteLine("1. Inserir produto");
            Console.WriteLine("2. Listar produtos");
            Console.WriteLine("3. Sair");
            Console.Write("Escolha uma opção: ");
        }

        public void InserirProduto()
        {
            Console.Clear();
            // Verifica se o array já está cheio
            if (quantidadeProdutos >= produtos.Length)
            {
                Console.WriteLine("Limite de produtos atingido!");
                return;
            }

            Console.Write("Nome do produto: ");
            string nome = Console.ReadLine();

            Console.Write("Quantidade: ");
            int quantidade = int.Parse(Console.ReadLine());

            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine());

            Produto produto = new Produto(nome, quantidade, preco);

            // Adiciona o produto no Array
            produtos[quantidadeProdutos] = produto;

            // Contador de produtos + 1
            quantidadeProdutos++;

            Console.WriteLine("\nProduto cadastrado com sucesso!");
        }

        public void ListarProdutos()
        {
            Console.Clear();
            Console.WriteLine("=== Produtos Cadastrados ===");

            if (quantidadeProdutos == 0)
            {
                Console.WriteLine("Nenhum produto cadastrado.");
                return;
            }

            for (int i = 0; i < quantidadeProdutos; i++)
            {
                Console.WriteLine($"\nProduto {i + 1}");
                Console.WriteLine($"Nome: {produtos[i].GetNome()}");
                Console.WriteLine($"Quantidade: {produtos[i].GetQuantidade()}");
                Console.WriteLine($"Preço: R$ {produtos[i].GetPreco():F2}");
            }
        }

        static void Main(string[] args)
        {
            Ex9A estoque = new Ex9A();

            int opcao;

            do
            {
                estoque.ExibirMenu();

                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        estoque.InserirProduto();
                        break;

                    case 2:
                        estoque.ListarProdutos();
                        break;

                    case 3:
                        Console.WriteLine("Encerrando programa...");
                        break;

                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }

                if (opcao != 3)
                {
                    Console.WriteLine("\nPressione qualquer tecla para continuar...");
                    Console.ReadKey();
                }

            } while (opcao != 3);
        }
    }
}
