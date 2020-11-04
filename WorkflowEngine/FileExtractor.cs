using System;

namespace WorkflowEngine
{
   class FileExtractor : ITask
   {
      public void Execute()
      {
         Console.WriteLine("Extracted a file.");
      }
   }
}
