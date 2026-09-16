using System;
using System.Collections.Generic;
using System.Text;

namespace AT
{
    internal class ListaMarkdown :GerenciadorContatosB
    {
        public override void ListarContatos()
        {
            Console.Clear();
            Console.WriteLine("=== Contatos Cadastrados (Markdown) ===");
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
                    Console.WriteLine($"- **Nome:** {contato.Nome}");
                    Console.WriteLine($"  - Telefone: {contato.Telefone}");
                    Console.WriteLine($"  - Email: {contato.Email}");
                }
                if (!possuiContatos)
                {
                    Console.WriteLine("Nenhum contato cadastrado.");
                }
            }
        }
    }
}
