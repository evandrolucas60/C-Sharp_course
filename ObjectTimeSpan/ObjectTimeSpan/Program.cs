using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectTimeSpan {
    class Program {
        static void Main(string[] args) {
            // Um objeto TimeSpan internamente armazena uma duração na forma
            //de ticks(100 nanosegundos)

            TimeSpan t0 = new TimeSpan(0, 1, 30);
            Console.WriteLine(t0);
            Console.WriteLine(t0.Ticks);


            /*
            * Construtores
           • TimeSpan()
           • TimeSpan(ticks)
           • TimeSpan(horas, minutos, segundos)
           • TimeSpan(dias, horas, minutos, segundos)
           • TimeSpan(dias, horas, minutos, segundos, milissegundos)

           */

            //Demo - construtores

            TimeSpan t1 = new TimeSpan();
            TimeSpan t2 = new TimeSpan(900000000L);
            TimeSpan t3 = new TimeSpan(2, 11, 21);
            TimeSpan t4 = new TimeSpan(1, 2, 11, 21);
            TimeSpan t5 = new TimeSpan(1, 2, 11, 21, 321);

            Console.WriteLine();
            Console.WriteLine("-------------saída construtores---------------");
            Console.WriteLine(t1);
            Console.WriteLine(t2);
            Console.WriteLine(t3);
            Console.WriteLine(t4);
            Console.WriteLine(t5);
            Console.WriteLine("----------------------------------------------");

            //Demo - métodos From
            TimeSpan t7 = TimeSpan.FromDays(1.5);
            TimeSpan t8 = TimeSpan.FromHours(1.5);
            TimeSpan t9 = TimeSpan.FromMinutes(1.5);
            TimeSpan t10 = TimeSpan.FromSeconds(1.5);
            TimeSpan t11 = TimeSpan.FromMilliseconds(1.5);
            TimeSpan t12 = TimeSpan.FromTicks(900000000L);

            Console.WriteLine();
            Console.WriteLine("-------------saída métodos--------------------");
            Console.WriteLine(t7);
            Console.WriteLine(t8);
            Console.WriteLine(t9);
            Console.WriteLine(t10);
            Console.WriteLine(t11);
            Console.WriteLine(t12);
            Console.WriteLine("----------------------------------------------");
        }

    }
}
