using System;

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
}
