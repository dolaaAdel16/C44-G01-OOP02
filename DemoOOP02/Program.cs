using DemoOOP02.Binding;
using DemoOOP02.Inheirtance;
using DemoOOP02.Overriding;
using System.Security.AccessControl;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DemoOOP02
{
    internal class Program
    {

        //static void EmployeeProcces(FullTimeEmployee employee)
        //{
        //    employee.fun01();
        //    employee.fun02();   
        //}

        //static void EmployeeProcces(PartTimeEmployee employee)
        //{
        //    employee.fun01();
        //    employee.fun02();
        //}

        //static void EmployeeProcces(Employee employee)
        //{
        //    employee.fun01();
        //    employee.fun02();
        //}

        #region V06
        //static int Sum(int x , int y )
        //{
        //    return x + y;
        //}

        //static int Sum(int x, int y , int z)
        //{
        //    return x + y + z;
        //}

        //static double Sum(double x, double y)
        //{
        //    return x + y;
        //}

        //static double Sum(double x, int y)
        //{
        //    return x + y;
        //}

        //static double Sum(int x, double y)
        //{
        //    return x + y;
        //} 
        #endregion

        static void Main()
        {
            #region V06
            //Console.WriteLine("V06");
            //Console.WriteLine("V04");
            //Console.WriteLine("Inheirtance");
            ////Parent parent = new Parent(1, 3);

            //////Console.WriteLine(parent);

            ////parent.fun01();
            ////parent.fun02();

            //Child child = new Child(1, 2, 3);   

            //child.fun01();
            //child.fun02();

            //Sum(1, 2);
            //Sum(1.4 , 6.2);
            //Sum(1, 6 , 2);

            //TypeB typeB = new TypeB() {A = 12 ,B = 13 };

            ////typeB.A = 12;
            ////typeB.B = 13;

            //Console.WriteLine(typeB.A);
            //Console.WriteLine(typeB.B);

            //typeB.fun01();
            //typeB.fun01(); 
            #endregion


            #region V07
            //Console.WriteLine("V07");

            //TypeA Ref ;

            ////Ref = new TypeA();
            ////Ref = new TypeB();

            //Ref = new TypeB();

            //Ref.A = 12;
            ////Ref.B = 10;

            //Ref.fun01();
            //Ref.fun02();     
            #endregion


            #region V08
            ////Console.WriteLine("V08");

            ////TypeA Ref = new TypeA(); 

            ////Ref = new TypeB();

            ////TypeB Ref = new TypeB();
            ////Ref = new TypeA(); 

            ////TypeA Ref = new TypeA();

            ////TypeB typeB = new TypeB(); 
            #endregion


            #region V09
            //FullTimeEmployee fulltime = new FullTimeEmployee()
            //{
            //    Id = 1 , 
            //    Name = "Ahmed" ,
            //    Email = "Ahmed@g.c" , 
            //    Address = "Cairo" , 
            //    Salary = 12000
            //};

            //PartTimeEmployee parttime = new PartTimeEmployee()
            //{
            //    Id = 1,
            //    Name = "Ahmed",
            //    Email = "Ahmed@g.c",
            //    Address = "Cairo",
            //    HourRate = 120 , 
            //    NumberOfHours = 200
            //};


            //EmployeeProcces(parttime); 
            #endregion

            #region V10
            //Console.WriteLine("V10");

            //TypeD typeA;
            ////typeA = new TypeA();
            ////typeA = new TypeB();
            ////typeA = new TypeC();
            //typeA = new TypeD();
            //typeA = new TypeE();


            //typeA.A = 10;
            ////typeA.B = 10;
            ////typeA.C = 10;
            ////typeA.D = 10 

            //typeA.fun01();
            //typeA.fun02();   
            #endregion

            // Assignment : 
            // access modefiries : 
            // 1 : protected : Accessible within the same class and by derived classes.
            // Not accessible from outside if not inherited.

            //    class Animal
            //    {
            //    protected void Speak()
            //    {
            //        Console.WriteLine("Animal sound");
            //    }
            //    }

            //class Dog : Animal
            //{
            //    public void Bark()
            //    {
            //        Speak(); // Allowed: Dog inherits Animal
            //    }
            //}


            //2 : private protected : Accessible only within the same class or a derived class in the same assembly.
            //Cannot be accessed from derived classes in another assembly.

            //    class Animal
            //{
            //    private protected void Move()
            //    {
            //        Console.WriteLine("Animal is moving");
            //    }
            //}

            //class Dog : Animal
            //{
            //    public void Walk()
            //    {
            //        Move(); // Allowed: Dog inherits Animal and in same assembly
            //    }
            //}

            //3: internal protected :  Accessible from the same assembly or any derived class
            //(even if it's in another assembly)

           


            //class Animal
            //        {
            //            protected internal void Eat()
            //            {
            //                Console.WriteLine("Animal is eating");
            //            }
            //        }            

            //        class Dog : Animal
            //        {
            //            public void Chew()
            //            {
            //                Eat(); // Allowed: inherited
            //            }
            //        }
            //
            //        class Zoo
            //        {
            //            public void Feed()
            //            {
            //                Animal a = new Animal();
            //                a.Eat(); // Allowed: same assembly
            //            }
            //        }
            //
            //
            //---
            //





    }
  }

}