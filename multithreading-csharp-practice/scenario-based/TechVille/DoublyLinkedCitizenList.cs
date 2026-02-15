using System;

namespace TechVille
{
    public class DoublyLinkedCitizenList
    {
        private CitizenNode head;

        public void Insert(Citizen citizen)
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
            newNode.Previous = temp;
        }

        public void Delete(string name)
        {
            CitizenNode temp = head;

            while (temp != null)
            {
                if (temp.Data.Name.ToLower() == name.ToLower())
                {
                    if (temp.Previous != null)
                        temp.Previous.Next = temp.Next;
                    else
                        head = temp.Next;

                    if (temp.Next != null)
                        temp.Next.Previous = temp.Previous;

                    Console.WriteLine("Citizen removed.");
                    return;
                }

                temp = temp.Next;
            }

            Console.WriteLine("Citizen not found.");
        }

        public Citizen Find(string name)
        {
            CitizenNode temp = head;

            while (temp != null)
            {
                if (temp.Data.Name.ToLower() == name.ToLower())
                    return temp.Data;

                temp = temp.Next;
            }

            return null;
        }

        public void TraverseForward()
        {
            CitizenNode temp = head;

            while (temp != null)
            {
                Console.WriteLine(temp.Data.ToString());
                temp = temp.Next;
            }
        }

        public void TraverseBackward()
        {
            if (head == null)
                return;

            CitizenNode temp = head;

            while (temp.Next != null)
                temp = temp.Next;

            while (temp != null)
            {
                Console.WriteLine(temp.Data.ToString());
                temp = temp.Previous;
            }
        }
    }
}
