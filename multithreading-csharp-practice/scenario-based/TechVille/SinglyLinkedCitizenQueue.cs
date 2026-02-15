using System;

namespace TechVille
{
    public class SinglyLinkedCitizenQueue
    {
        private CitizenNode? head;


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

        public Citizen? Dequeue()
        {
            if (head == null)
            {
                Console.WriteLine("Queue is empty.");
                return null;
            }

            Citizen removedCitizen = head.Data;
            head = head.Next;

            return removedCitizen;
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
