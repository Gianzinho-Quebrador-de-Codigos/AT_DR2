namespace AT
{
    internal class Produto
    {
        private string nome;
        private int quantidade;
        private double preco;

        public Produto(string nome, int quantidade, double preco)
        {
            this.nome = nome;
            this.quantidade = quantidade;
            this.preco = preco;
        }

        public string GetNome()
        {
            return nome;
        }

        public int GetQuantidade()
        {
            return quantidade;
        }

        public double GetPreco()
        {
            return preco;
        }
    }
}