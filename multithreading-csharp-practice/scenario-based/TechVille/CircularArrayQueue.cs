using System;

namespace TechVille
{
    public class CircularArrayQueue
    {
        private Citizen[] queue;
        private int front;
        private int rear;
        private int size;

        public CircularArrayQueue(int capacity)
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
                Console.WriteLine("Circular Queue is full!");
                return;
            }

            rear = (rear + 1) % queue.Length;
            queue[rear] = citizen;
            size++;
        }

        public Citizen? Dequeue()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Circular Queue is empty!");
                return null;
            }

            Citizen removed = queue[front];
            front = (front + 1) % queue.Length;
            size--;
            return removed;
        }

        public void Display()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Empty.");
                return;
            }

            int count = 0;
            int i = front;

            while (count < size)
            {
                Console.WriteLine(queue[i].Name);
                i = (i + 1) % queue.Length;
                count++;
            }
        }
    }
}
