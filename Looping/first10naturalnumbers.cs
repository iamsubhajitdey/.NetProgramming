// 1. Write a program in C# Sharp to display the first 10 natural numbers. Go to the editor
// Expected Output :
// 1 2 3 4 5 6 7 8 9 10

using System;

namespace first10naturalnumbers
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int i;
            Console.WriteLine(":: Display The First 10 Natural Numbers ::");
            Console.WriteLine("------------------------------------------\n");
            Console.WriteLine("The First 10 Natural Number Are");
            Console.WriteLine("--------------------------------");

            for (i = 1; i <= 10; i++)
            {
                Console.Write("{0}", i);
            }
            Console.Write("\n\n");
        }
    }
}
