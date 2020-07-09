// 11. Write a program in C# Sharp to create a recursive function to find the factorial of a given number.
// Test Data :
// Enter a number: 5
// Expected Output :
// The factorial of 5! is 120

using System;

namespace recursive
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("\n\n");
            Console.WriteLine("Recursive Function-Find the factorial of a given number");
            Console.WriteLine("-------------------------------------------------------");
            Console.Write("\n");
            Console.Write("Enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n");
            long fac = Factorial(num);
            Console.WriteLine("The factorial of {0} : {1}", num, fac);
        }
        public static long Factorial(int n)
        {
            if (n == 0)
            {
                return 1;
            }
            else
            {
                return n * Factorial(n - 1);
            }
        }
    }
}
