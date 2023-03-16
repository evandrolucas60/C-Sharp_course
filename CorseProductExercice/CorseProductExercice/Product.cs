using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorseProductExercice {
    internal class Product {
        public string Nome;
        public double Preco;
        public int Quantidade;

        public Product(string nome, double preco, int quantidade) {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        public double ValorTotalEmEstoque() {
            return Quantidade * Preco;
        }

        public void AdicionarProdutos(int quantidade) {
            Quantidade += quantidade;    
        }

        public void RemoverProdutos(int quantidade) {
            Quantidade -= quantidade;
        }



        public override string ToString() {
            return Nome 
                + ", $ " 
                + Preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + Quantidade
                + " unidades, Total: $"
                + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);

        }
    }
}
