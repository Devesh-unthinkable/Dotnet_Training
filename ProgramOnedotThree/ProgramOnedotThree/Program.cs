/*
 * 3- Write a program and ask the user to enter a number. 
 * Compute the factorial of the number and print it on the console. 
 * For example, if the user enters 5, 
 * the program should calculate 5 x 4 x 3 x 2 x 1 and display it as 5! = 120.
 */
using System;

namespace ProgramOnedotThree
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            int n = num;
            int fact=1;
            while(num>0)
            {
                fact *= num;
                num--;
            }
            Console.WriteLine(n + "! = " + fact);
        }
    }
}
