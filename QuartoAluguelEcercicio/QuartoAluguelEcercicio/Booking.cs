using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuartoAluguelEcercicio {
    class Booking {

        public String Nome { get; set; }
        public String Email { get; set; }
        public int Quarto { get; set; }

        public override string ToString() {
            return Quarto  
                   + ": " 
                   + Nome
                   + ", "
                   + Email;
        }
    }
}
