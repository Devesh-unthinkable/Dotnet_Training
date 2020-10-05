using System;
using System.Threading;

namespace Threads
{
    class Program
    {
        public void Test1()
        {
            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine("Test1() :" + i);
            }
        }
        static public void Test2()
        {
            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine("Test2() :" + i);
                if(i==50)
                {
                    Thread.Sleep(5000);
                }
            }
        }
        static public void Test3()
        {
            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine("Test3() :" + i);
            }
        }
        static void Main(string[] args)        
        {
            Program p = new Program(); //1
            Thread t1 = new Thread(p.Test1); 
            Thread t2 = new Thread(Test2);
            Thread t3 = new Thread(Test3);
            t1.Start();
            t2.Start();
            t3.Start();
            Console.WriteLine("Main Thread");
        }
    }
}
