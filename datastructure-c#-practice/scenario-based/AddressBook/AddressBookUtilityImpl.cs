using System;

class AddressBookUtilityImpl : IAddressBook
{
    // Instead of arrays, we store all address books in ONE linked list
    private UniversalLinkedList addressBookList = new UniversalLinkedList();

    // Active AddressBook (same idea as activeBookIndex before)
    private AddressBook activeAddressBook = null;

    private bool predefinedLoaded = false;

    // --------- PRIVATE HELPERS (Linked List traversal) ----------

    private AddressBook FindAddressBookByName(string bookName)
    {
        UniversalLinkedList.Node temp = addressBookList.GetHead();

        while (temp != null)
        {
            AddressBook book = (AddressBook)temp.GetData();

            if (book.GetName() == bookName)
                return book;

            temp = temp.GetNext();
        }

        return null;
    }

    private bool IsAddressBookNameExists(string bookName)
    {
        return FindAddressBookByName(bookName) != null;
    }

    private bool IsDuplicatePersonInActiveBook(string firstName, string lastName)
    {
        if (activeAddressBook == null)
            return false;

        UniversalLinkedList.Node temp = activeAddressBook.GetContacts().GetHead();

        while (temp != null)
        {
            Contact c = (Contact)temp.GetData();

            if (c != null &&
                c.GetFirstName() == firstName &&
                c.GetLastName() == lastName)
            {
                return true;
            }

            temp = temp.GetNext();
        }

        return false;
    }

    private int CompareContactsByName(Contact a, Contact b)
    {
        int firstCompare = string.Compare(a.GetFirstName(), b.GetFirstName(), StringComparison.Ordinal);
        if (firstCompare != 0)
            return firstCompare;

        return string.Compare(a.GetLastName(), b.GetLastName(), StringComparison.Ordinal);
    }

    // ---------------- REQUIRED METHODS ----------------

    public void LoadPredefinedContacts()
    {
        if (predefinedLoaded == true)
        {
            return;
        }

        // Create multiple predefined Address Books
        AddressBook defaultBook = new AddressBook();
        defaultBook.SetName("Default");
        addressBookList.AddLast(defaultBook);

        AddressBook familyBook = new AddressBook();
        familyBook.SetName("Family");
        addressBookList.AddLast(familyBook);

        AddressBook officeBook = new AddressBook();
        officeBook.SetName("Office");
        addressBookList.AddLast(officeBook);

        // Set Default as active (same as activeBookIndex = 0)
        activeAddressBook = defaultBook;

        // ---- Add predefined contacts in "Default" ----
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
        activeAddressBook = familyBook;

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
        activeAddressBook = officeBook;

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
        activeAddressBook = defaultBook;

        predefinedLoaded = true;
    }

    public void AddBook(Contact contact)
    {
        if (contact == null)
        {
            return;
        }

        if (activeAddressBook == null)
        {
            return;
        }

        // LinkedList insert instead of array insert
        activeAddressBook.GetContacts().AddLast(contact);
    }

    public Contact CreateContact()
    {
        Contact c = new Contact();

        Console.Write("Enter First Name: ");
        string firstName = Console.ReadLine();

        Console.Write("Enter Last Name: ");
        string lastName = Console.ReadLine();

        // Duplicate check inside ACTIVE address book (same as your Version 7)
        if (IsDuplicatePersonInActiveBook(firstName, lastName))
        {
            Console.WriteLine("This contact is already in the Address Book");
            return null;
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
                break;

            Console.WriteLine("Invalid input.");
        }

        if (choice == "1")
        {
            UniversalLinkedList.Node bookNode = addressBookList.GetHead();

            while (bookNode != null)
            {
                AddressBook book = (AddressBook)bookNode.GetData();
                Console.WriteLine("Address Book: " + book.GetName());

                UniversalLinkedList.Node contactNode = book.GetContacts().GetHead();
                while (contactNode != null)
                {
                    Contact c = (Contact)contactNode.GetData();
                    Console.WriteLine(c.ToString());
                    Console.WriteLine();
                    contactNode = contactNode.GetNext();
                }

                Console.WriteLine();
                bookNode = bookNode.GetNext();
            }
        }
        else
        {
            Console.Write("Enter Address Book Name: ");
            string bookName = Console.ReadLine();

            AddressBook book = FindAddressBookByName(bookName);

            if (book == null)
            {
                Console.WriteLine("Address Book not found.");
                return;
            }

            Console.WriteLine("Address Book: " + book.GetName());

            UniversalLinkedList.Node contactNode = book.GetContacts().GetHead();
            while (contactNode != null)
            {
                Contact c = (Contact)contactNode.GetData();
                Console.WriteLine(c.ToString());
                Console.WriteLine();
                contactNode = contactNode.GetNext();
            }
        }
    }

    public void EditContact()
    {
        if (activeAddressBook == null)
        {
            return;
        }

        Console.Write("Enter First Name to Edit: ");
        string firstName = Console.ReadLine();

        Console.Write("Enter Last Name to Edit: ");
        string lastName = Console.ReadLine();

        UniversalLinkedList.Node temp = activeAddressBook.GetContacts().GetHead();

        while (temp != null)
        {
            Contact c = (Contact)temp.GetData();

            if (c.GetFirstName() == firstName && c.GetLastName() == lastName)
            {
                Console.Write("Enter New First Name: ");
                c.SetFirstName(Console.ReadLine());

                Console.Write("Enter New Last Name: ");
                c.SetLastName(Console.ReadLine());

                Console.Write("Enter New Address: ");
                c.SetAddress(Console.ReadLine());

                Console.Write("Enter New City: ");
                c.SetCity(Console.ReadLine());

                Console.Write("Enter New State: ");
                c.SetState(Console.ReadLine());

                Console.Write("Enter New Zip: ");
                c.SetZip(Console.ReadLine());

                Console.Write("Enter New Phone Number: ");
                c.SetPhoneNumber(Console.ReadLine());

                Console.Write("Enter New Email: ");
                c.SetEmail(Console.ReadLine());

                return;
            }

            temp = temp.GetNext();
        }
    }

