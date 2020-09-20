using System;

namespace FibonacciSeries
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Length of series: ");
            var str=(int)Console.Read();
            int k = str-48;
            Console.WriteLine(k);
            int a = 0, b = 1;
            Console.Write("{0} {1}", a, b);
            int c;
            for(int i=1;i<=k-2;i++)
            {
                c = a + b;
                a = b;
                b = c;
                Console.Write(" {0}", c);
            }
        }
    }
}
