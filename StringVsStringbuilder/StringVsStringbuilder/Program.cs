using System;
using System.Text;

namespace StringVsStringbuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            //String is immutable
            string str = "Hello";
            str = str + " World";
            Console.WriteLine(str);
            //There are two copies: Hello, Hello world

            //Stringbuilder is mutable with 16 byte space
            StringBuilder stb = new StringBuilder("Hello");
            stb.Append(" World");
            Console.WriteLine(stb);
            //There is only one copy: Hello World
        }
    }
}
