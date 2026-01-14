using System;

class AddressBookUtilityImpl : IAddressBook
{
    private Contact[] addressBook = new Contact[100];
    private int count = 0;

    private bool predefinedLoaded = false;

    public void LoadPredefinedContacts()
{
    if (predefinedLoaded == true)
    {
        return;
    }

    // Predefined Contact 1
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

    // Predefined Contact 2 
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
        if (count >= addressBook.Length)
        {
            return;
        }

        addressBook[count] = contact;
        count++;
    }

    public Contact CreateContact()
    {
        Contact c = new Contact();

        Console.Write("Enter First Name: ");
        string firstName = Console.ReadLine();
        c.SetFirstName(firstName);

        Console.Write("Enter Last Name: ");
        string lastName = Console.ReadLine();
        c.SetLastName(lastName);

        // Check duplicate right after full name
        if (IsNameAlreadyPresent(firstName, lastName))
        {
            Console.WriteLine("This contact is already in the Address Book");
            return null;
        }

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

    private bool IsNameAlreadyPresent(string firstName, string lastName)
    {
        for (int i = 0; i < count; i++)
        {
            if (addressBook[i] != null &&
                addressBook[i].GetFirstName() == firstName &&
                addressBook[i].GetLastName() == lastName)
            {
                return true;
            }
        }
        return false;
    }

    public void DisplayContacts()
    {
        for (int i = 0; i < count; i++)
        {
            Console.WriteLine(addressBook[i].ToString());
            Console.WriteLine();
        }
    }

    public void EditContact()
    {
        Console.Write("Enter First Name to Edit: ");
        string firstName = Console.ReadLine();

        Console.Write("Enter Last Name to Edit: ");
        string lastName = Console.ReadLine();

        int index = -1;

        for (int i = 0; i < count; i++)
        {
            if (addressBook[i].GetFirstName() == firstName &&
                addressBook[i].GetLastName() == lastName)
            {
                index = i;
                break;
            }
        }

        if (index == -1)
        {
            Console.WriteLine("Contact not Found");
            return;
        }

        Console.Write("Enter New First Name: ");
        addressBook[index].SetFirstName(Console.ReadLine());

        Console.Write("Enter New Last Name: ");
        addressBook[index].SetLastName(Console.ReadLine());

        Console.Write("Enter New Address: ");
        addressBook[index].SetAddress(Console.ReadLine());

        Console.Write("Enter New City: ");
        addressBook[index].SetCity(Console.ReadLine());

        Console.Write("Enter New State: ");
        addressBook[index].SetState(Console.ReadLine());

        Console.Write("Enter New Zip: ");
        addressBook[index].SetZip(Console.ReadLine());

        Console.Write("Enter New Phone Number: ");
        addressBook[index].SetPhoneNumber(Console.ReadLine());

        Console.Write("Enter New Email: ");
        addressBook[index].SetEmail(Console.ReadLine());
    }

    // Version 4: Delete by name (First Name + Last Name)
    public void DeleteContact()
    {
        Console.Write("Enter First Name to Delete: ");
        string firstName = Console.ReadLine();

        Console.Write("Enter Last Name to Delete: ");
        string lastName = Console.ReadLine();

        int index = -1;

        for (int i = 0; i < count; i++)
        {
            if (addressBook[i].GetFirstName() == firstName &&
                addressBook[i].GetLastName() == lastName)
            {
                index = i;
                break;
            }
        }

        if (index == -1)
        {
            Console.WriteLine("Name not Found");
            return;
        }

        // shift left to remove the contact
        for (int i = index; i < count - 1; i++)
        {
            addressBook[i] = addressBook[i + 1];
        }

        addressBook[count - 1] = null;
        count--;
    }

    public void AddMultipleContacts()
    {
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
            AddBook(CreateContact());
            Console.WriteLine("This contact is added to the Address Book successfully.");
            Console.WriteLine();
        }
    }
}