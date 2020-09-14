using System;
using System.Threading;

namespace threading
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Creating Threads
            Thread t1 = new Thread(Narine)
            {
                Name = "Thread1"
            };
            Thread t2 = new Thread(Banton)
            {
                Name = "Thread2"
            };
            Thread t3 = new Thread(Subha)
            {
                Name = "Thread3"
            };

            //Executing the methods
            t1.Start();
            Thread.Sleep(5000);
            t2.Start();
            Thread.Sleep(5000);
            t3.Start();
            Console.Read();
        }

        public static void Narine()
        {
            Console.WriteLine("Narine scores 1");

            //Sleep for 5 seconds
            Thread.Sleep(5000);

            Console.WriteLine("Narine scores 6");

            Console.WriteLine("Narine scores OUT");
        }

        public static void Banton()
        {
            Console.WriteLine("Banton scores 1");

            //Sleep for 5 seconds
            Thread.Sleep(5000);

            Thread.Sleep(5000);

            Console.WriteLine("Banton scores 4");
        }

        public static void Subha()
        {
            Console.WriteLine("Subha scores 1");
        }
    }
}