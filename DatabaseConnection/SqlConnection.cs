using System;

namespace DatabaseConnection
{
   public class SqlConnection : DbConnection
   {
      public SqlConnection(string sqlConnection) : base(sqlConnection)
      {

      }

      public override void Opening()
      {
         Console.WriteLine("Opening an SQL Connection.");
      }

      public override void Closing()
      {
         Console.WriteLine("Closing an SQL Connection.");  
      }
   }
}
