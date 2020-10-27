using System;

namespace StackOverflowPost
{
   public class Post
   {
      public string Title { get; set; }
      public string Description { get; set; }
      public DateTime Time { get; set; }
      public int UpVote { get; set; }
      public int DownVote { get; set; }

      public void uVote()
      {
         this.UpVote = UpVote + 1;
      }

      public void dVote()
      {
         this.DownVote = DownVote + 1;
      }

   }
}
