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

        // Create Default Address Book on program start
        addressBookNames[0] = "India";
        addressBooks[0] = new Contact[100];
        contactCount[0] = 0;

        addressBookCount = 1;
        activeBookIndex = 0;

        // Predefined Contact 1 (India)
        Contact c1 = new Contact();
        c1.SetFirstName("Rahul");
        c1.SetLastName("Sharma");
        c1.SetAddress("12, MG Road");
        c1.SetCity("Bengaluru");
        c1.SetState("Karnataka");
        c1.SetZip("560001");
        c1.SetPhoneNumber("9876543210");
        c1.SetEmail("rahul.sharma@gmail.com");
        AddBook(c1);

        // Predefined Contact 2 (India)
        Contact c2 = new Contact();
        c2.SetFirstName("Priya");
        c2.SetLastName("Iyer");
        c2.SetAddress("45, T Nagar");
        c2.SetCity("Chennai");
        c2.SetState("Tamil Nadu");
        c2.SetZip("600017");
        c2.SetPhoneNumber("9123456780");
        c2.SetEmail("priya.iyer@gmail.com");
        AddBook(c2);

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

    public void DisplayContacts()
    {
        if (addressBooks[activeBookIndex] == null)
        {
            return;
        }

        for (int i = 0; i < contactCount[activeBookIndex]; i++)
        {
            Console.WriteLine(addressBooks[activeBookIndex][i].ToString());
            Console.WriteLine();
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
}