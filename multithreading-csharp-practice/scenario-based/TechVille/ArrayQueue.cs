using System;

namespace TechVille
{
    public class ArrayQueue
    {
        private Citizen[] queue;
        private int front;
        private int rear;
        private int size;

        public ArrayQueue(int capacity)
        {
            queue = new Citizen[capacity];
            front = 0;
            rear = -1;
            size = 0;
        }

        public bool IsFull()
        {
            return size == queue.Length;
        }

        public bool IsEmpty()
        {
            return size == 0;
        }

        public void Enqueue(Citizen citizen)
        {
            if (IsFull())
            {
                Console.WriteLine("Array Queue is full!");
                return;
            }

            rear++;
            queue[rear] = citizen;
            size++;
        }

        public Citizen? Dequeue()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Array Queue is empty!");
                return null;
            }

            Citizen removed = queue[front];
            front++;
            size--;
            return removed;
        }

        public void Display()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Queue is empty.");
                return;
            }

            for (int i = front; i <= rear; i++)
            {
                Console.WriteLine(queue[i].Name);
            }
        }
    }
}
