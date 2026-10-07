using System;
using System.Collections.Generic;
using System.Text;

namespace WelcomeApp
{
    internal class ArraySum
    {
        static void Main()
        {
            int[] a = new int[10];
            int i, sum=0;
            for(i = 0; i < a.Length; i++)
            {
                Console.WriteLine($"Enter {i + 1} element of array:");
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Array elements are:");
            for(i = 0; i < a.Length; i++)
            {
                Console.WriteLine($"{a[i]}");
                sum += a[i];
            }
            Console.WriteLine($"Sum of array elements is: {sum}");

        }
    }
}

/*
 enter 10 elemtns in array and print it in reverse order
 enter 10 elemtns in array and print biggest element
 enter 10 elemtns in array and print smallest element
 enter 10 elemtns in array and print average of elements
 enter 10 elemtns in array and print only even nos
 enter 10 elements in array and  print array after sorting in ascending order

 
 */