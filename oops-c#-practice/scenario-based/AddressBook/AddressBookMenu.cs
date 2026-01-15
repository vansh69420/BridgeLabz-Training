using System;

class AddressBookMenu
{
    private AddressBookUtilityImpl utility = new AddressBookUtilityImpl();

    public void Start()
    {
        utility.LoadPredefinedContacts();

        bool isRunning = true;

        while (isRunning)
        {
            Console.WriteLine("1. Add Contact");
            Console.WriteLine("2. Display Contacts");
            Console.WriteLine("3. Edit Contact");
            Console.WriteLine("4. Delete Contact");
            Console.WriteLine("5. Create New Address Book + Add Multiple Contacts");
            Console.WriteLine("6. Search Person By City");
            Console.WriteLine("7. Search Person By State");
            Console.WriteLine("8. Count Contacts By City");
            Console.WriteLine("9. Count Contacts By State");
            Console.WriteLine("10. Sort Contacts By Name");
            Console.WriteLine("11. Exit");
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
                    utility.DeleteContact();
                    break;

                case "5":
                    utility.AddMultipleContacts();
                    break;

                case "6":
                    utility.SearchPersonByCity();
                    break;

                case "7":
                    utility.SearchPersonByState();
                    break;

                case "8":
                    utility.CountContactsByCity();
                    break;

                case "9":
                    utility.CountContactsByState();
                    break;

                case "10":
                    utility.SortContactsByName();
                    break;

                case "11":
                    isRunning = false;
                    break;

                default:
                    break;
            }

            Console.WriteLine();
        }
    }
}