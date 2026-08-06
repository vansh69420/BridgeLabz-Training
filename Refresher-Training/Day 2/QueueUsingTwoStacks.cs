using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
        int q = int.Parse(Console.ReadLine());

        Stack<int> stackNewest = new Stack<int>();
        Stack<int> stackOldest = new Stack<int>();

        for (int i = 0; i < q; i++)
        {
            string[] parts = Console.ReadLine().Split(' ');
            int type = int.Parse(parts[0]);

            if (type == 1)
            {
                int x = int.Parse(parts[1]);
                stackNewest.Push(x);
            }
            else if (type == 2)
            {
                if (stackOldest.Count == 0)
                {
                    while (stackNewest.Count > 0)
                    {
                        stackOldest.Push(stackNewest.Pop());
                    }
                }

                stackOldest.Pop();
            }
            else if (type == 3)
            {
                if (stackOldest.Count == 0)
                {
                    while (stackNewest.Count > 0)
                    {
                        stackOldest.Push(stackNewest.Pop());
                    }
                }

                Console.WriteLine(stackOldest.Peek());
            }
        }
    }
}
