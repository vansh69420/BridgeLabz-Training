class HashNode
{
    public int key, value;
    public HashNode next;
}

class HashMapArrayLinkedList
{
    HashNode[] table = new HashNode[10];

    int Hash(int key) { return key % 10; }

    public void Put(int key, int value)
    {
        int index = Hash(key);
        HashNode node = new HashNode { key = key, value = value };
        node.next = table[index];
        table[index] = node;
    }

    public int Get(int key)
    {
        int index = Hash(key);
        HashNode temp = table[index];

        while (temp != null)
        {
            if (temp.key == key) return temp.value;
            temp = temp.next;
        }
        return -1;
    }
}
