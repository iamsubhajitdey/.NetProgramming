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

namespace linkedlistimplementation
{
    public class LinkedList
    {
        public Node head;

        public class Node
        {
            public int data;
            public Node next;
            public Node(int d)
            {
                data = d;
                next = null;
            }
        }

        public void insert(LinkedList list, int data)
        {
            Node new_node = new Node(data);
            new_node.next = null;

            if (list.head == null)
            {
                list.head = new_node;
            }
            else
            {

                Node last = list.head;
                while (last.next != null)
                {
                    last = last.next;
                }

                last.next = new_node;
            }

        }

        public void DeleteNodebyKey(LinkedList list, int key)
        {
            Node temp = list.head;
            Node prev = null;

            // CASE 1:  If head node itself holds the key to be deleted

            if (temp != null && temp.data == key)
            {
                list.head = temp.next;
                Console.WriteLine("\n");
                Console.Write("=> ");
                Console.WriteLine(key);
                Console.WriteLine("=>> Found and Deleted.");
                return;
            }

            // CASE 2:  If the key is somewhere other than at head

            while (temp != null && temp.data != key)
            {
                prev = temp;
                temp = temp.next;
            }

            if (temp != null)
            {
                prev.next = temp.next;
                Console.WriteLine();
                Console.Write("=> ");
                Console.WriteLine(key);
                Console.WriteLine("=>> Found and Deleted.");
            }

            // CASE 3: The key is not present 

            if (temp == null)
            {
                Console.WriteLine();
                Console.Write("=> ");
                Console.WriteLine(key);
                Console.WriteLine("=>> Not Found.");
            }
            return;

        }

        public void printList()
        {
            Node n = head;
            while (n != null)

            {
                Console.Write(n.data + " ");
                n = n.next;
            }
        }

        public void Clear()
        {
            head = null;
        }

        public class Program
        {
            public static void Main(string[] args)

            {
                Console.WriteLine();
                LinkedList L = new LinkedList();
                L.insert(L, 1);
                L.insert(L, 2);
                L.insert(L, 3);
                L.insert(L, 4);
                L.insert(L, 5);
                L.insert(L, 6);
                L.insert(L, 7);
                L.insert(L, 8);

                Console.Write("\n=> Original Linked List: ");
                L.printList();

                L.DeleteNodebyKey(L, 1);
                L.DeleteNodebyKey(L, 4);
                L.DeleteNodebyKey(L, 10);

                Console.Write("\n=> Linked List after deletion: ");
                L.printList();
                Console.Write("\n");
                
                Console.Write ("\n=> Linked List Cleared...");
                L.Clear();

                Console.WriteLine("\n");

            }
        }
    }
}