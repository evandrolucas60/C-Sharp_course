using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nullable_example {
    class Program {
        static void Main(string[] args) {
            //double x = null; //erro - pois a variável double não pode receber um valor null

            Nullable<double> x = null; //declaração padrão de Nullable

            double? y = 10.0;// declaração Nullable simplificada 


            Console.WriteLine(x.GetValueOrDefault()); //retorna o valor da variável se for null retorna o valor padrão
            Console.WriteLine(y.GetValueOrDefault());//retorna o valor da variável se for null retorna o valor padrão

            Console.WriteLine(x.HasValue);//verifica se variável possui um valor
            Console.WriteLine(y.HasValue);//verifica se variável possui um valor


            if (x.HasValue) {
                Console.WriteLine(x.Value);
            }else {
                Console.WriteLine("the x value is null");
            }


            if (y.HasValue) {
                Console.WriteLine(y.Value);
            }
            else {
                Console.WriteLine("the y value is null");
            }


            //Operador de coalescência nula

            double w = x ?? 0.0; //variável retorna o valor de x se x == null variável retorna 0.0;
            Console.WriteLine(w);



        }
    }
}
