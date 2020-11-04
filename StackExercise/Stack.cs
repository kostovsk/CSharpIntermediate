using System;
using System.Collections.Generic;
using System.Linq;

namespace StackExercise
{
   public class Stack
   {
      private List<object> _stack;

      public Stack()
      {
         _stack = new List<object>();
      }

      public void Push(object obj)
      {
         _stack.Add(obj);
      }

      public void Push()
      {
         throw new InvalidOperationException("The object is null");
      }

      public object Pop()
      {
         if (_stack.Any() != true)
            throw new InvalidOperationException("Cannot add to an empty list");

         var count = _stack.Count - 1;
         var item = _stack[count];

         _stack.RemoveAt(count);

         return item;
      }

      public void Clear()
      {
         if (_stack == null)
            throw new InvalidOperationException("Cannot clear an empty list");

         _stack.Clear();
      }
   }
}
