using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProduct {
    class Program {
        static void Main(string[] args) {

            int n = int.Parse(Console.ReadLine());

            Class1[] vect = new Class1[n];

            for (int i = 0; i < vect.Length; i++) {
                string nome = Console.ReadLine();
                int preco = int.Parse(Console.ReadLine());
                vect[i] = new Class1(nome, preco);
            }

            double sum = 0.0;
            for (int i = 0; i < n; i++) {
                sum += vect[i].preco;
            }

            double avg = sum / n;
            Console.WriteLine("THE AVERAGE IS: " + avg);
        }
    }
}
