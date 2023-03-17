using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuartoAluguelEcercicio {
    class Program {
        static void Main(string[] args) {

            Console.Write("Quantos quartos serão alugados: ");
            int n = int.Parse(Console.ReadLine());

            Booking[] vect = new Booking[n];

            for (int i = 0; i < vect.Length; i++) {
                Console.WriteLine("Aluguel #" + (i + 1));
                Console.Write("Nome: ");
                String Nome = Console.ReadLine();
                Console.Write("Email: ");
                String Email = Console.ReadLine();
                Console.Write("Quarto: ");
                int Quarto = int.Parse(Console.ReadLine());

                vect[i] = new Booking { Nome = Nome, Email = Email, Quarto = Quarto };
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("Quartos ocupados:");
            for (int i = 0; i < vect.Length; i++) {
                Console.WriteLine(vect[i]);
            }



        }
    }
}
