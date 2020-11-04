using System;

namespace WorkflowEngine
{
   class VideoEditor : ITask
   {
      public void Execute()
      {
         Console.WriteLine("Edited a video.");
      }
   }
}
