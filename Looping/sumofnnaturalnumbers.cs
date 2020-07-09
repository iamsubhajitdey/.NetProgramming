// 3. Write a program in C# Sharp to display n terms of natural number and their sum.Go to the editor
// Test Data : 7
// Expected Output :
// The first 7 natural number is :
// 1 2 3 4 5 6 7
// The Sum of Natural Number upto 7 terms : 28

using System;

namespace sumofnnaturalnumbers
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int i, n;
            int sum = 0;
            Console.Write("\nTest Data : ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nThe first {0} natural number is :",n);


            for (i = 1; i <= n; i++)
            {
                Console.Write("{0}", i);
                sum = sum + i;
            }
            Console.WriteLine("\n\nThe Sum of Natural Number upto {0} terms : {1}\n", n,sum);


        }
    }
}
