// 6. Write a program in C# Sharp to display the multiplication table of a given integer. Go to the editor
// Test Data :
// Input the number (Table to be calculated) : 15
// Expected Output :
// 15 X 1 = 15
// ...
// ...
// 15 X 10 = 150

using System;

namespace ntable
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int i, n;
            Console.Write("\nDisplay The Multiplication Table Of A Given Integer\n");
            Console.Write("------------------------------------------------------\n");
            Console.Write("Test Data :\n");
            Console.Write("Input the number (Table to be calculated) : ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n\n");

            for (i = 1; i <= 10; i++)
            {
                Console.WriteLine("{0} X {1} = {2}", n, i, (n * i));
            }

        }
    }
}
