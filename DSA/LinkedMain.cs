using System;
using System.Net;

// Delete a node Without using Heqd.
class LinkedMain
{
    public static void Main()
    {
        Utility utility = new Utility();
        Node head = new Node(10);
        head.Next = new Node(20);
        head.Next.Next = new Node(30);
        head.Next.Next.Next = new Node(40);

        Console.WriteLine("Before deletion:");
        PrintList(head);

        Node nodeToDelete = head.Next;

        Utility.DeleteNodeWithoutHead(nodeToDelete);
        Console.WriteLine("After Deletion.");
        PrintList(head);
    }
    public static void PrintList(Node head)
    {
        Node temp = head;
        while (temp != null)
        {
            Console.Write(temp.Data + " ");
            temp = temp.Next;
        }
        Console.WriteLine();
    }
}