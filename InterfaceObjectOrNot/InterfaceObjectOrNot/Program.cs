using System;

namespace InterfaceObjectOrNot
{
    abstract class AClass
    {
        abstract public void PrintOnScreen()
        {
            Console.WriteLine("Body of Abstract");
        }
    }
    interface ITest
    {
        static void PrintOnScreen()
        {
            Console.WriteLine("Body of interface");
        }
    }
    class Program : AClass
    {
        public void PrintOnScreen()
        {
            Console.WriteLine("Body of Abstract");
        }
        static void Main(string[] args)
        {
            //Program.PrintOnScreen();
        }
    }
}
