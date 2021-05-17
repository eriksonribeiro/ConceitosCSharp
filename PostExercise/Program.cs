using System;
using PostExercise.Entities;

namespace PostExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Comment commentOne = new Comment("Have a nice trip!");
            Comment commentTwo = new Comment("Wow that's awesome!");

            Post postOne = new Post(
                 DateTime.Parse("21/06/2018 13:04:44")
                , "Traveling to New Zeland"
                , "I'm going to visit this country!"
                , 12
                );
            postOne.AddComment(commentOne);
            postOne.AddComment(commentTwo);

            Console.WriteLine(postOne);

            Console.ReadKey();

        }
    }
}
