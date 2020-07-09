//9. Write a program in C# Sharp to create a function to check whether a number is prime or not. Go to the editor
//Test Data :
//Input a number : 31
//Expected Output :
//31 is a prime number

using System;

namespace primenumber
{
    public class Program
    {
        public static bool checkprime(int num)
        {
            int i;
            for (i = 2; i < num; i++)
            {
                if (num % i == 0)
                    return false;
            }
            return true;
        }

        public static void Main(string[] args)
        {
            Console.Write("\n\n");
            Console.Write("Create a function to check whether a number is prime or not\n");
            Console.Write("-----------------------------------------------------------\n\n");
            Console.Write("Input a number : ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n");

            if (checkprime(n))
                Console.Write("{0} is a prime number\n", n);
            else
                Console.Write("{0} is not a prime number\n", n);

        }
    }
}