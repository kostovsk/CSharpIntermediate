﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseConnection
{
   public abstract class DbConnection
   {
      public string ConnectionString { get; set; }
      public TimeSpan Timeout { get; set; }

      public DbConnection(string MyString)
      {
         if (String.IsNullOrEmpty(MyString))
            throw new InvalidOperationException("Connection string cannot be null");
         this.ConnectionString = MyString;
      }

      public abstract void Opening();

      public abstract void Closing();
   }

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
      }
   }
}
