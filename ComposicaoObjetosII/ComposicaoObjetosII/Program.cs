using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ComposicaoObjetosII.Entities;

namespace ComposicaoObjetosII
{
    class Program
    {
        static void Main(string[] args)
        {
            Comment C1 = new Comment("Have a nice trip!");
            Comment C2 = new Comment("Wow that's awesome!");

            Post P1 = new Post(
                DateTime.Parse("21/03/2023 13:05:44"), "Traveling to New Zealand", "I'm going to visit this wonderful country!", 12);

            P1.AddComment(C1);
            P1.AddComment(C2);

            Comment C4 = new Comment("Good night!");
            Comment C5 = new Comment("May the force be with you");

            Post P2 = new Post(
                DateTime.Parse("28/07/2023 23:14:19"), "Good night guys", "See you tomorrow", 5);

            P2.AddComment(C4);
            P2.AddComment(C5);

            Console.WriteLine(P1);
            Console.WriteLine(P2);
        }
    }
}
