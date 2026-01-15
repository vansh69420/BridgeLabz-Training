using System;

class AddressBookUtilityImpl : IAddressBook
{
    // Multiple Address Books (arrays only)
    private string[] addressBookNames = new string[10];
    private Contact[][] addressBooks = new Contact[10][];
    private int[] contactCount = new int[10];

    private int addressBookCount = 0;
    private int activeBookIndex = 0;

    private bool predefinedLoaded = false;

    private bool IsAddressBookNameExists(string bookName)
    {
        for (int i = 0; i < addressBookCount; i++)
        {
            if (addressBookNames[i] == bookName)
            {
                return true;
            }
        }
        return false;
    }

    public void LoadPredefinedContacts()
    {
        if (predefinedLoaded == true)
        {
            return;
        }

        // Create multiple predefined Address Books
        addressBookNames[0] = "Default";
        addressBooks[0] = new Contact[100];
        contactCount[0] = 0;

        addressBookNames[1] = "Family";
        addressBooks[1] = new Contact[100];
        contactCount[1] = 0;

        addressBookNames[2] = "Office";
        addressBooks[2] = new Contact[100];
        contactCount[2] = 0;

        addressBookCount = 3;
        activeBookIndex = 0;

        // ---- Add predefined contacts in "Default" ----
        activeBookIndex = 0;

        Contact d1 = new Contact();
        d1.SetFirstName("Rahul");
        d1.SetLastName("Sharma");
        d1.SetAddress("12, MG Road");
        d1.SetCity("Bengaluru");
        d1.SetState("Karnataka");
        d1.SetZip("560001");
        d1.SetPhoneNumber("9876543210");
        d1.SetEmail("rahul.sharma@gmail.com");
        AddBook(d1);

        Contact d2 = new Contact();
        d2.SetFirstName("Priya");
        d2.SetLastName("Iyer");
        d2.SetAddress("45, T Nagar");
        d2.SetCity("Chennai");
        d2.SetState("Tamil Nadu");
        d2.SetZip("600017");
        d2.SetPhoneNumber("9123456780");
        d2.SetEmail("priya.iyer@gmail.com");
        AddBook(d2);

        // ---- Add predefined contacts in "Family" ----
        activeBookIndex = 1;

        Contact f1 = new Contact();
        f1.SetFirstName("Ananya");
        f1.SetLastName("Verma");
        f1.SetAddress("21, Rajpath");
        f1.SetCity("New Delhi");
        f1.SetState("Delhi");
        f1.SetZip("110001");
        f1.SetPhoneNumber("9988776655");
        f1.SetEmail("ananya.verma@gmail.com");
        AddBook(f1);

        // ---- Add predefined contacts in "Office" ----
        activeBookIndex = 2;

        Contact o1 = new Contact();
        o1.SetFirstName("Arjun");
        o1.SetLastName("Nair");
        o1.SetAddress("8, Bandra West");
        o1.SetCity("Mumbai");
        o1.SetState("Maharashtra");
        o1.SetZip("400050");
        o1.SetPhoneNumber("9012345678");
        o1.SetEmail("arjun.nair@company.com");
        AddBook(o1);

        // Reset active book back to Default
        activeBookIndex = 0;

        predefinedLoaded = true;
    }

    public void AddBook(Contact contact)
    {
        if (contact == null)
        {
            return;
        }

        if (addressBooks[activeBookIndex] == null)
        {
            return;
        }

        if (contactCount[activeBookIndex] >= addressBooks[activeBookIndex].Length)
        {
            return;
        }

        addressBooks[activeBookIndex][contactCount[activeBookIndex]] = contact;
        contactCount[activeBookIndex]++;
    }

