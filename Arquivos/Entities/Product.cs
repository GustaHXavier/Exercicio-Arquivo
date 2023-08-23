
namespace Entities {
    internal class Product {

        public string Nome { get; set; }
        public int Quantidade { get; set; }
        public double Preco { get; set; }

        public Product(string nome, int quantidade, double preco) {
            Nome = nome;
            Quantidade = quantidade;
            Preco = preco;
        }

        public double Total() {
            return Quantidade * Preco;
        }
    }
}
