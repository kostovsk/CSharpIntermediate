using System.Collections.Generic;

namespace WorkflowEngine
{
   public class WorkflowEngine
   {
      public void Run(IWorkflow workflow)
      {
         foreach (var item in workflow.GetTasks())
         {
            item.Execute();
         }
      }
   }
}
