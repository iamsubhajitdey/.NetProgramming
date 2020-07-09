// 22. Write a program in C# Sharp to read any Month Number in integer and display Month name in the word. Go to the editor
// Test Data :
// 4
// Expected Output:
// April

using System;

namespace monthnumber
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string mnths;
            int monno;


            Console.Write("\n\n");
            Console.Write("Read month number and display month name:\n");
            Console.Write("-----------------------------------------");
            Console.Write("\n\n");


            Console.Write("Input Month No : ");
            monno = Convert.ToInt32(Console.ReadLine());

            switch (monno)
            {
                case 1:
                    mnths= "January";
                    break;
                case 2:
                    mnths= "February";
                    break;
                case 3:
                    mnths= "March";
                    break;
                case 4:
                    mnths= "April";
                    break;
                case 5:
                    mnths= "May";
                    break;
                case 6:
                    mnths= "June";
                    break;
                case 7:
                    mnths= "July";
                    break;
                case 8:
                    mnths= "August";
                    break;
                case 9:
                    mnths= "September";
                    break;
                case 10:
                    mnths= "October";
                    break;
                case 11:
                    mnths= "November";
                    break;
                case 12:
                    mnths= "December";
                    break;
                default:
                    mnths= "Invalid Month Number. \nPlease Try Again ....";
                    break;
            }
            Console.Write("{0}\n", mnths);
        }
    }
}