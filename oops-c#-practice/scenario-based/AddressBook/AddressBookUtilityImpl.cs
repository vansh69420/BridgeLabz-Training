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

        Contact c1 = new Contact();
        c1.SetFirstName("Samay");
        c1.SetLastName("Raina");
        c1.SetAddress("Street 1");
        c1.SetCity("Chandigarh");
        c1.SetState("Punjab");
        c1.SetZip("54000");
        c1.SetPhoneNumber("03001234567");
        c1.SetEmail("samay@gmail.com");
        AddBook(c1);

        Contact c2 = new Contact();
        c2.SetFirstName("Sara");
        c2.SetLastName("David");
        c2.SetAddress("Street 2");
        c2.SetCity("Goa");
        c2.SetState("Goa");
        c2.SetZip("74000");
        c2.SetPhoneNumber("03111234567");
        c2.SetEmail("sara@gmail.com");
        AddBook(c2);

        predefinedLoaded = true;
    }

    public void AddBook(Contact contact)
    {
        if (count >= addressBook.Length)
        {
            return; // address book full -> do nothing
        }

        addressBook[count] = contact;
        count++;
    }

    public Contact CreateContact()
    {
        Contact c = new Contact();

        Console.Write("Enter First Name: ");
        c.SetFirstName(Console.ReadLine());

        Console.Write("Enter Last Name: ");
        c.SetLastName(Console.ReadLine());

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
        for (int i = 0; i < count; i++)
        {
            Console.WriteLine();
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
            return; // not found -> do nothing
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
}