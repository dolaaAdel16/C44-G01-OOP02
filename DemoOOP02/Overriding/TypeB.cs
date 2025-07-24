using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoOOP02.Overriding
{
    internal class TypeB : TypeA
    {
        public int B { get; set; }

        public new void fun01()
        {
            Console.WriteLine("fun01 from TypeA");
        }

        //public override void fun02()
        //{
        //    Console.WriteLine($"A : {A}");
        //}
        override 
    }
}
