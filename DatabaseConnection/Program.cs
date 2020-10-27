using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseConnection
{
   class Program
   {
      static void Main(string[] args)
      {
         string constring = "129231.123/dadsdw";
         var dbcon = new SqlConnection(constring);
         dbcon.Opening();
         dbcon.Closing();

         var dbcon2 = new OracleConnection(constring);
         dbcon2.Opening();
         dbcon2.Closing();

         var dbcom = new DbCommand(new SqlConnection(constring));
         dbcom.Execute();

         var dbcom2 = new DbCommand(new OracleConnection(constring));
         dbcom2.Execute();
      }
   }
}
