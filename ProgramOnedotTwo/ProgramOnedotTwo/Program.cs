/*
 * 2 - Write a program and continuously ask the user to enter a number or "ok" to exit. 
 * Calculate the sum of all the previously entered numbers and display it on the console.
 */ 


using System;
using System.Dynamic;

namespace ProgramOnedotTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            string str = "0";
            do
            {
                int num = Convert.ToInt32(str);
                sum += num;
                Console.WriteLine("Sum: " + sum);
                Console.Write("Enter a number or \"ok\" to exit:");
                str = Console.ReadLine();
            } while (str != "ok" || str != "OK" || str != "Ok");
            
        }
    }
}
