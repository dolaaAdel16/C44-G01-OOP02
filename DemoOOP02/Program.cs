using DemoOOP02.Inheirtance;

namespace DemoOOP02
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Inheirtance");
            //Parent parent = new Parent(1, 3);

            ////Console.WriteLine(parent);

            //parent.fun01();
            //parent.fun02();

            Child child = new Child(1, 2, 3);   

            child.fun01();
            child.fun02();
        }
    }
}