    public Contact CreateContact()
    {
        Contact c = new Contact();

        Console.Write("Enter First Name: ");
        string firstName = Console.ReadLine();

        Console.Write("Enter Last Name: ");
        string lastName = Console.ReadLine();

        // Version 7: Duplicate check inside the active address book
        if (IsDuplicatePersonInActiveBook(firstName, lastName))
        {
            Console.WriteLine("This contact is already in the Address Book");
            return null; // stops and menu shows again
        }

        c.SetFirstName(firstName);
        c.SetLastName(lastName);

        Console.Write("Enter Address: ");
        c.SetAddress(Console.ReadLine());

        Console.Write("Enter City: ");
        c.SetCity(Console.ReadLine());

        Console.Write("Enter State: ");
        c.SetState(Console.ReadLine());

        Console.Write("Enter Zip: ");
        c.SetZip(Console.ReadLine());

        Console.Write("Enter Phone Number: ");
        c.SetPhoneNumber(Console.ReadLine());

        Console.Write("Enter Email: ");
        c.SetEmail(Console.ReadLine());

        return c;
    }

    private int GetAddressBookIndexByName(string bookName)
    {
        for (int i = 0; i < addressBookCount; i++)
        {
            if (addressBookNames[i] == bookName)
            {
                return i;
            }
        }
        return -1;
    }

    public void DisplayContacts()
    {
        string choice;

        while (true)
        {
            Console.WriteLine("1. Display All Address Books Contacts");
            Console.WriteLine("2. Display Particular Address Book Contacts");
            Console.Write("Enter choice: ");
            choice = Console.ReadLine();

            if (choice == "1" || choice == "2")
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid input.");
            }
        }

