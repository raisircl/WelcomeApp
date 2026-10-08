using System;
using System.Collections.Generic;
using System.Text;

namespace WelcomeApp
{
    internal class Matrix
    {
        static void Main()
        {
            int[,] matrix = new int[3, 3];
            Console.WriteLine("Enter elements of the matrix:");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"Element [{i + 1},{j + 1}]: ");
                    matrix[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("The matrix is:");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
/*
 Transpose of a matrix
 print left diagonal elements of a matrix
print right diagonal elements of a matrix
print lower triangular matrix
print upper triangular matrix
print sum of all elements of a matrix
print product of 2 matrix

 
 */