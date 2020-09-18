/*
 * 4- Write a program and ask the user to continuously enter a number or type "Quit" to exit. 
 * The list of numbers may include duplicates. 
 * Display the unique numbers that the user has entered.
 */
using System;
using System.Collections.Generic;
using System.Transactions;

namespace ProgramTwodotFour
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<int> { };
            while(true)
            {
                Console.WriteLine("Enter a number: ");
                var str = Console.ReadLine();
                if (str.ToLower() == "quit")
                {
                    break;
                }
                else
                {
                    var num = Convert.ToInt32(str);
                    if(!list.Contains(num))
                    {
                        list.Add(num);
                    }
                }
            }
            Console.WriteLine("Unique numbers are :");
            foreach(var num in list)
            {
                Console.Write(num + " ");
            }
        }
    }
}
