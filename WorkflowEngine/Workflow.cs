namespace WorkflowEngine
{
   public class Workflow
   {
      private readonly IExecutor _executor;

      public Workflow(IExecutor executor)
      {
         _executor = executor;
      }
   }
}
