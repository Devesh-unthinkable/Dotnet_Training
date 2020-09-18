/*
 * 2- Write a program and ask the user to enter their name. 
 * Use an array to reverse the name and then store the result in a new string. 
 * Display the reversed name on the console.
 */
using System;

namespace ProgramTwodotTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name: ");
            var str = Console.ReadLine();
            var array = new char[str.Length];
            for(int i=0;i<str.Length;i++)
            {
                array[i] = str[str.Length - i - 1];
            }
            Console.WriteLine(array);
        }
    }
}
