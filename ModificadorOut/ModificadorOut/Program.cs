using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModificadorOut {
    class Program {
        static void Main(string[] args) {
            int a = 10;
            int triple;
            Calculator.Triple(a, out triple);
            Console.WriteLine(triple);
        }
    }
}
