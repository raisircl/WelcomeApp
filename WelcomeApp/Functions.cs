using System;
using System.Collections.Generic;
using System.Text;

namespace WelcomeApp
{
    internal class Functions
    {
        static void Main() // called function
        {
            int num = 5;
            double r, a;
            msg(); // calling 
            table(6);
            int x = fact(num);
            Console.WriteLine($"Factorial of {num} is {x}");
            r = 7;
            a = getpi() * r * r;
            Console.WriteLine($"Area of Cirlce is {a}");

        }
        static void msg() // msg is a calling function that does not return (void) and does not accept 
        {
            Console.WriteLine("Welcome to Message");
        }
        static void table(int num) // table is a function what does not return (void) but accept an int data
        {
            int i;
            for(i=1;i<=10;i++)
            {
                Console.WriteLine($"{num}x{i}={num*i}");
            }
        }
        static int fact(int num)
        {
            int i, f = 1;
            for(i=1;i<=num;i++)
            {
                f = f * i;
            }
            return f;
        }
        static double getpi()
        {
            return 3.147;
        }
    }
}
