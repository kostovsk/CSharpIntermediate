using System;

namespace DatabaseConnection
{
   public class DbCommand
   {
      public DbCommand()
      {
         throw new InvalidOperationException("Connection cannot be null.");
      }
      public DbCommand(DbConnection connection)
      {
        
      }

      public void Execute()
      {
         Console.WriteLine("Open the connection.");
         Console.WriteLine("Run the instruction.");
         Console.WriteLine("Close the connection.");
      }
   }
}
