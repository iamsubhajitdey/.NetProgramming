//3. Write a C# Sharp program to sort a list of elements using Bubble sort. Go to the editor
//According to Wikipedia "Bubble sort, sometimes referred to as sinking sort, is a simple sorting 
//algorithm that repeatedly steps through the list to be sorted, compares each pair of adjacent items
//and swaps them if they are in the wrong order. The pass through the list is repeated until no swaps 
//are needed, which indicates that the list is sorted. The algorithm, which is a comparison sort, is 
//named for the way smaller elements "bubble" to the top of the list. Although the algorithm is simple, 
//it is too slow and impractical for most problems even when compared to insertion sort. It can be practical 
//if the input is usually in sort order but may occasionally have some out-of-order elements nearly in position."

using System;

namespace bubblesort
{
    public class Program
    {
        public static void Main(string[] args)
        {


            int i, temp;
            int[] num = new int[5];

            Console.WriteLine("Original Array :");
            Console.Write("----------------\n");
            string numbers = Console.ReadLine();
            char[] sprtr = { ' ' };
            string[] arr = numbers.Split(sprtr, 5);


            for (i = 0; i < arr.Length; i++)
            {
                num[i] = Convert.ToInt32(arr[i]);
            }

            for (int write = 0; write <= num.Length - 2; write++)
            {
                for (int sort = 0; sort <= num.Length - 2; sort++)
                {
                    if (num[sort] > num[sort + 1])
                    {
                        temp = num[sort + 1];
                        num[sort + 1] = num[sort];
                        num[sort] = temp;
                    }
                }
            }

            Console.WriteLine("\nSorted Array :");
            Console.Write("--------------\n");
            foreach (int aa in num)
                Console.Write(aa + " ");
            Console.Write("\n");

        }
    }
}