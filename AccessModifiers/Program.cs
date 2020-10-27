using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers
{
   public class Person
   {
      private DateTime _birthdate;

      public void SetBirthdate(DateTime birthdate)
      {
         this._birthdate = birthdate;
      }

      public DateTime GetBirthdate()
      {
         return _birthdate;
      }

   }

   class Program
   {
      static void Main(string[] args)
      {
         var person = new Person();
         person.SetBirthdate(new DateTime(1990, 3, 3));
         Console.WriteLine(person.GetBirthdate());
      }
   }
}
