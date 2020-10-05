using System;
using System.Threading;

namespace ObjectLocking
{
    class Program
    {
        void Test()
        {
            lock(this)
            {
                for (int i=1; i<=100; i++)
                {
                    Console.WriteLine("Test:" + i);
                }
            }
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            Thread t1 = new Thread(p.Test);
            Thread t2 = new Thread(p.Test);
            Thread t3 = new Thread(p.Test);
            t1.Start();
            t2.Start();
            t3.Start();
            // Object locking lock the code so that only one thread at a time can excess the method.
        }
    }
}
