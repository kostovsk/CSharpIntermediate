﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Stopwatch
{
   public class Stopwatch
   {
      private DateTime start;
      private DateTime end;

      public void CalculateDuration(string input)
      {
         var list = new List<string> { "start", "stop", "quit" };

         while (!input.Equals("quit") && list.Contains(input))
         {
            if (input.Equals("start"))
            {
               this.start = DateTime.Now;
               input = Console.ReadLine();
               if (input.Equals("start"))
                  throw new InvalidOperationException("Stopwatch started twice.");
               else
                  continue;
            }
            if (input.Equals("stop"))
            {
               this.end = DateTime.Now;
               Console.WriteLine(GetDuration());
               input = Console.ReadLine();
               continue;
            }
            break;
         }
      }

      public TimeSpan GetDuration()
      {
         return end - start;
      }
   }
}
