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
         
         Console.WriteLine("Start/Stop the Stopwatch: ");
         var input = Console.ReadLine();
         var stopw = new Stopwatch();

         stopw.CalculateDuration(input.ToLower());
         
      }
   }
}
