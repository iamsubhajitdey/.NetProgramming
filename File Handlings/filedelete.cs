// 2. Write a program in C# Sharp to remove a file from the disk.
// Expected Output :

//  Remove a file from the disk (at first create the file ) :                                                    
// --------------------------------------------------------------                                                
//  The file mytest.txt deleted successfully.

//   Remove a file from the disk (at first create the file ) :                                                    
// --------------------------------------------------------------                                                
//  File does not exist 

using System;
using System.IO;
using System.Text;


namespace filedelete
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string FileName = @"mytest.txt";
            try
            {

                using (FileStream filestr = File.Create(FileName))
                {
                    Console.Write("\n\nCreate a file named mytest.txt in the disk :\n");
                    Console.Write("--------------------------------------------\n");
                    Console.WriteLine("A file created with name mytest.txt\n\n");
                }
            }

            catch (Exception MyExcep)
            {
                Console.WriteLine(MyExcep.ToString());
            }

            Console.Write("Remove a file from the disk :\n");
            Console.WriteLine("-----------------------------");

            if (File.Exists(FileName))
            {
                File.Delete(FileName);
                Console.WriteLine("The file {0} deleted successfully.\n", FileName);
            }
            else
            {
                Console.WriteLine("File does not exist");
                Console.ReadKey();
            }
        }
    }
}
