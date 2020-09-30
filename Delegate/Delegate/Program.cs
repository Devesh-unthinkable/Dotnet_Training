using System;

namespace Delegate
{
    public delegate int MathOperations(int a, int b);
    public delegate string AddMessage(string str);
    class Program
    {
        public int AddNum(int a,int b)
        {
            return a + b;
        }
        public int MulNum(int a, int b)
        {
            return a * b;
        }
        public static string ShowMessage(string str)
        {
            return "Hello " + str;
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            MathOperations del1 = new MathOperations(p.AddNum);
            AddMessage del2 = new AddMessage(Program.ShowMessage);
            int a = del1.Invoke(10, 20);
            int b = del1(20, 5);
            del1 += p.MulNum;
            int c = del1(3, 5);
            //int a = del1(4, 10);
            Console.WriteLine("Value = " + a + " & " + b + " & " + c);
            string msg = del2("Dev");
            Console.WriteLine("Message = " + msg);
        }
    }
}
