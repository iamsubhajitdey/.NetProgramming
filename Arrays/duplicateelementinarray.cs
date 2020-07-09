// 5. Write a program in C# Sharp to count a total number of duplicate elements in an array.
// Test Data :
// Input the number of elements to be stored in the array :3
// Input 3 elements in the array :
// element - 0 : 5
// element - 1 : 1
// element - 2 : 1
// Expected Output :
// Total number of duplicate elements found in the array is : 1

using System;

namespace duplicateelementinarray
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] arr1 = new int[100];
            int[] arr2 = new int[100];
            int[] arr3 = new int[100];
            int n, mm = 1, ctr = 0;
            int i, j;
            Console.Write("\n\nCount total number of duplicate elements in an array:\n");
            Console.Write("-----------------------------------------------------\n");

            Console.Write("\nInput the number of elements to be stored in the array :");
            n = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nInput {0} elements in the array :\n", n);
            Console.Write("----------------------------------\n");

            for (i = 0; i < n; i++)
            {
                Console.Write("element - {0} : ", i);
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }
            /*----------------- copy in other array ------------------------------------*/
            for (i = 0; i < n; i++)
            {
                arr2[i] = arr1[i];
                arr3[i] = 0;
            }
            /*------------------- mark the elements are duplicate -------------------------*/
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < n; j++)
                {
                    if (arr1[i] == arr2[j])
                    {
                        arr3[j] = mm;
                        mm++;
                    }
                }
                mm = 1;
            }
            /*--------------- Prints the array ------------------------------------*/
            for (i = 0; i < n; i++)
            {
                if (arr3[i] == 2) { ctr++; }
            }
            Console.Write("\nThe number of duplicate elements is: {0} \n", ctr);

            Console.Write("\n\n");
        }
    }
}