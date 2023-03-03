using Course.Entities;
using System;

namespace Course
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Comment c1 = new Comment("Have a nice trip");
           Comment c2 = new Comment("Wow thats awesome");
           Post p1 = new Post(
                DateTime.Parse("21/06/2018 13:05:44"),
                "Tavelling to New Zealand",
                "I'm going to visit this wonderful country!",
                12  );

            p1.addComment(c1);
            p1.addComment(c2);



            Comment c3 = new Comment("Good Night");
            Comment c4 = new Comment("May the force be with you");
            Post p2 = new Post(
                 DateTime.Parse("28/07/2018 13:05:44"),
                 "Good Night Guys",
                 "See you tmr!",
                 5);

           p2.addComment(c3);
           p2.addComment(c4);

           Console.WriteLine(p1.ToString());
           Console.WriteLine(p2.ToString());
        }
    }
}