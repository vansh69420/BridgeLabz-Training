using System;

namespace TechVille
{
    public class CircularCitizenList
    {
        private CitizenNode head;

        public void Insert(Citizen citizen)
        {
            CitizenNode newNode = new CitizenNode(citizen);

            if (head == null)
            {
                head = newNode;
                newNode.Next = head;
                return;
            }

            CitizenNode temp = head;

            while (temp.Next != head)
                temp = temp.Next;

            temp.Next = newNode;
            newNode.Next = head;
        }

        public void Display()
        {
            if (head == null)
                return;

            CitizenNode temp = head;

            do
            {
                Console.WriteLine(temp.Data.Name);
                temp = temp.Next;
            }
            while (temp != head);
        }
    }
}
