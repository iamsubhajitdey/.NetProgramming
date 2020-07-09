// 22. Write a program in C# Sharp to find the strings for a specific minimum length. Go to the editor
// Test Data :
// Input number of strings to store in the array :4
// Input 4 strings for the array:
// Element[0] : this
// Element[1] : is
// Element[2] : a
// Element[3] : string
// Input the minimum length of the item you want to find : 5
// Expected Output:
// The items of minimum 5 characters are :
// Item: string

using System;
using System.Collections.Generic;  
using System.Linq;

namespace stringforspecificminlength
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string[] arr;
            int n, i, ctr;

            Console.Write("\n\n");
            Console.Write("----------------------------------------------\n");
            Console.Write("Find the strings for a specific minimum length\n");
            Console.Write("----------------------------------------------\n\n");

            Console.Write("Input number of strings to store in the array : ");
            n = Convert.ToInt32(Console.ReadLine());
            arr = new string[n];
            Console.Write("\nInput {0} strings for the array:\n", n);
            Console.Write("------------------------------\n");

            for (i = 0; i < n; i++)
            {
                Console.Write("Element[{0}]: ", i);
                arr[i] = Console.ReadLine();
            }

            Console.Write("\nInput the minimum length of the item you want to find : ");
            ctr = Convert.ToInt32(Console.ReadLine());

            IEnumerable<string> objNew = from word in arr
                                         where word.Length >= ctr
                                         orderby word
                                         select word;
            Console.Write("\nThe items of minimum {0} characters are : \n", ctr);
            foreach (string str in objNew)
                Console.WriteLine("Item: {0}", str);

            Console.ReadLine();
        }
    }
}
