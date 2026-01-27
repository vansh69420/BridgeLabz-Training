using System;
using System.Collections.Generic;

class AddressBookUtilityImpl : IAddressBook
{
    // COLLECTIONS:
    // Key = AddressBook name (unique)
    // Value = List of contacts in that book
    private Dictionary<string, List<Contact>> addressBooks = new Dictionary<string, List<Contact>>();

    // Active book (used by Add/Edit/Delete/CreateContact duplicate check)
    private string activeBookName = "Default";

    private bool predefinedLoaded = false;

    private bool IsAddressBookNameExists(string bookName)
    {
        return addressBooks.ContainsKey(bookName);
    }

    private bool IsDuplicatePersonInActiveBook(string firstName, string lastName)
    {
        if (!addressBooks.ContainsKey(activeBookName))
        {
            return false;
        }

        List<Contact> list = addressBooks[activeBookName];

        for (int i = 0; i < list.Count; i++)
        {
            if (list[i].GetFirstName() == firstName && list[i].GetLastName() == lastName)
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

        // Multiple predefined Address Books
        addressBooks["Default"] = new List<Contact>();
        addressBooks["Family"]  = new List<Contact>();
        addressBooks["Office"]  = new List<Contact>();

        activeBookName = "Default";

        // Default contacts
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

        // Family contacts
        activeBookName = "Family";
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

        // Office contacts
        activeBookName = "Office";
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

        // Reset active back to Default
        activeBookName = "Default";

        predefinedLoaded = true;
    }

    public void AddBook(Contact contact)
    {
        if (contact == null)
        {
            return;
        }

        if (!addressBooks.ContainsKey(activeBookName))
        {
            return;
        }

        addressBooks[activeBookName].Add(contact);
    }

    public Contact CreateContact()
    {
        Contact c = new Contact();

        Console.Write("Enter First Name: ");
        string firstName = Console.ReadLine();

        Console.Write("Enter Last Name: ");
        string lastName = Console.ReadLine();

        if (IsDuplicatePersonInActiveBook(firstName, lastName))
        {
            Console.WriteLine("This contact is already in the Address Book");
            return null; // menu shows again
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
            foreach (KeyValuePair<string, List<Contact>> kv in addressBooks)
            {
                Console.WriteLine("Address Book: " + kv.Key);

                List<Contact> list = kv.Value;
                for (int i = 0; i < list.Count; i++)
                {
                    Console.WriteLine(list[i].ToString());
                    Console.WriteLine();
                }

                Console.WriteLine();
            }
        }
        else
        {
            Console.Write("Enter Address Book Name: ");
            string bookName = Console.ReadLine();

            if (!addressBooks.ContainsKey(bookName))
            {
                Console.WriteLine("Address Book not found.");
                return;
            }

            Console.WriteLine("Address Book: " + bookName);

            List<Contact> list = addressBooks[bookName];
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i].ToString());
                Console.WriteLine();
            }
        }
    }

    public void EditContact()
    {
        if (!addressBooks.ContainsKey(activeBookName))
        {
            return;
        }

        Console.Write("Enter First Name to Edit: ");
        string firstName = Console.ReadLine();

        Console.Write("Enter Last Name to Edit: ");
        string lastName = Console.ReadLine();

        List<Contact> list = addressBooks[activeBookName];

        for (int i = 0; i < list.Count; i++)
        {
            if (list[i].GetFirstName() == firstName && list[i].GetLastName() == lastName)
            {
                Console.Write("Enter New First Name: ");
                list[i].SetFirstName(Console.ReadLine());

                Console.Write("Enter New Last Name: ");
                list[i].SetLastName(Console.ReadLine());

                Console.Write("Enter New Address: ");
                list[i].SetAddress(Console.ReadLine());

                Console.Write("Enter New City: ");
                list[i].SetCity(Console.ReadLine());

                Console.Write("Enter New State: ");
                list[i].SetState(Console.ReadLine());

                Console.Write("Enter New Zip: ");
                list[i].SetZip(Console.ReadLine());

                Console.Write("Enter New Phone Number: ");
                list[i].SetPhoneNumber(Console.ReadLine());

                Console.Write("Enter New Email: ");
                list[i].SetEmail(Console.ReadLine());

                return;
            }
        }
    }

    public void DeleteContact()
    {
        if (!addressBooks.ContainsKey(activeBookName))
        {
            return;
        }

        Console.Write("Enter First Name to Delete: ");
        string firstName = Console.ReadLine();

        Console.Write("Enter Last Name to Delete: ");
        string lastName = Console.ReadLine();

        List<Contact> list = addressBooks[activeBookName];

        for (int i = 0; i < list.Count; i++)
        {
            if (list[i].GetFirstName() == firstName && list[i].GetLastName() == lastName)
            {
                list.RemoveAt(i);
                return;
            }
        }
    }

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

        addressBooks[bookName] = new List<Contact>();
        activeBookName = bookName;

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

    public void SearchPersonByCity()
    {
        Console.Write("Enter City: ");
        string city = Console.ReadLine();

        bool found = false;

        foreach (KeyValuePair<string, List<Contact>> kv in addressBooks)
        {
            string bookName = kv.Key;
            List<Contact> list = kv.Value;

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].GetCity() == city)
                {
                    Console.WriteLine("Address Book: " + bookName);
                    Console.WriteLine(list[i].ToString());
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

        foreach (KeyValuePair<string, List<Contact>> kv in addressBooks)
        {
            string bookName = kv.Key;
            List<Contact> list = kv.Value;

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].GetState() == state)
                {
                    Console.WriteLine("Address Book: " + bookName);
                    Console.WriteLine(list[i].ToString());
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

    public void CountContactsByCity()
    {
        Console.Write("Enter City: ");
        string city = Console.ReadLine();

        int countCity = 0;

        foreach (KeyValuePair<string, List<Contact>> kv in addressBooks)
        {
            List<Contact> list = kv.Value;
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].GetCity() == city)
                {
                    countCity++;
                }
            }
        }

        Console.WriteLine("Total contacts in city '" + city + "': " + countCity);
    }

    public void CountContactsByState()
    {
        Console.Write("Enter State: ");
        string state = Console.ReadLine();

        int countState = 0;

        foreach (KeyValuePair<string, List<Contact>> kv in addressBooks)
        {
            List<Contact> list = kv.Value;
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].GetState() == state)
                {
                    countState++;
                }
            }
        }

        Console.WriteLine("Total contacts in state '" + state + "': " + countState);
    }

    public void SortContactsByName()
    {
        Console.Write("Enter Address Book Name to Sort: ");
        string bookName = Console.ReadLine();

        if (!addressBooks.ContainsKey(bookName))
        {
            Console.WriteLine("Address Book not found.");
            return;
        }

        List<Contact> list = addressBooks[bookName];

        // Bubble sort (no LINQ, manual sorting)
        for (int i = 0; i < list.Count - 1; i++)
        {
            for (int j = 0; j < list.Count - 1 - i; j++)
            {
                int cmpFirst = string.Compare(list[j].GetFirstName(), list[j + 1].GetFirstName(), StringComparison.Ordinal);

                bool swap = false;

                if (cmpFirst > 0)
                {
                    swap = true;
                }
                else if (cmpFirst == 0)
                {
                    int cmpLast = string.Compare(list[j].GetLastName(), list[j + 1].GetLastName(), StringComparison.Ordinal);
                    if (cmpLast > 0)
                    {
                        swap = true;
                    }
                }

                if (swap)
                {
                    Contact temp = list[j];
                    list[j] = list[j + 1];
                    list[j + 1] = temp;
                }
            }
        }

        Console.WriteLine("Contacts sorted alphabetically by Person's name.");
    }
}