using System;
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
    
    public static Node Insert(Node? root, int data)
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
    
    static int GetHeight(Node? root)
    {
        if (root == null)
        {
            return -1;
        }

  
        int leftHeight = GetHeight(root.left);


        int rightHeight = GetHeight(root.right);


        return Math.Max(leftHeight, rightHeight) + 1;
    }
    
    static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());

        Node root = null;

        string[] values = Console.ReadLine().Split(' ');

        for (int i = 0; i < n; i++)
        {
            int data = Convert.ToInt32(values[i]);
            root = Insert(root, data);
        }

        int height = GetHeight(root);

        Console.WriteLine(height);
    }
}