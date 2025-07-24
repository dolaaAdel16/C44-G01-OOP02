using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoOOP02
{
    class TypeA
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

    class TypeB : TypeA
    {
        public int B { get; set; }
        public void fun01()
        {
            Console.WriteLine("fun01 from TypeB");
        }
        public override  void fun02()
        {
            Console.WriteLine($"A : {A} , B : {B}");
        }
    }

    class TypeC : TypeB
    {
        public int C { get; set; }
        public void fun01()
        {
            Console.WriteLine("fun01 from TypeC");
        }
        public override void fun02()
        {
            Console.WriteLine($"A : {A} , B : {B} , C : {C}");
        }
    }

    class TypeD : TypeC
    {
        public int D { get; set; }
        public void fun01()
        {
            Console.WriteLine("fun01 from TypeD");
        }
        public virtual new void fun02()
        {
            Console.WriteLine($"A : {A} , B : {B} , C : {C} , D : {D}");
        }
    }

    class TypeE : TypeD
    {
        public int E { get; set; }
        public void fun01()
        {
            Console.WriteLine("fun01 from TypeE");
        }
        public override void fun02()
        {
            Console.WriteLine($"A : {A} , B : {B} , C : {C} , D : {D} , E : {E}");
        }
    }
}
