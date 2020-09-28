using System;

namespace CSharpMisc
{
    #region Sealed Class
    sealed class SealedClass
    {
        public SealedClass()
        {
            Console.WriteLine("Sealed Class");
        }
    }
    class DerivedClass //: SealedClass // wont inherit
    {
        public DerivedClass()
        {
            Console.WriteLine("Derived Class");
        }
    }
    #endregion
    #region Upcasting vs Downcasting
    class Shape
    {
        public Shape()
        {
            Console.WriteLine("Shape Class");
        }
    }
    class Circle : Shape
    {
        public Circle()
        {
            Console.WriteLine("Circle Class");
        }
    }
    #endregion
    #region Const and Static
    class ConstStaticTest
    {
        const int num1 = 10;
        static int num2 = 10;
        public int AddNum(int num)
        {
            //num1 += num;
            num2 += num;
            return num2;
        }
    }
    #endregion
    #region Abstract Class
    abstract class Animal
    {
        public abstract void Sound();
    }
    class Dog : Animal
    {
        public override void Sound()
        {
            Console.WriteLine("Dog Sound");
        }
    }
    #endregion
    #region Interface
    interface IExample
    {
        void Alpha()
        {
            Console.WriteLine("IAlpha method");
        }
        void Beta()
        {

        }
        void Gamma()
        {

        }
    }
    class Example : IExample
    {
        public void Alpha()
        {
            Console.WriteLine("Alpha method");
        }
        public void Beta()
        {
            Console.WriteLine("Beta method");
        }
        public void Gamma()
        {
            Console.WriteLine("Gamma method");
        }
    }
    #endregion
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program Class");
            #region Upcasting vs Downcasting
            /*
            Shape obj1 = new Circle();
            Circle obj2 = (Circle)obj1;
            */
            #endregion
            #region Boxing vs Unboxing
            /*
            int num1 = 10;
            Object obj = num1;
            int num2 = (int)obj;
            Console.WriteLine("Object = " + obj);
            Console.WriteLine("Number = " + num2);
            */
            #endregion
            #region Const and Static
            /*
            ConstStaticTest obj = new ConstStaticTest();
            Console.WriteLine($"Numbers are {obj.AddNum(10)}, {obj.AddNum(20)}");
            */
            #endregion
            #region Abstract
            /*
            Dog obj = new Dog();
            obj.Sound();
            */
            #endregion
            #region Interface
            /*
            Example obj = new Example();
            obj.Alpha();
            obj.Beta();
            obj.Gamma();
            */
            #endregion
        }
    }
}
