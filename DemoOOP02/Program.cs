using DemoOOP02.Binding;
using DemoOOP02.Inheirtance;
using DemoOOP02.Overriding;

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



        }
    }
}
