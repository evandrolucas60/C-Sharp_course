using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModificadorRef {
    class Calculator {
        //modificador ref faz o parâmetro ser uma refêrencia para a variável
        public static void Triple(ref int x) {
             x = x * 3;
        }
    }
}
