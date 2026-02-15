using System;

namespace TechVille
{
    public class PriorityNode
    {
        public Citizen Citizen;
        public int Priority;
        public PriorityNode? Next;


        public PriorityNode(Citizen citizen, int priority)
        {
            Citizen = citizen;
            Priority = priority;
            Next = null;
        }
    }

    public class PriorityQueue
    {
        private PriorityNode? head;


        public void Enqueue(Citizen citizen, int priority)
        {
            PriorityNode newNode = new PriorityNode(citizen, priority);

            if (head == null || priority > head.Priority)
            {
                newNode.Next = head;
                head = newNode;
                return;
            }

            PriorityNode current = head;

            while (current.Next != null && current.Next.Priority >= priority)
            {
                current = current.Next;
            }

            newNode.Next = current.Next;
            current.Next = newNode;
        }

        public Citizen? Dequeue()
        {
            if (head == null)
            {
                Console.WriteLine("No emergency requests.");
                return null;
            }

            Citizen removed = head.Citizen;
            head = head.Next;
            return removed;
        }

        public void Display()
        {
            PriorityNode temp = head;
            while (temp != null)
            {
                Console.WriteLine(temp.Citizen.Name + " - Priority: " + temp.Priority);
                temp = temp.Next;
            }
        }
    }
}
