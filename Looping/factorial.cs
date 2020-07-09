// 15. Write a C# Sharp program to calculate the factorial of a given number. Go to the editor
// Test Data :
// Input the number : 5
// Expected Output :
// The Factorial of 5 is: 120

using System;

namespace factorial
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int i, n, fac = 1;
            Console.Write("\n\n");
            Console.Write("Calculate The Factorial Of A Given Number\n");
            Console.Write("-----------------------------------------\n\n");
            Console.Write("Input the number : ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n");

            for (i = n; i >= 1; i--)
            {
                fac = fac * i;
            }
            Console.Write("The Factorial of {0} is: {1}",n,fac);
            Console.Write("\n\n");
        }
    }
}
