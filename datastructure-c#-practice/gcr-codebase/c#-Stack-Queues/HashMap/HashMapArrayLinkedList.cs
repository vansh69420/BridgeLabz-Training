using System;

class Node
{
    public int key;
    public int value;
    public Node next;

    public Node(int k, int v)
    {
        key = k;
        value = v;
        next = null;
    }
}

class HashMapArrayLinkedList
{
    Node[] table = new Node[10];

    int Hash(int key)
    {
        return key % table.Length;
    }

    public void Put(int key, int value)
    {
        int index = Hash(key);
        Node head = table[index];

        while (head != null)
        {
            if (head.key == key)
            {
                head.value = value;
                return;
            }
            head = head.next;
        }

        Node newNode = new Node(key, value);
        newNode.next = table[index];
        table[index] = newNode;
    }

    public int Get(int key)
    {
        int index = Hash(key);
        Node head = table[index];

        while (head != null)
        {
            if (head.key == key)
                return head.value;
            head = head.next;
        }
        return -1;
    }

    public void Remove(int key)
    {
        int index = Hash(key);
        Node head = table[index];
        Node prev = null;

        while (head != null)
        {
            if (head.key == key)
            {
                if (prev == null)
                    table[index] = head.next;
                else
                    prev.next = head.next;
                return;
            }
            prev = head;
            head = head.next;
        }
    }
}

class Program
{
    static void Main()
    {
        CustomHashMap map = new CustomHashMap();
        map.Put(1, 100);
        map.Put(2, 200);
        map.Put(11, 300);

        Console.WriteLine(map.Get(1));
        Console.WriteLine(map.Get(11));

        map.Remove(1);
        Console.WriteLine(map.Get(1));
    }
}
