class Utility
{
    public static void DeleteNodeWithoutHead(Node node)
    {

        if (node == null || node.Next == null)
        {
            Console.WriteLine("Deletion not possible");
            return;
        }

        node.Data = node.Next.Data;
        node.Next = node.Next.Next;
    }
}