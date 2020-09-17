/*
 * 1- 
 * Write a program to count how many numbers between 1 and 100 
 * are divisible by 3 with no remainder. 
 * Display the count on the console.
 */
using System;

namespace ProgramOnedotOne
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            for( int i =1;i<=100;i++)
            {
                if(i%3==0)
                {
                    count++;
                }
            }
            Console.WriteLine("Count: " + count);
        }
    }
}
