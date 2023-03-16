using System.Globalization;
namespace CorseProductExercice {
    internal class Program {
        static void Main(string[] args) {

            Console.WriteLine("Entre os dados do produto");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture );
            Console.Write("Quantidade no estoque: ");
            int quantidade = int.Parse(Console.ReadLine());

            Product p = new Product(nome, preco, quantidade);


            Console.WriteLine();
            Console.WriteLine("Dados do produto: " + p);

            Console.WriteLine();
            Console.WriteLine("Digite a quantidade de produtos a ser adicionado: ");
            int qtd = int.Parse(Console.ReadLine());
            p.AdicionarProdutos(qtd);

            Console.WriteLine() ;   
            Console.WriteLine("Dados atualizados: " + p);


            Console.WriteLine();
            Console.WriteLine("Digite a quantidade de produtos a ser removidos: ");
            qtd = int.Parse(Console.ReadLine());
            p.RemoverProdutos(qtd);

            Console.WriteLine();
            Console.Write("Dados atualizados: " + p);

        }
    }
}