using System;

namespace TechVille
{
    public class CitizenStack
    {
        private Citizen[] stack;
        private int top;

        public CitizenStack(int capacity)
        {
            stack = new Citizen[capacity];
            top = -1;
        }

        public bool IsEmpty()
        {
            return top == -1;
        }

        public void Push(Citizen citizen)
        {
            if (top == stack.Length - 1)
            {
                Console.WriteLine("Stack Overflow!");
                return;
            }

            stack[++top] = citizen;
        }

        public Citizen? Pop()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Nothing to undo.");
                return null;
            }

            return stack[top--];
        }
    }
}
