using System.Collections.Generic;

namespace ListCSharp {
    internal class Program {
        static void Main(string[] args) {
           
            List<String> list = new List<String>();   

            list.Add("Maria");
            list.Add("Alex");
            list.Add("Bob");
            list.Add("Anne");
            list.Insert(2, "Marco");

            foreach (String obj in list) { 
                Console.WriteLine(obj);
            }

            Console.WriteLine( "list count: " + list.Count);

            String s1 = list.Find(Test);
            Console.WriteLine("First 'A': " + s1);
        }

        static bool Test(String s) {
            return s[0] == 'A';
        }
    }
}