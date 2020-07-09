// 2. Write a program in C# Sharp to read n number of values in an array and display it in reverse order. Go to the editor
// Test Data :
// Input the number of elements to store in the array :3
// Input 3 number of elements in the array :
// element - 0 : 2
// element - 1 : 5
// element - 2 : 7
// Expected Output:
// The values store into the array are:
// 2 5 7
// The values store into the array in reverse are :
// 7 5 2

using System;

namespace elimentinarray
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] arr = new int[100];
            int i, n;

            Console.Write("\n\n");


            Console.Write("Read n number of values in an array and display it in reverse order\n");
            Console.Write("-------------------------------------------------------------------\n\n");


            Console.Write("Input the elements to store in the array : ");
            n = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nInput {0} number of elements in the array :\n", n);
            for (i = 0; i < n; i++)
            {
                Console.Write("element - {0} : ", i);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("\nThe values store into the array are:\n");
            for (i = 0; i < n; i++)
            {
                Console.Write("{0} ", arr[i]);
            }

            Console.Write("\nThe values store into the array in reverse are :\n");
            for (i = (n - 1); i >= 0; i--)
            {
                Console.Write("{0} ", arr[i]);
            }
            Console.Write("\n\n");
        }
    }
}
