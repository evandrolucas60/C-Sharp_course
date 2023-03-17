using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModificadorParams {
    class Program {
        static void Main(string[] args) {
            int Sum1 = Calculator.Sum(2,3);
            int Sum2 = Calculator.Sum(2,3,4);

            Console.WriteLine(Sum1);
            Console.WriteLine(Sum2);
        }
    }
}
