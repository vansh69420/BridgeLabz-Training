using System;

class AddressBookMenu
{
    private AddressBookUtilityImpl utility = new AddressBookUtilityImpl();

    public void Start()
    {
        // predefined contacts stored once when program starts (menu starts)
        utility.LoadPredefinedContacts();

        bool isRunning = true;

        while (isRunning)
        {
            Console.WriteLine("1. Add Contact");
            Console.WriteLine("2. Display Contacts");
            Console.WriteLine("3. Edit Contact");
            Console.WriteLine("4. Exit");
            Console.Write("Enter choice: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    utility.AddBook(utility.CreateContact());
                    break;

                case "2":
                    utility.DisplayContacts();
                    break;

                case "3":
                    utility.EditContact();
                    break;

                case "4":
                    isRunning = false;
                    break;

                default:
                    // do nothing for now
                    break;
            }

            Console.WriteLine();
        }
    }
}