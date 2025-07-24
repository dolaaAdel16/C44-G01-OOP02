using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoOOP02.Overriding
{
    internal class TypeA
    {
        public int A { get; set; }

        public void fun01()
        {
            Console.WriteLine("fun01 from TypeA");
        }

        public virtual void fun02()
        {
            Console.WriteLine($"A : {A}");
        }
    }
}
