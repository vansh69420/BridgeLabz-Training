using System;

public class AddressBookUtilityImpl : IAddressBook
{
    private Contact[] addressBook = new Contact[100];
    private int count = 0;

    public void AddBook(Contact contact)
    {
        if (count >= addressBook.Length)
        {
            return; // if full do nothing
        }

        addressBook[count] = contact;
        count++;
    }

    // input logic is here
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

    // display logic is here
    public void DisplayContacts()
    {
        for (int i = 0; i < count; i++)
        {
            Console.WriteLine();
            Console.WriteLine(addressBook[i].ToString());
            Console.WriteLine(); // spacing between contacts
        }
    }
}