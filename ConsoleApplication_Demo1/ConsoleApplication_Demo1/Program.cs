﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication_Demo1
{
  class Program
  {
    static void Main(string[] args)
    {
      var cal = new Class1();
      var a = cal.sum(2, 3);
      Console.WriteLine("Sum is:" + a);
      Console.ReadKey();

    }
  }
}
