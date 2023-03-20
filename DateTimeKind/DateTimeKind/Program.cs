using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeKind
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * 
             DateTimeKind

                Tipo enumerado especial que define três valores possíveis para a
                localidade da data:
                • Local [ fuso horário do sistema. Exemplo: São Paulo = GMT -3 ]
                • Utc [ fuso horário GMT (Greenwich Mean Time) ]
                • Unspecified

            Boa prática
                • Armazenar em formato UTC (texto: BD / Json / XML)
                • Instanciar e mostrar em formato Local
                Para converter um DateTime para Local ou Utc, você deve usar:
                • myDate.ToLocalTime()
                • myDate.ToUniversalTime()
             */

            //*******Demo***********

            DateTime d1 = DateTime.Parse("2000-08-15 13:05:58");
            DateTime d2 = DateTime.Parse("2000-08-15T13:05:58Z"); // cria local DateTime
            Console.WriteLine("d1: " + d1);
            Console.WriteLine("d1 Kind: " + d1.Kind);
            Console.WriteLine("d1 to Local: " + d1.ToLocalTime());
            Console.WriteLine("d1 to Utc: " + d1.ToUniversalTime());
            Console.WriteLine();
            Console.WriteLine("d2: " + d2);
            Console.WriteLine("d2 Kind: " + d2.Kind);
            Console.WriteLine("d2 to Local: " + d2.ToLocalTime());
            Console.WriteLine("d2 to Utc: " + d2.ToUniversalTime());
            Console.WriteLine();
            Console.WriteLine(d2.ToString("yyyy-MM-ddTHH:mm:ssZ")); // cuidado!
            Console.WriteLine(d2.ToUniversalTime().ToString("yyyy-MM-ddTHH:mm:ssZ"));

        }
    }
}
