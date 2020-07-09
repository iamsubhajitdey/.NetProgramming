// 8. Write a program in C# Sharp to create a function to display the n number Fibonacci sequence. Go to the editor
// Test Data :
// Input number of Fibonacci Series : 5
// Expected Output :
// The Fibonacci series of 5 numbers is :
// 0 1 1 2 3

using System;

namespace fibonacciseries
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int i, n, val1, val2, val3;

            Console.Write("\n\n");
            Console.Write("Display the n number Fibonacci sequence\n");
            Console.Write("---------------------------------------\n\n");


            Console.Write("Input number of Fibonacci Series : ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n\n");
            
            Console.Write("Input the first value : ");
            val1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input the second value : ");
            val2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nThe Fibonacci series of {0} numbers is :\n", n);
            Console.Write("{0} {1}", val1, val2);

            for (i = 2; i < n; i++)
            {
                val3 = val1 + val2;
                Console.Write(" {0}", val3);
                val1 = val2;
                val2 = val3;
            }
        }
    }
}
