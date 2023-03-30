using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashSertESortedSet
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<String> set = new HashSet<String>();

            set.Add("Tv");
            set.Add("Notebook");
            set.Add("Tablet");

            Console.WriteLine(set.Contains("Computer"));

            foreach (String p in set)
            {
                Console.WriteLine(p);
            }
        }
    }
}
