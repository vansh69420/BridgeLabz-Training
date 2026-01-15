using System;
public interface IAddressBook
{
    void LoadPredefinedContacts();
    void AddBook(Contact contact);
    void DisplayContacts();
    void EditContact();
    void DeleteContact();
    void AddMultipleContacts();
    void SearchPersonByCity();
    void SearchPersonByState();
    void CountContactsByCity();
    void CountContactsByState();
    void SortContactsByName();
}