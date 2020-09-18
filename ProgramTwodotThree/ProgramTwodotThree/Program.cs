/*
 * 3- Write a program and ask the user to enter 5 numbers. 
 * If a number has been previously entered, display an error message and ask the user to re-try. 
 * Once the user successfully enters 5 unique numbers, 
 * sort them and display the result on the console.
 */
using System;
using System.Globalization;

namespace ProgramTwodotThree
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = new int[5];
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Enter the number: ");
                array[i] = Convert.ToInt32(Console.ReadLine());
                int j = i - 1;
                while (j >= 0)
                {
                    if (array[j] == array[i])
                    {
                        Console.WriteLine("###Error try again###");
                        j = 0;
                        i--;
                        break;
                    }
                    j--;
                }
            }
            Array.Sort(array);
            Console.WriteLine("Sorted Array: ");
            for (int i = 0; i < 5; i++)
            {
                Console.Write(array[i] + " ");
            }
        }

    }
}
