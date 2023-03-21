using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComposicaoObjetosII.Entities
{
    class Comment
    {
        public String Text { get; set; }

        public Comment()
        {
        }

        public Comment(string text)
        {
            this.Text = text;
        }
    }
}

