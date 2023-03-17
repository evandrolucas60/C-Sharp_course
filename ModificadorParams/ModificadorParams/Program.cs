using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModificadorParams {
    class Program {
        static void Main(string[] args) {
            int Sum1 = Calculator.Sum(new int[] { 5, 5, 5 });
            
            Console.WriteLine(Sum1);
        }
    }
}
