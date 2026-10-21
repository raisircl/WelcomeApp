using System;
using System.Collections.Generic;
using System.Text;

namespace WelcomeApp
{
    internal class LearnString
    {
        static void Main()
        {
            string? fname, lname, fullname;
            string str1 = " Hello, World! John is Good Programmer. ";
            string str2 = "Welcome to C# programming.";
            Console.Write(str1);
            Console.WriteLine("enter your First Name:");
            fname = Console.ReadLine();
            Console.WriteLine("enter your Last Name:");
            lname = Console.ReadLine();
            fullname = $"{fname} {lname}";

            Console.WriteLine("Your full name is: " + fullname);
            Console.WriteLine("Your full name length is: " + fullname.Length);
            Console.WriteLine("Your full name in uppercase is: " + fullname.ToUpper());
            // Console.WriteLine("Your full name in lowercase is: " + fullname.ToLower());
            // Trim the full name to remove leading and trailing spaces
            Console.WriteLine("Your full name after trimming is: " + str1.Trim());
            //TrimStart to remove leading spaces
            Console.WriteLine("Your full name after trimming leading spaces is: " + str1.TrimStart());
            // TrinEnd to remove trailing spaces
            Console.WriteLine("Your full name after trimming trailing spaces is: " + str1.TrimEnd());
            //contains method to check if the full name contains a specific substring
            Console.WriteLine("Does your full name contain 'John'? " + str1.Contains("John"));
            //replace method to replace a specific substring with another substring
            Console.WriteLine("Your full name after replacing 'John' with 'Doe' is: " + str1.Replace("John", "Doe"));
            //startswith method to check if the full name starts with a specific substring
            Console.WriteLine("Does your full name start with 'Hello'? " + str1.StartsWith("Hello"));
            //EndsWith method to check if the full name ends with a specific substring
            Console.WriteLine("Does your full name end with 'programming.'? " + str2.EndsWith("programming."));
            //subtsring method to extract a specific substring from the full name
            Console.WriteLine("The substring of your full name from index 7 to 12 is: " + str1.Substring(7, 12));
            //IndexOf method to find the index of a specific substring in the full name
            Console.WriteLine("The index of 'World' in your full name is: " + str1.IndexOf("World"));
            //LastIndexOf method to find the last index of a specific substring in the full name
            Console.WriteLine("The last index of 'o' in your full name is: " + str1.LastIndexOf("o"));
            //Split method to split the full name into an array of substrings based on a specific delimiter
            string[] words = str1.Split(' ');
            Console.WriteLine("The words in your full name are:");
            foreach (string word in words)
            {
                Console.WriteLine(word);
            }
            //Insert method to insert a specific substring at a specific index in the full name
            Console.WriteLine("Your full name after inserting 'Mr. ' at the beginning is: " + str1.Insert(0, "Mr. "));
            //Remove method to remove a specific substring from the full name
            Console.WriteLine("Your full name after removing 'John' is: " + str1.Remove(str1.IndexOf("John"), 4));

            //StringBuilder class to create a mutable string
            StringBuilder sb = new StringBuilder("Hello, World!");
            sb.Append(" Welcome to C# programming.");
            Console.WriteLine("The string after appending is: " + sb.ToString());

        }
    }
}
/*
 Programming exercises

0 of 10 completed

[ ] Count vowels in a string
[ ] Reverse a string without using Reverse()
[ ] Check whether a string is a palindrome
[ ] Count words in a sentence
[ ] Find duplicate characters
[ ] Count uppercase and lowercase letters
[ ] Remove spaces from a string
[ ] Check whether an email contains @
[ ] Find the frequency of each character
[ ] Convert the first letter of every word to uppercase
 
 */