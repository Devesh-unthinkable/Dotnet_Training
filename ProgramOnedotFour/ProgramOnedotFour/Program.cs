/*
 * 4- Write a program that picks a random number between 1 and 10. 
 * Give the user 4 chances to guess the number. If the user guesses the number, 
 * display “You won"; otherwise, display “You lost". 
 * (To make sure the program is behaving correctly, 
 * you can display the secret number on the console first.)
 */
using System;

namespace ProgramOnedotFour
{
    class Program
    {
        static void Main(string[] args)
        {
            var rand = new Random();
            int num = rand.Next(1, 10),guess = -1;
            Console.WriteLine(num);
            for (int i = 1; i <= 4; i++)
            {
                Console.Write("Enter your guess: ");
                guess = Convert.ToInt32(Console.ReadLine());
                if(guess == num)
                {
                    Console.WriteLine("You Won");
                    break;
                }
                else if(i == 4)
                {
                    Console.WriteLine("You Lost");
                }
            }
        }
    }
}
