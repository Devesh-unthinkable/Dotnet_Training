/*
 * 1- When you post a message on Facebook, 
 * depending on the number of people who like your post, 
 * Facebook displays different information.

If no one likes your post, it doesn't display anything.
If only one person likes your post, it displays: [Friend's Name] likes your post.
If two people like your post, it displays: [Friend 1] and [Friend 2] like your post.
If more than two people like your post, it displays: [Friend 1], [Friend 2] and [Number of Other People] others like your post.
Write a program and continuously ask the user to enter different names, 
until the user presses Enter (without supplying a name). 
Depending on the number of names provided, display a message based on the above pattern.


 */
using System;
using System.Collections.Generic;

namespace ProgramTwodotOne
{
    class Program
    {
        static void Main(string[] args)
        {
            var strList = new List<string> { };
            var i = 0;
            while(true)
            {
                Console.WriteLine("Enter name: ");
                var str = Console.ReadLine();
                if (String.IsNullOrEmpty(str))
                {
                    break;
                }
                else
                {
                    i++;
                    strList.Add(str);
                }
            }
            if (i == 1)
            {
                Console.WriteLine(strList[0] + " Likes your post");
            }
            else if (i == 2)
            {
                Console.WriteLine(strList[0] + " and " + strList[1] + " Likes your post");
            }
            else if (i > 2)
            {
                Console.WriteLine(strList[0] + ", " + strList[1] + " and others Likes your post");
            }
        }
    }
}