        if (choice == "1")
        {
            for (int b = 0; b < addressBookCount; b++)
            {
                Console.WriteLine("Address Book: " + addressBookNames[b]);

                for (int i = 0; i < contactCount[b]; i++)
                {
                    if (addressBooks[b][i] != null)
                    {
                        Console.WriteLine(addressBooks[b][i].ToString());
                        Console.WriteLine();
                    }
                }

                Console.WriteLine();
            }
        }
        else if (choice == "2")
        {
            Console.Write("Enter Address Book Name: ");
            string bookName = Console.ReadLine();

            int index = GetAddressBookIndexByName(bookName);

            if (index == -1)
            {
                Console.WriteLine("Address Book not found.");
                return; // goes back to menu loop
            }

            Console.WriteLine("Address Book: " + addressBookNames[index]);

            for (int i = 0; i < contactCount[index]; i++)
            {
                if (addressBooks[index][i] != null)
                {
                    Console.WriteLine(addressBooks[index][i].ToString());
                    Console.WriteLine();
                }
            }
        }
    }

    public void EditContact()
    {
        if (addressBooks[activeBookIndex] == null)
        {
            return;
        }

        Console.Write("Enter First Name to Edit: ");
        string firstName = Console.ReadLine();

        Console.Write("Enter Last Name to Edit: ");
        string lastName = Console.ReadLine();

        int index = -1;

        for (int i = 0; i < contactCount[activeBookIndex]; i++)
        {
            if (addressBooks[activeBookIndex][i].GetFirstName() == firstName &&
                addressBooks[activeBookIndex][i].GetLastName() == lastName)
            {
                index = i;
                break;
            }
        }

        if (index == -1)
        {
            return;
        }

        Console.Write("Enter New First Name: ");
        addressBooks[activeBookIndex][index].SetFirstName(Console.ReadLine());

        Console.Write("Enter New Last Name: ");
        addressBooks[activeBookIndex][index].SetLastName(Console.ReadLine());

        Console.Write("Enter New Address: ");
        addressBooks[activeBookIndex][index].SetAddress(Console.ReadLine());

        Console.Write("Enter New City: ");
        addressBooks[activeBookIndex][index].SetCity(Console.ReadLine());

        Console.Write("Enter New State: ");
        addressBooks[activeBookIndex][index].SetState(Console.ReadLine());

        Console.Write("Enter New Zip: ");
        addressBooks[activeBookIndex][index].SetZip(Console.ReadLine());

        Console.Write("Enter New Phone Number: ");
        addressBooks[activeBookIndex][index].SetPhoneNumber(Console.ReadLine());

        Console.Write("Enter New Email: ");
        addressBooks[activeBookIndex][index].SetEmail(Console.ReadLine());
    }

    public void DeleteContact()
    {
        if (addressBooks[activeBookIndex] == null)
        {
            return;
        }

        Console.Write("Enter First Name to Delete: ");
        string firstName = Console.ReadLine();

        Console.Write("Enter Last Name to Delete: ");
        string lastName = Console.ReadLine();

        int index = -1;

        for (int i = 0; i < contactCount[activeBookIndex]; i++)
        {
            if (addressBooks[activeBookIndex][i].GetFirstName() == firstName &&
                addressBooks[activeBookIndex][i].GetLastName() == lastName)
            {
                index = i;
                break;
            }
        }

        if (index == -1)
        {
            return;
        }

        for (int i = index; i < contactCount[activeBookIndex] - 1; i++)
        {
            addressBooks[activeBookIndex][i] = addressBooks[activeBookIndex][i + 1];
        }

        addressBooks[activeBookIndex][contactCount[activeBookIndex] - 1] = null;
        contactCount[activeBookIndex]--;
    }

    // Version 6: Creates NEW Address Book (unique name) + adds multiple contacts using CreateContact()
    public void AddMultipleContacts()
    {
        string bookName;

        while (true)
        {
            Console.Write("Enter Address Book Name (must be unique): ");
            bookName = Console.ReadLine();

            if (IsAddressBookNameExists(bookName))
            {
                Console.WriteLine("Address Book name already exists. Please enter a unique name.");
            }
            else
            {
                break;
            }
        }

        if (addressBookCount >= addressBookNames.Length)
        {
            return;
        }

        addressBookNames[addressBookCount] = bookName;
        addressBooks[addressBookCount] = new Contact[100];
        contactCount[addressBookCount] = 0;

        activeBookIndex = addressBookCount;
        addressBookCount++;

        int n;

        while (true)
        {
            Console.Write("How many contacts you want to add: ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out n) && n > 0)
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
        }

        for (int i = 0; i < n; i++)
        {
            Contact c = CreateContact();
            if (c == null)
            {
                return; // duplicate -> back to menu
            }

            AddBook(c);
            Console.WriteLine("This contact is added to the Address Book successfully.");
            Console.WriteLine();
        }
    }
    private bool IsDuplicatePersonInActiveBook(string firstName, string lastName)
    {
        for (int i = 0; i < contactCount[activeBookIndex]; i++)
        {
            if (addressBooks[activeBookIndex][i] != null &&
                addressBooks[activeBookIndex][i].GetFirstName() == firstName &&
                addressBooks[activeBookIndex][i].GetLastName() == lastName)
            {
                return true;
            }
        }
        return false;
    }
    public void SearchPersonByCity()
    {
        Console.Write("Enter City: ");
        string city = Console.ReadLine();

        bool found = false;

        for (int b = 0; b < addressBookCount; b++)
        {
            for (int i = 0; i < contactCount[b]; i++)
            {
                if (addressBooks[b][i] != null && addressBooks[b][i].GetCity() == city)
                {
                    Console.WriteLine("Address Book: " + addressBookNames[b]);
                    Console.WriteLine(addressBooks[b][i].ToString());
                    Console.WriteLine();
                    found = true;
                }
            }
        }

        if (found == false)
        {
            Console.WriteLine("No contact found in this city.");
        }
    }

    public void SearchPersonByState()
    {
        Console.Write("Enter State: ");
        string state = Console.ReadLine();

        bool found = false;

        for (int b = 0; b < addressBookCount; b++)
        {
            for (int i = 0; i < contactCount[b]; i++)
            {
                if (addressBooks[b][i] != null && addressBooks[b][i].GetState() == state)
                {
                    Console.WriteLine("Address Book: " + addressBookNames[b]);
                    Console.WriteLine(addressBooks[b][i].ToString());
                    Console.WriteLine();
                    found = true;
                }
            }
        }

        if (found == false)
        {
            Console.WriteLine("No contact found in this state.");
        }
    }
}