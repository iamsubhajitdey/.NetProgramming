// 1. Write a program in C# Sharp to create a blank file in the disk newly.
// Expected Output :
// A file created with name mytest.txt

using System;
using System.IO;
using System.Text;

namespace filehandling
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string FileName = @"mytest.txt";
            try
          {
            Console.Write("\n\n");
            Console.Write("Create a blank file mytest.txt in the disk :\n");
            Console.WriteLine("--------------------------------------------");

            using(FileStream filestr = File.Create(FileName))
            {
                Console.WriteLine("\nA file created with name mytest.txt\n\n");
            }
          }

        catch(Exception MyExcep)
          {
            Console.WriteLine(MyExcep.ToString());
          }
        }
    }
}