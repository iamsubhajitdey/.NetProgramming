// 10. Write a program in C# Sharp to create a function to calculate the sum of the individual digits of a given number. Go to the editor
// Test Data :
// Enter a number: 1234
// Expected Output :
// The sum of the digits of the number 1234 is : 10

using System;

namespace sum
{
    public class Program
    {
        public static int cal(int n)
        {
            string x = Convert.ToString(n);
            int sum = 0;
            for (int i = 0; i < x.Length; i++)
                sum = sum + Convert.ToInt32(x.Substring(i,1)); 
            return sum;
        }

        public static void Main()
        {
            int num;
            Console.Write("Function To calculate the sum of the individual digits of a number :\n");
            Console.Write("----------------------------------------------------------------------\n");
            Console.Write("Enter a number: ");
            num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The sum of the digits of the number {0} is : {1} \n", num, cal(num));
        }
    }
}  