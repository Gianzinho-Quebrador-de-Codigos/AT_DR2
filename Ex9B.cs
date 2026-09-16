using System;
using System.Globalization;
using System.IO;

namespace AT
{
    internal class Ex9B
    {
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

            Console.Write("Nome do produto: ");
            string nome = Console.ReadLine();

            Console.Write("Quantidade: ");
            int quantidade = int.Parse(Console.ReadLine());

            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine());

            // Cria o arquivo caso não exista e adiciona o produto
            using (StreamWriter escritor = new StreamWriter("estoque.txt", true))
            {
                escritor.WriteLine(
                    $"{nome},{quantidade},{preco.ToString(CultureInfo.InvariantCulture)}"
                );
            }

            Console.WriteLine("\nProduto cadastrado com sucesso!");
        }

        public void ListarProdutos()
        {
            Console.Clear();
            Console.WriteLine("=== Produtos Cadastrados ===");

            // Verifica se o arquivo existe
            if (!File.Exists("estoque.txt"))
            {
                Console.WriteLine("Não achei o arquivo mas vou criar um novo");
                File.Create("estoque.txt").Dispose();
            }

            using (StreamReader leitor = new StreamReader("estoque.txt"))
            {
                string linha;
                bool possuiProdutos = false;

                // Lê cada produto salvo no arquivo
                while ((linha = leitor.ReadLine()) != null)
                {
                    if (linha == "")
                    {
                        continue;
                    }

                    string[] dadosProduto = linha.Split(',');

                    // Verifica se os dados estão no formato correto
                    if (dadosProduto.Length != 3)
                    {
                        Console.WriteLine("Produto com formato inválido no arquivo.");
                        continue;
                    }

                    string nome = dadosProduto[0];
                    int quantidade = int.Parse(dadosProduto[1]);
                    double preco = double.Parse(dadosProduto[2]);

                    Console.WriteLine(
                        $"Produto: {nome} | Quantidade: {quantidade} | Preço: R$ {preco:F2}"
                    );

                    possuiProdutos = true;
                }

                if (!possuiProdutos)
                {
                    Console.WriteLine("Nenhum produto cadastrado.");
                }
            }
        }

        static void Main(string[] args)
        {
            Ex9B estoque = new Ex9B();

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
                    // Estava buscando um método para voltar ao menu e descobri que o Console.ReadKey() faz exatamente isso, então utilizei ele.
                    Console.ReadKey();
                }

            } while (opcao != 3);
        }
    }
}
