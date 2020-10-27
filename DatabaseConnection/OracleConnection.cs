using System;

namespace DatabaseConnection
{
   public class OracleConnection : DbConnection
   {
      public OracleConnection(string oracleString) : base(oracleString)
      {

      }
      public override void Opening()
      {
         Console.WriteLine("Opening an Oracle Connection");
      }

      public override void Closing()
      {
         Console.WriteLine("Closing an Oracle Connection.");
      }
   }
}
