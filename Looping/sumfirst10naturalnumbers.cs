// 2. Write a C# Sharp program to find the sum of first 10 natural numbers. Go to the editor
// Expected Output :
// The first 10 natural number is :
// 1 2 3 4 5 6 7 8 9 10
// The Sum is : 55

using System;

namespace sumfirst10naturalnumbers
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int i;
            int sum = 0;
            Console.WriteLine("\nThe First 10 Natural Number is :");

            for (i = 1; i <= 10; i++)
            {
               Console.Write("{0}",i);
               sum = sum + i;
            }  
              Console.WriteLine("\n\nThe Sum is : {0}\n", sum);
              
            
        }
    }
}
