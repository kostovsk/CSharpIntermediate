using System;

namespace WorkflowEngine
{
   class FileArchiver : ITask
   {
      public void Execute()
      {
         Console.WriteLine("Archived a file.");
      }
   }
}
