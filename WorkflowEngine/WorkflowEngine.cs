using System.Collections.Generic;

namespace WorkflowEngine
{
   public class WorkflowEngine
   {
      private List<IWorkFlow> list;

      public WorkflowEngine()
      {
         list = new List<IWorkFlow>();
      }

      public void AddWorkflow(IWorkFlow iWorkflow)
      {
         list.Add(iWorkflow);
      }

      public void RemoveWorkflow(IWorkFlow iWorkflow)
      {
         list.Remove(iWorkflow);
      }

      public void Run()
      {
         foreach (var item in list)
         {
            item.Execute();
         }
      }
   }
}
