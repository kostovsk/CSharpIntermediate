using System;

namespace DatabaseConnection
{
   public class DbCommand
   {
      public DbCommand(DbConnection connection)
      {
         if (connection == null)
            throw new InvalidOperationException("Connection cannot be null.");
      }

      public void Execute()
      {
         Console.WriteLine("Open the connection.");
         Console.WriteLine("Run the instruction.");
         Console.WriteLine("Close the connection.");
      }
   }
}
