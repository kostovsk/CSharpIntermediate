using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkflowEngine
{
   class VideoEditor : IWorkFlow
   {
      public void Execute()
      {
         Console.WriteLine("Edited a video.");
      }
   }

   class FileExtractor : IWorkFlow
   {
      public void Execute()
      {
         Console.WriteLine("Extracted a file.");
      }
   }

   class PdfConverter : IWorkFlow
   {
      public void Execute()
      {
         Console.WriteLine("Converted a pdf file.");
      }
   }

   class FileArchiver : IWorkFlow
   {
      public void Execute()
      {
         Console.WriteLine("Archived a file.");
      }
   }
   class Program
   {
      static void Main(string[] args)
      {
         WorkflowEngine workFlow = new WorkflowEngine();

         workFlow.AddWorkflow(new VideoEditor());
         workFlow.AddWorkflow(new FileExtractor());
         workFlow.AddWorkflow(new PdfConverter());
         workFlow.AddWorkflow(new FileArchiver());

         workFlow.Run();
      }
   }
}
