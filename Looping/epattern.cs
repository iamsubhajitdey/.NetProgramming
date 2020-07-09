// 62. Write a C#Sharp program to display alphabet pattern like E with an asterisk. Go to the editor

// Display the pattern like 'E' with an asterisk:                                      
// ---------------------------------------------                                    

//  *****                                                                           
//  *                                                                               
//  *                                                                               
//  ****                                                                            
//  *                                                                               
//  *                                                                               
//  *****     

using System;

namespace epattern
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int row, column;

            Console.Write("\n\n");
            Console.Write("Display alphabet pattern like E with an asterisk\n");
            Console.Write("------------------------------------------------\n");

            Console.Write("Display the pattern like 'E' with an asterisk:\n");
            Console.Write("----------------------------------------------\n\n");

            for (row = 0; row <= 6; row++)
            {
                for (column = 0; column <= 6; column++)
                {
                    if (column == 1 || ((row == 0 || row == 6) && (column > 1 && column < 6)) || (row == 3 && column > 1 && column < 5))
                        Console.Write("*");

                    else
                        Console.Write(" ");
                }
                Console.Write("\n");
            }
        }
    }
}
