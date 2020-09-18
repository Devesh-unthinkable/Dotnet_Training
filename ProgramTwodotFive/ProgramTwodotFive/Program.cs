/*
 * 5- Write a program and ask the user to supply a list of comma separated numbers 
 * (e.g 5, 1, 9, 2, 10). 
 * If the list is empty or includes less than 5 numbers, 
 * display "Invalid List" and ask the user to re-try; otherwise, 
 * display the 3 smallest numbers in the list.
 */
using System;
using System.Dynamic;
using System.Resources;
using System.Collections.Generic;

namespace ProgramTwodotFive
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                var numList = new List<int> { };
                Console.WriteLine("Enter the list of numbers :");
                var str = Console.ReadLine();
                var strList = str.Split(",");
                foreach (var s in strList)
                {
                    numList.Add(Convert.ToInt32(s));
                }
                if(numList.Count >= 5 )
                {
                    numList.Sort();
                    Console.WriteLine("3 smallest numbers are {0} {1} {2}", numList[0], numList[1], numList[2]);
                    break;
                }
                else
                {
                    Console.WriteLine("Try Again");
                }
            }
        }
    }
}
