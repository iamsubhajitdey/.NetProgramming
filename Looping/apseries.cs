// 49. Write a C# Sharp program to find out the sum of in A.P. series. Go to the editor
// Test Data :
// Input the starting number of the A.P. series: 1
// Input the number of items for the A.P. series: 10
// Input the common difference of A.P. series: 4
// Expected Output :
// The Sum of the A.P. series are :
// 1 + 5 + 9 + 13 + 17 + 21 + 25 + 29 + 33 + 37 = 190

using System;

namespace apseries
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int i, f, n, cd, last_number, sum = 0;

            Console.Write("\n\n");
            Console.Write("Find Out The Sum Of In A.P. Series\n");
            Console.Write("----------------------------------\n\n");

            Console.Write("Input the starting number of the A.P. series: ");
            f = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nInput the number of items for the A.P. series: ");
            n = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nInput the common difference of A.P. series: ");
            cd = Convert.ToInt32(Console.ReadLine());

            last_number = f + ((n - 1) * cd);
            sum = (n * (2 * f + (n - 1) * cd)) / 2;

            Console.Write("\nThe Sum of the A.P. series are :\n");

            for (i = f; i <= last_number; i = (i + cd))
            {
                if (i != last_number)
                    Console.Write("{0} + ", i);
                else
                    Console.Write("{0} = {1}\n\n", i, sum);
            }
        }
    }
}
