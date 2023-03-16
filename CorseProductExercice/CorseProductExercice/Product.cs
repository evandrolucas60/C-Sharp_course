using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorseProductExercice {
    internal class Product {
        private string _nome;
        private double _preco;
        private int _quantidade;

        public Product() { }

        public Product(string nome, double preco, int quantidade) {
            _nome = nome;
            _preco = preco;
            _quantidade = quantidade;
        }

        //properties (encapsulamento)
        public string Nome {
            get { return _nome; }
            set { _nome = value; }
        }

        public double Preco {
            get { return _preco; }
        }

        public int Quantidade {
            get { return _quantidade; }
        }

        //getters and setters

        /*
        public string GetNome() {
            return _nome;
        }

        public void SetNome(string nome) {
            _nome = nome;
        }

        public double GetPreco() {
            return _preco;
        }

        public int GetQuantidade() {
            return _quantidade;
        }
        */

        public double ValorTotalEmEstoque() {
            return _quantidade * _preco;
        }

        public void AdicionarProdutos(int quantidade) {
            _quantidade += quantidade;
        }

        public void RemoverProdutos(int quantidade) {
            _quantidade -= quantidade;
        }



        public override string ToString() {
            return _nome
                + ", $ "
                + _preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + _quantidade
                + " unidades, Total: $"
                + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);

        }
    }
}
