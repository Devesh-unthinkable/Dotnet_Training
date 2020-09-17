/*
 * 5- Write a program and ask the user to enter a series of numbers separated by comma. 
 * Find the maximum of the numbers and display it on the console. 
 * For example, if the user enters “5, 3, 8, 1, 4", the program should display 8.
 */
using System;

namespace ProgramOnedotFive
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a series of number separated by comma: ");
            string str = Console.ReadLine();
            var strList = str.Split(",");
            int sum = 0;
            foreach(var num in strList)
            {
                sum += Convert.ToInt32(num);
            }
            Console.WriteLine("Sum of series: " + sum);
        }
    }
}
