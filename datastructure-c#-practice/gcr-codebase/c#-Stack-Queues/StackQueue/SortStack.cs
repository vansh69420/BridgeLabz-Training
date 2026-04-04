using System;

class StackSort
{
    static int[] st = new int[50];
    static int top = -1;

    static void Push(int x) { st[++top] = x; }
    static int Pop() { return st[top--]; }

    static void InsertSorted(int x)
    {
        if (top == -1 || st[top] <= x)
        {
            Push(x);
            return;
        }
        int temp = Pop();
        InsertSorted(x);
        Push(temp);
    }

    static void Sort()
    {
        if (top == -1) return;
        int x = Pop();
        Sort();
        InsertSorted(x);
    }

    static void Main()
    {
        Push(30);
        Push(10);
        Push(20);

        Sort();

        while (top != -1)
            Console.WriteLine(Pop());
    }
}
