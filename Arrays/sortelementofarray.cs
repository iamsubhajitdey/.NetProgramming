// 11. Write a program in C# Sharp to sort elements of array in ascending order.
// Test Data :
// Input the size of array : 5
// Input 5 elements in the array :
// element - 0 : 2
// element - 1 : 7
// element - 2 : 4
// element - 3 : 5
// element - 4 : 9
// Expected Output :
// Elements of array in sorted ascending order:
// 2 4 5 7 9

using System;

namespace sortelementofarray 
{
    public class Program 
    {
        public static void Main (string[] args) 
        {
            int[] arr = new int[100];
            int i, n, j, temp;

            Console.Write ("\n\n");

            Console.Write ("Sort Elements Of Array In Ascending Order\n");
            Console.Write ("-----------------------------------------\n\n");

            Console.Write ("Input the size of array : ");
            n = Convert.ToInt32 (Console.ReadLine ());

            Console.WriteLine ("Input {0} elements in the array :", n);

            for (i = 0; i < n; i++) {
                Console.Write ("element - {0} : ", i);
                arr[i] = Convert.ToInt32 (Console.ReadLine ());
            }
            for (i = 0; i < n; i++) {
                for (j = i + 1; j < n; j++) {
                    if (arr[j] < arr[i]) {
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }

            Console.Write ("Elements of array in sorted ascending order:\n");
            for (i = 0; i < n; i++) {
                Console.Write ("{0}  ", arr[i]);
            }

            Console.Write ("\n\n");

        }
    }
}