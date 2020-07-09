// 1. Write a program in C# Sharp to store elements in an array and print it. Go to the editor
// Test Data:
// Input 10 elements in the array:
// element - 0 : 1
// element - 1 : 1
// element - 2 : 2
// .......
// Expected Output :
// Elements in array are: 1 1 2 3 4 5 6 7 8 9

using System;
public class storeandprintinarray
{
    public static void Main()
    {
        int[] arr = new int[10];
        int i;
        Console.Write("\nRead and Print elements of an array:\n");

        Console.Write("Input 10 elements in the array :\n");
        for (i = 0; i < 10; i++)
        {
            Console.Write("element - {0} : ", i);
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }

        Console.Write("\nElements in array are: ");
        for (i = 0; i < 10; i++)
        {
            Console.Write("{0}  ", arr[i]);
        }
        Console.Write("\n");
    }
}