using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stopwatch
{
   class Program
   {
      static void Main(string[] args)
      {
         var list = new List<string> { "start", "stop", "quit" };
         Console.WriteLine("Start/Stop the Stopwatch: ");
         var input = Console.ReadLine();
         input = input.ToLower();
         var stopw = new Stopwatch();

         while (list.Contains(input))
         {
            while (!input.Equals("quit"))
            {
               if (input.Equals("start"))
               {
                  stopw.Start();
                  input = Console.ReadLine();
                     if (input.Equals("start"))
                        throw new InvalidOperationException("Stopwatch started twice.");
                     else
                        continue;
               }
               if (input.Equals("stop"))
               {
                  stopw.End();
                  stopw.Duration();
                  Console.WriteLine(stopw.duration);
                  input = Console.ReadLine();
                  continue;
               }
            }
            break;
         }
         
      }
   }
}
