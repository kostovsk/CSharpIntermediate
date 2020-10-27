using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackOverflowPost
{
   class Program
   {
      static void Main(string[] args)
      {
         var post = new Post();
         Console.WriteLine("Please enter a title:");
         post.Title = Console.ReadLine();
         Console.WriteLine("Please enter a description:");
         post.Description = Console.ReadLine();
         post.Time = DateTime.Now;
         Console.WriteLine("Please upvote or downvote post (enter quit to exit):");

         var input = Console.ReadLine();
         while (!input.Equals("quit"))
         {
            if (input.Equals("upvote"))
            {
               post.uVote();
               Console.WriteLine("Please upvote or downvote post (enter quit to exit):");
               input = Console.ReadLine();
            }
            else if (input.Equals("downvote"))
            {
               post.dVote();
               Console.WriteLine("Please upvote or downvote post (enter quit to exit):");
               input = Console.ReadLine();
            }
         }

         Console.WriteLine("");
         Console.WriteLine(post.Title);
         Console.WriteLine(post.Description);
         Console.WriteLine(post.Time);
         Console.WriteLine("This post has {0} upvotes and {1} downvotes.", post.UpVote, post.DownVote);

      }
   }
}
