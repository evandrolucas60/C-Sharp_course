using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroducaoLINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            //Spcify the data source
            int[] numbers = new int[] { 2, 3, 4, 5 };

            //Define the query expression
            IEnumerable<int> result = numbers
                .Where(x => x % 2 == 0)
                .Select(x => 10 * x);

            //execute query
            foreach (int x in result)
            {
                Console.WriteLine(x);
            }
        }
    }
}
