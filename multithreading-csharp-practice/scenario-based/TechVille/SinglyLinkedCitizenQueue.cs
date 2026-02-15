using System;

namespace TechVille
{
    public class SinglyLinkedCitizenQueue
    {
        private CitizenNode head;

        public void Enqueue(Citizen citizen)
        {
            CitizenNode newNode = new CitizenNode(citizen);

            if (head == null)
            {
                head = newNode;
                return;
            }

            CitizenNode temp = head;
            while (temp.Next != null)
                temp = temp.Next;

            temp.Next = newNode;
        }

        public void Dequeue()
        {
            if (head == null)
            {
                Console.WriteLine("Queue is empty.");
                return;
            }

            Console.WriteLine("Processing: " + head.Data.Name);
            head = head.Next;
        }

        public void Display()
        {
            CitizenNode temp = head;

            while (temp != null)
            {
                Console.WriteLine(temp.Data.Name);
                temp = temp.Next;
            }
        }
    }
}
