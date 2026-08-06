using System;
using System.Collections.Generic;
using System.IO;

class Node
    {
        public int data;
        public Node? left;
        public Node? right;

        public Node(int data)
        {
            this.data = data;
            this.left = null;
            this.right = null;
        }
    }
class Solution {
    
    static void InOrder(Node? root)
    {
        if (root == null)
        {
            return;
        }

        InOrder(root.left);

        Console.Write(root.data + " ");

        InOrder(root.right);
    }
    
    static Node Insert(Node? root, int data)
    {
        if (root == null)
        {
            return new Node(data);
        }

        if (data < root.data)
        {
            root.left = Insert(root.left, data);
        }
        else
        {
            root.right = Insert(root.right, data);
        }

        return root;
    }
    
    static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());

        Node? root = null;

        string[] values = Console.ReadLine().Split(' ');

        for (int i = 0; i < n; i++)
        {
            int data = Convert.ToInt32(values[i]);
            root = Insert(root, data);
        }

        InOrder(root);
    }
}