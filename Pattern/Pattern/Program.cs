using System;
using System.Dynamic;

namespace Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter height of pattern: ");
            int str = (int)Console.Read();
            int k = str - 48;
            for(int i=k;i>0;i--)
            {
                for(int j=i;j>0;j--)
                {
                    Console.Write("{0} ",j);
                }
                Console.WriteLine();
            }
        }
    }
}
