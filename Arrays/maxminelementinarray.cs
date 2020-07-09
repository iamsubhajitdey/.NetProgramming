// 9. Write a program in C# Sharp to find maximum and minimum element in an array. Go to the editor
// Test Data :
// Input the number of elements to be stored in the array :3
// Input 3 elements in the array :
// element - 0 : 45
// element - 1 : 25
// element - 2 : 21
// Expected Output :
// Maximum element is : 45
// Minimum element is : 21

using System;

namespace maxminelementinarray
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] arr = new int[100];
            int i, max_ele, min_ele, n;
            Console.Write("\nDisplay Maximum And Minimum Element In An Array\n");
            Console.WriteLine("-----------------------------------------------\n");
            Console.WriteLine("Test Data :\n");
            Console.Write("Input the number of elements to be stored in the array : ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n");
            Console.Write("Input {0} elements in the array : \n", n);
            Console.WriteLine("-----------------------------\n");

            for (i = 0; i < n; i++)
            {
                Console.Write("element - {0} : ", i);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            max_ele = arr[0];
            min_ele = arr[0];

            for (i = 1; i < n; i++)
            {
                if (arr[i] > max_ele)
                {
                    max_ele = arr[i];
                }

                if (arr[i] < min_ele)
                {
                    min_ele = arr[i];
                }
            }
            Console.Write("\nMaximum element is : {0}\n", max_ele);
            Console.WriteLine("Minimum element is : {0}\n", min_ele);
        }
    }
}
