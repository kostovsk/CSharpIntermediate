namespace WorkflowEngine
{
   public class Workflow
   {
      private readonly IWorkFlow _executor;

      public Workflow(IWorkFlow executor) 
      {
         _executor = executor;
      }
   }
}
