using System;

namespace Stopwatch
{
   public class Stopwatch
   {
      public DateTime start;
      public DateTime end;
      public TimeSpan duration;

      //public Stopwatch()
      //{
      //   start = start;
      //   end = end;
      //   duration = duration;
      //}

      public void Start()
      {
         this.start = DateTime.Now;
      }

      public void End()
      {
         this.end = DateTime.Now;
      }

      public void Duration()
      {
         this.duration = end - start;
      }
   }
}
