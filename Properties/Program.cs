﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{

   class Program
   {
      static void Main(string[] args)
      {
         var person = new Person(new DateTime (1990, 3, 3));
         Console.WriteLine(person.Age);

      }
   }
}
