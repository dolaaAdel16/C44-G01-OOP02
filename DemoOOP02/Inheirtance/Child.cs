using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoOOP02.Inheirtance
{
    internal class Child : Parent 
    {
        public int Z { get; set; }

        public Child(int X , int Y , int Z) : base(X , Y)
        {
            this.Z = Z; 
        }

        public override string ToString()
        {
            return $"X = {X}, Y = {Y} , Z = {Z}";
        }

        public void fun01()
        {

            Console.WriteLine("I'm Child[Derived] ");
        }

        public void fun02()
        {

            Console.WriteLine($"X : {X} , Y : {Y} , Z : {Z}");
        }

    }
}
