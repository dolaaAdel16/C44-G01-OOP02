using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoOOP02.Binding
{
    internal class Employee
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public string Address { get; set; }

        public void fun01()
        {
            Console.WriteLine("I'm Employee");
        }
        public virtual void fun02()
        {
            Console.WriteLine($"Salary : ????");
        }
    }
}