    public void DeleteContact()
    {
        if (activeAddressBook == null)
        {
            return;
        }

        Console.Write("Enter First Name to Delete: ");
        string firstName = Console.ReadLine();

        Console.Write("Enter Last Name to Delete: ");
        string lastName = Console.ReadLine();

        UniversalLinkedList contacts = activeAddressBook.GetContacts();
        UniversalLinkedList.Node node = contacts.GetHead();

        while (node != null)
        {
            Contact c = (Contact)node.GetData();

            if (c.GetFirstName() == firstName && c.GetLastName() == lastName)
            {
                // If deleting head -> use RemoveFirst (because head is private inside linked list)
                if (node == contacts.GetHead())
                {
                    contacts.RemoveFirst();
                    return;
                }

                // If deleting tail -> use RemoveLast (tail is private)
                if (node.GetNext() == null)
                {
                    contacts.RemoveLast();
                    return;
                }

                // Middle delete -> unlink prev/next
                UniversalLinkedList.Node prev = node.GetPrev();
                UniversalLinkedList.Node next = node.GetNext();

                prev.SetNext(next);
                next.SetPrev(prev);

                return;
            }

            node = node.GetNext();
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
                Console.WriteLine("Address Book name already exists. Please enter a unique name.");
            else
                break;
        }

        AddressBook newBook = new AddressBook();
        newBook.SetName(bookName);

        addressBookList.AddLast(newBook);
        activeAddressBook = newBook;

        int n;

        while (true)
        {
            Console.Write("How many contacts you want to add: ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out n) && n > 0)
                break;

            Console.WriteLine("Invalid input. Please enter a valid number.");
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

        UniversalLinkedList.Node bookNode = addressBookList.GetHead();

        while (bookNode != null)
        {
            AddressBook book = (AddressBook)bookNode.GetData();

            UniversalLinkedList.Node contactNode = book.GetContacts().GetHead();
            while (contactNode != null)
            {
                Contact c = (Contact)contactNode.GetData();

                if (c.GetCity() == city)
                {
                    Console.WriteLine("Address Book: " + book.GetName());
                    Console.WriteLine(c.ToString());
                    Console.WriteLine();
                    found = true;
                }

                contactNode = contactNode.GetNext();
            }

            bookNode = bookNode.GetNext();
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

        UniversalLinkedList.Node bookNode = addressBookList.GetHead();

        while (bookNode != null)
        {
            AddressBook book = (AddressBook)bookNode.GetData();

            UniversalLinkedList.Node contactNode = book.GetContacts().GetHead();
            while (contactNode != null)
            {
                Contact c = (Contact)contactNode.GetData();

                if (c.GetState() == state)
                {
                    Console.WriteLine("Address Book: " + book.GetName());
                    Console.WriteLine(c.ToString());
                    Console.WriteLine();
                    found = true;
                }

                contactNode = contactNode.GetNext();
            }

            bookNode = bookNode.GetNext();
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

        UniversalLinkedList.Node bookNode = addressBookList.GetHead();

        while (bookNode != null)
        {
            AddressBook book = (AddressBook)bookNode.GetData();

            UniversalLinkedList.Node contactNode = book.GetContacts().GetHead();
            while (contactNode != null)
            {
                Contact c = (Contact)contactNode.GetData();

                if (c.GetCity() == city)
                {
                    countCity++;
                }

                contactNode = contactNode.GetNext();
            }

            bookNode = bookNode.GetNext();
        }

        Console.WriteLine("Total contacts in city '" + city + "': " + countCity);
    }

    public void CountContactsByState()
    {
        Console.Write("Enter State: ");
        string state = Console.ReadLine();

        int countState = 0;

        UniversalLinkedList.Node bookNode = addressBookList.GetHead();

        while (bookNode != null)
        {
            AddressBook book = (AddressBook)bookNode.GetData();

            UniversalLinkedList.Node contactNode = book.GetContacts().GetHead();
            while (contactNode != null)
            {
                Contact c = (Contact)contactNode.GetData();

                if (c.GetState() == state)
                {
                    countState++;
                }

                contactNode = contactNode.GetNext();
            }

            bookNode = bookNode.GetNext();
        }

        Console.WriteLine("Total contacts in state '" + state + "': " + countState);
    }

    public void SortContactsByName()
    {
        Console.Write("Enter Address Book Name to Sort: ");
        string bookName = Console.ReadLine();

        AddressBook book = FindAddressBookByName(bookName);

        if (book == null)
        {
            Console.WriteLine("Address Book not found.");
            return;
        }

        // Bubble sort on linked list by swapping node data
        bool swapped = true;

        while (swapped)
        {
            swapped = false;

            UniversalLinkedList.Node current = book.GetContacts().GetHead();

            while (current != null && current.GetNext() != null)
            {
                Contact a = (Contact)current.GetData();
                Contact b = (Contact)current.GetNext().GetData();

                if (CompareContactsByName(a, b) > 0)
                {
                    current.SetData(b);
                    current.GetNext().SetData(a);
                    swapped = true;
                }

                current = current.GetNext();
            }
        }

        Console.WriteLine("Contacts sorted alphabetically by Person's name.");
    }
}