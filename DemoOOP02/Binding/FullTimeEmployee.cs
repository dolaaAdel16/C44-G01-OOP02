using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoOOP02.Binding
{
    internal class FullTimeEmployee : Employee
    {

        public double Salary { get; set; }

        public void fun01()
        {
            Console.WriteLine("I'm Employee");
        }
        public override void fun02()
        {
            Console.WriteLine($"Salary : {Salary}");
        }


    }
}
