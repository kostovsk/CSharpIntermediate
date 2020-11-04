using System;

namespace WorkflowEngine
{
   class PdfConverter : ITask
   {
      public void Execute()
      {
         Console.WriteLine("Converted a pdf file.");
      }
   }
}
