using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoOOP02.Binding
{
    internal class PartTimeEmployee : Employee
    {
        public int HourRate { get; set; }   

        public int NumberOfHours { get; set; }

        public new void fun01()
        {
            Console.WriteLine("I'm Part Time Employee");
        }
        public override void fun02()
        {
            Console.WriteLine($"Salary : {HourRate * NumberOfHours}");
        }
    }
}
