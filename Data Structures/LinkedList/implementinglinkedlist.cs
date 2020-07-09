// Implementing LinkedList in C#
// A LinkedList is a linear data structure which stores element in the non-contiguous location. The elements in a linked list are linked with each other using pointers. Or in other words, LinkedList consists of nodes where each node contains a data field and a reference(link) to the next node in the list.
// Following basic operations are performed in the Linked list:
// 1. Clear(): This method is used to remove all nodes from the LinkedList.
// 2. Remove(LinkedListNode): This method is used to remove the specified node from the LinkedList.
// 3. Remove(T): This method is used to remove the first occurrence of the specified value from the LinkedList.
// 4. RemoveFirst(): This method is used to remove the node at the start of the LinkedList.
// 5. RemoveLast(): This method is used to remove the node at the end of the LinkedList.
// Study in-depth about Linked list data structure and operations using resources available online, and then implement Linked list and its basic operations listed above using classes and objects in C#.

using System;
using System.Collections.Generic;

namespace implementinglinkedlist
{
    public class Program
    {
        public static void Main (string[] args)

        {
            int j;
            Console.WriteLine ();
            Console.Write ("\n=> Please Enter The Number To Display In The Queue: ");
            LinkedList<int> L = new LinkedList<int> ();
            string numbers = Console.ReadLine ();
            char[] sprtr = { ' ' };
            string[] arr = numbers.Split (sprtr, 6);

            for (j = 0; j < arr.Length; j++)
            {
                L.AddLast (Convert.ToInt32 (arr[j]));
            }
            Console.Write ("\n=> Original Linked List: ");
            foreach (int i in L)
            {
                Console.Write (i + " ");
            }
            L.RemoveFirst ();
            L.RemoveLast ();
            Console.WriteLine ();
            Console.Write ("\n=> Linked List after deletion: ");
            foreach (int i in L)
            {
                Console.Write (i + " ");
            }
            Console.WriteLine ();
            Console.Write ("\n=> Linked List after using Remove(LinkedListNode): ");

            L.Remove (L.First);

            foreach (int i in L)
            {
                Console.Write (i + " ");
            }
            Console.WriteLine ();
            Console.Write ("\n=> Linked List after using Remove(T): ");

            L.Remove (L.Last);

            foreach (int i in L)

            {
                Console.Write (i + " ");
            }
            L.Clear ();
            Console.WriteLine ();
            Console.Write ("\n=> Linked List Cleared...");
            Console.Write ("\n\n");
        }
    }
}