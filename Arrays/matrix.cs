// 25. Write a program in C# Sharp to find sum of rows an columns of a Matrix
// Test Data :
// Input the size of the square matrix: 2
// Input elements in the first matrix:
// element - [0],[0] : 5
// element - [0],[1] : 6
// element - [1],[0] : 7
// element - [1],[1] : 8
// Expected Output :
// The First matrix is :
// The matrix is :
// 5 6
// 7 8
// The sum or rows and columns of the matrix is :
// 5 6 11
// 7 8 15

// 12 14

using System;

namespace matrix
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int i, j, n;
            int[,] arr = new int[10, 10];
            int[] rsum = new int[10];
            int[] csum = new int[10];

            Console.Write("\n\n");
            Console.Write("Find sum of row an column of a Matrix:\n ");
            Console.Write("--------------------------------------\n");


            Console.Write("Input the size of the square matrix : ");
            n = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nInput elements in the matrix :\n");
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < n; j++)
                {
                    Console.Write("element - [{0}],[{1}] : ", i, j);
                    arr[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.Write("\nThe matrix is :\n");
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < n; j++)
                    Console.Write("{0}  ", arr[i, j]);
                Console.Write("\n");
            }

            /* :: sum of rows :: */
            for (i = 0; i < n; i++)
            {
                rsum[i] = 0;
                for (j = 0; j < n; j++)
                    rsum[i] += arr[i, j];
            }

            /* :: sum of column ::*/
            for (i = 0; i < n; i++)
            {
                csum[i] = 0;
                for (j = 0; j < n; j++)
                    csum[i] += arr[j, i];
            }

            Console.Write("\nThe sum or rows and columns of the matrix is :\n");
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < n; j++)
                    Console.Write("{0}    ", arr[i, j]);
                Console.Write("{0}    ", rsum[i]);
                Console.Write("\n");
            }
            Console.Write("\n");
            for (j = 0; j < n; j++)
            {
                Console.Write("{0}   ", csum[j]);
            }
            Console.Write("\n\n");
        }
    }
}

