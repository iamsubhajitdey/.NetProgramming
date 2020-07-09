// 16. Write a program in C# Sharp to display the n terms of even natural number and their sum. Go to the editor
// Test Data :
// Input number of terms : 5
// Expected Output :
// The even numbers are :2 4 6 8 10
// The Sum of even Natural Number upto 5 terms : 30

using System;

namespace sumofnthevennaturalnumber
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int i, n, sum = 0;
            Console.Write("\n\n");
            Console.Write("Display the n terms of even natural number and their sum\n");
            Console.Write("--------------------------------------------------------\n\n");
            Console.Write("Input number of terms : ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nThe even numbers are : ");

            for (i = 1; i <= n; i++)
            {
                Console.Write("{0} ", (2 * i));
                sum = sum + (2 * i);
            }
            Console.Write("\nThe Sum of even Natural Number upto {0} terms : {1} \n", n, sum);
        }
    }
}
