// Implementing Queue in C#
// Queue is a linear data structure. It follows FIFO (First In First Out) pattern for Input/output.
// Following four basic operations are performed in the queue:
// 1.Enqueue: Adds an item in the queue. If the queue is full, then it is said to be a queue Overflow condition.
// 2.Dequeue: Removes an item from the queue. The items are popped in the same order in which they are pushed. If the queue is empty, then it is said to be a queue Underflow condition.
// 3.Peek: Return the first element of queue without removing it.
// 4.Count: Return the total number of elements in the queue.
// Study in-depth about queue data structure and operations using resources available online, and then implement queue and it's 4 basic operations listed above using arrays in C#.


using System;
using System.Collections;

namespace implementingqueue
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int i;
            Console.Write("\n=> Please Enter The Number To Display In The Queue: ");
            Queue q = new Queue();
            string numbers = Console.ReadLine();
            char[] sprtr = { ' ' };
            string[] arr = numbers.Split(sprtr, 5);


            for (i = 0; i < arr.Length; i++)
            {
                q.Enqueue(Convert.ToInt32(arr[i]));
            }
            Console.WriteLine();
            Console.Write("=> Queue Elements Are: ");
            foreach (int x in q)
            {
                Console.Write(x + " ");
            }
            q.Dequeue();
            Console.Write("\n\n=> Queue After Dequeue() Operation: ");
            foreach (int x in q)
            {
                Console.Write(x + " ");
            }
            Console.WriteLine();
            Console.WriteLine("\n=> Element At The Beginning Of The Queue Is: {0}", q.Peek());
            Console.Write("\n=> Count = {0} \n", q.Count);
            Console.ReadKey();
        }
    }
}

