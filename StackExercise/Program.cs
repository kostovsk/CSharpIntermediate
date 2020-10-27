using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackExercise
{
   class Program
   {
      static void Main(string[] args)
      {
         var _stack = new Stack();
         _stack.Push(1);
         _stack.Push(2);
         _stack.Push(3);

         _stack.Clear();

         Console.WriteLine(_stack.Pop());
         Console.WriteLine(_stack.Pop());
         Console.WriteLine(_stack.Pop());

      }
   }
}
