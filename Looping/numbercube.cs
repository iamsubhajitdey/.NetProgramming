// 5. Write a program in C# Sharp to display the cube of the number upto given an integer. Go to the editor
// Test Data :
// Input number of terms : 5
// Expected Output :
// Number is : 1 and cube of the 1 is :1
// Number is : 2 and cube of the 2 is :8
// Number is : 3 and cube of the 3 is :27
// Number is : 4 and cube of the 4 is :64
// Number is : 5 and cube of the 5 is :125

using System;

namespace numbercube
{
    public class program
    {
        public static void Main(string[] args)
        {
            int num;
            Console.WriteLine(":: Display The Cube of The Number ::");
            Console.WriteLine("-----------------------------------\n");
            Console.Write("Input number of terms : ");
            num = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= num; i++)
            {
                int cube = i * i * i;

                Console.WriteLine("Number is : {0} and cube of the {1} is :{2}", i, i, cube);

            }

        }
    }
}
