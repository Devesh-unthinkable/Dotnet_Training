using System;

namespace GenericClass
{
    class Test<T1,T2>
    {
        public T1 number;
        public T2 name;
        public void show()
        {
            Console.WriteLine("Name = " + name + " Number = " + number);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Test<int, string> obj = new Test<int, string> { };
            obj.number = 10;
            obj.name = "Dev";
            obj.show();
        }
    }
}
