// 25. Write a program in C# Sharp to display the n terms of square natural number and their sum. Go to the editor
// 1 4 9 16 ... n Terms
// Test Data :
// Input the number of terms : 5
// Expected Output :
// The square natural upto 5 terms are :1 4 9 16 25
// The Sum of Square Natural Number upto 5 terms = 55

using System;

namespace sumofnthsquarenaturalnumber
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int i, n, sum = 0;
            Console.Write("\n:: Display the n terms of square natural number and their sum ::\n");
            Console.Write("----------------------------------------------------------------\n\n");
            Console.Write("Input the number of terms : ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n\n");
            Console.WriteLine("Expected Output : ");
            Console.Write("The square natural upto {0} terms are : ", n);

            for (i = 1; i <= n; i++)
            {
                Console.Write("{0} ", (i * i));
                sum += (i * i);
            }
            Console.Write("\nThe Sum of Square Natural Number upto {0} terms = {1}", n, sum);
            Console.Write("\n\n");
        }
    }
}
