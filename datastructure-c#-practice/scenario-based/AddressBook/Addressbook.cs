using System;
public class AddressBook
{
    private string name;
    private UniversalLinkedList contacts = new UniversalLinkedList();

    public string GetName()
    {
        return name;
    }
    public void SetName(string name)
    {
        this.name = name;
    }

    public UniversalLinkedList GetContacts()
    {
        return contacts;
    }
}