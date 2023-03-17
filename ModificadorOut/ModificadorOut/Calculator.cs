using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModificadorOut {
    //O modificador out é similar ao ref (faz o parâmetro ser uma referência para a variável
    //original), mas não exige que a variável original seja iniciada.
    class Calculator {
        public static void Triple(int origin, out int result) {
            result = origin * 3;
        }
    }
}
