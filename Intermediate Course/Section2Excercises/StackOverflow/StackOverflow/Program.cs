using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackOverflow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Init new Post
            var post = new Post();

            // Accept user input
            Console.WriteLine("Type Upvote or Downvote to vote on post.");
            var input = Console.ReadLine();

            while (!string.IsNullOrEmpty(input))
            {
                if (input.ToLower() == "upvote")
                {
                    post.UpVote();
                    Console.WriteLine("Type Upvote or Downvote to vote on post.");
                    input = Console.ReadLine();
                }
                else if (input.ToLower() == "downvote")
                {
                    post.DownVote();
                    Console.WriteLine("Type Upvote or Downvote to vote on post.");
                    input = Console.ReadLine();
                }
                else
                {
                    throw new Exception("Unrecognized input.");
                }
            }

            Console.WriteLine(post.CurrentVoteCount());
        }
    }
}
