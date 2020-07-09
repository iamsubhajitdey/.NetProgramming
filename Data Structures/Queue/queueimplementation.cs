// Implementing Queue in C#
// Queue is a linear data structure. It follows FIFO (First In First Out) pattern for Input/output.
// Following four basic operations are performed in the queue:
// 1.Enqueue: Adds an item in the queue. If the queue is full, then it is said to be a queue Overflow condition.
// 2.Dequeue: Removes an item from the queue. The items are popped in the same order in which they are pushed. If the queue is empty, then it is said to be a queue Underflow condition.
// 3.Peek: Return the first element of queue without removing it.
// 4.Count: Return the total number of elements in the queue.
// Study in-depth about queue data structure and operations using resources available online, and then implement queue and it's 4 basic operations listed above using arrays in C#.

using System;

namespace queueimplementation
{
    public class Queue
    {
        public int front, rear, capacity, count;
        public int[] queue;

        public Queue (int c)
        {
            front = rear = count = 0;
            capacity = c;
            queue = new int[capacity];
        }

        public void Enqueue (int data)
        {

            if (capacity == rear)
            {
                Console.Write ("\nQueue is full\n");
                return;
            }

            else
            {
                queue[rear] = data;
                rear++;
                count += 1;
            }
            return;
        }

        public void Dequeue ()
        {
            if (front == rear)
            {
                Console.Write ("\nQueue is empty\n");
                return;
            }

            else
            {
                for (int i = 0; i < rear - 1; i++)
                {
                    queue[i] = queue[i + 1];
                }

                if (rear < capacity)
                    queue[rear] = 0;
                rear--;
                count -= 1;
            }
            return;
        }

        public void Display ()
        {
            int i;
            if (front == rear)
            {
                Console.Write ("\nQueue is Empty\n");
                return;
            }

            for (i = front; i < rear; i++)
            {
                Console.Write ("{0} ", queue[i]);
            }
            return;
        }

        public void Front ()
        {
            if (front == rear)
            {
                Console.Write ("\nQueue is Empty\n");
                return;
            }
            Console.WriteLine ("\n\n=> Element At The Beginning Of The Queue Is: {0}", queue[front]);
            return;
        }
        public int Size ()
        {

            if (front == rear)
            {
                Console.Write ("\nQueue is Empty\n");
                return 0;
            }

            return (rear - front);

        }

        public class program
        {

            public static void Main (String[] args)
            {
                int i;
                Console.Write ("\n\n=> Please Enter The Number To Display In The Queue: ");
                Queue q = new Queue (6);

                string numbers = Console.ReadLine ();
                char[] sprtr = { ' ' };
                string[] arr = numbers.Split (sprtr, 6);

                for (i = 0; i < arr.Length; i++)
                {
                    q.Enqueue (Convert.ToInt32 (arr[i]));
                }
                Console.Write ("\n=> Queue Elements Are: ");
                q.Display ();

                q.Dequeue ();
                Console.Write ("\n\n=> Queue After Dequeue() Operation: ");
                q.Display ();

                q.Front ();

                Console.WriteLine ("\n=> Count = {0}", q.Size ());

                Console.WriteLine ("\n=> Count = {0}", q.count);

            }
        }
    }
}