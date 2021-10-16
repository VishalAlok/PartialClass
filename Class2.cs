using System;
using System.Collections.Generic;
using System.Text;

namespace PartialClass
{
    partial class MyClass
    {
        public void Details()
        {
            Console.WriteLine("Employee Number is " + EmpNo + " and Name is " + Name);
        }
    }
}
