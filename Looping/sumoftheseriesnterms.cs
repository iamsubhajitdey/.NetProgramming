// 26. Write a program in C# Sharp to find the sum of the series 1 +11 + 111 + 1111 + .. n terms. Go to the editor
// Test Data :
// Input the number of terms : 5
// Expected Output :
// 1 + 11 + 111 + 1111 + 11111 +
// The Sum is : 12345

using System;

namespace sumoftheseriesnterms
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int i, n, sum = 0;
            int t = 1;
            Console.Write("\n\n");
            Console.Write(":: Find The Sum Of The Series 1 +11 + 111 + 1111 + .. n Terms ::\n");
            Console.Write("----------------------------------------------------------------\n");
            Console.Write("Input the number of terms : ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n\n");
            Console.Write("Expected Output :");

            for (i = 1; i <= n; i++)
            {
                Console.Write("{0} + ", t);
                t = (t * 10) + 1;
                sum = sum + t;
            }
            Console.Write("The Sum is : {0} ", sum);
        }
    }
}

