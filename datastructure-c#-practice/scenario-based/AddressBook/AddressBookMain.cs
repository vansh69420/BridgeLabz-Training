using System;
public class AddressBookMain
{
    public static void Main()
    {
        Console.WriteLine("Welcome to the Address Book System");

        AddressBookMenu menu = new AddressBookMenu();
        menu.Start();
    }
}