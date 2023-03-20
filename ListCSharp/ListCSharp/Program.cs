using System;
using System.Collections.Generic;

namespace ListCSharp {
    internal class Program {
        static void Main(string[] args) {

            List<String> list = new List<String>();

            list.Add("Maria");
            list.Add("Alex");
            list.Add("Bob");
            list.Add("Anne");
            list.Add("Danielly");
            list.Insert(2, "Marco");

            foreach (String obj in list) {
                Console.WriteLine(obj);
            }

            Console.WriteLine("list count: " + list.Count);

            String s1 = list.Find(x => x[0] == 'A');//lambda expression
            Console.WriteLine("First 'A': " + s1);

            String s2 = list.FindLast(x => x[0] == 'A');//lambda expression
            Console.WriteLine("Last 'A': " + s2);

            int pos1 = list.FindIndex(x => x[0] == 'A');//lambda expression
            Console.WriteLine("First position 'A': " + pos1);

            int pos2 = list.FindLastIndex(x => x[0] == 'A');//lambda expression
            Console.WriteLine("First position 'A': " + pos2);

            List<String> list2 = list.FindAll(x => x.Length == 5);
            Console.WriteLine("---------------------------------");
            foreach (String obj in list2) {
                Console.WriteLine(obj);
            }

            list.Remove("Alex");
            Console.WriteLine("----------------------------------");
            foreach (String obj in list) {
                Console.WriteLine(obj);
            }

            list.RemoveAt(4);
            Console.WriteLine("----------------------------------");
            foreach (String obj in list) {
                Console.WriteLine(obj);
            }


            list.RemoveAll(x => x[0] == 'M');
            Console.WriteLine("----------------------------------");
            foreach (String obj in list) {
                Console.WriteLine(obj);
            }

            list.RemoveRange(0, 1);
            Console.WriteLine("----------------------------------");
            foreach (String obj in list) {
                if (obj != null) {
                    Console.WriteLine("restaram:  " + obj);
                }
                else {
                    Console.WriteLine("This list is null");
                }
            }

        }
    }
}