using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

class AddressBookUtilityImpl : IAddressBook
{
    // COLLECTIONS storage
    private Dictionary<string, List<Contact>> addressBooks = new Dictionary<string, List<Contact>>();
    private string activeBookName = "Default";

    // CSV I/O settings
    private readonly string filePath = "AddressBookData.csv";

    private bool predefinedLoaded = false;

    // For autosave optimization (avoid saving many times during bulk operations)
    private bool suppressAutoSave = false;

    // Simple lock for file I/O safety
    private readonly object ioLock = new object();

    // ------------------ CSV HELPERS ------------------

    private string EscapeCsv(string value)
    {
        if (value == null) return "";

        bool mustQuote = value.Contains(",") || value.Contains("\"") || value.Contains("\n") || value.Contains("\r");
        if (value.Contains("\""))
        {
            value = value.Replace("\"", "\"\"");
        }

        if (mustQuote)
        {
            return "\"" + value + "\"";
        }

        return value;
    }

    private string[] ParseCsvLine(string line)
    {
        // Parses one CSV line supporting quotes and escaped quotes ("")
        List<string> fields = new List<string>();
        StringBuilder field = new StringBuilder();

        bool inQuotes = false;

        for (int i = 0; i < line.Length; i++)
        {
            char ch = line[i];

            if (inQuotes)
            {
                if (ch == '"')
                {
                    if (i + 1 < line.Length && line[i + 1] == '"')
                    {
                        field.Append('"');
                        i++;
                    }
                    else
                    {
                        inQuotes = false;
                    }
                }
                else
                {
                    field.Append(ch);
                }
            }
            else
            {
                if (ch == ',')
                {
                    fields.Add(field.ToString());
                    field.Clear();
                }
                else if (ch == '"')
                {
                    inQuotes = true;
                }
                else
                {
                    field.Append(ch);
                }
            }
        }

        fields.Add(field.ToString());
        return fields.ToArray();
    }

    // ------------------ EXISTING HELPERS ------------------

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

    private void AutoSave()
    {
        if (suppressAutoSave == true)
        {
            return;
        }

        SaveToFile();
    }

    // ------------------ PREDEFINED ------------------

    public void LoadPredefinedContacts()
    {
        if (predefinedLoaded == true)
        {
            return;
        }

        suppressAutoSave = true;

        addressBooks.Clear();

        addressBooks["Default"] = new List<Contact>();
        addressBooks["Family"] = new List<Contact>();
        addressBooks["Office"] = new List<Contact>();

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

        // Reset active book
        activeBookName = "Default";

        predefinedLoaded = true;

        suppressAutoSave = false;

        // Create file initially (because you asked auto load/save)
        SaveToFile();
    }

    // ------------------ I/O METHODS ------------------

    public void LoadFromFile()
    {
        lock (ioLock)
        {
            if (!File.Exists(filePath))
            {
                // If file not found, load predefined and create the CSV file
                LoadPredefinedContacts();
                return;
            }

            string[] lines = File.ReadAllLines(filePath);

            addressBooks.Clear();

            bool headerSkipped = false;

            for (int i = 0; i < lines.Length; i++)
            {
                string line = lines[i];

                if (string.IsNullOrWhiteSpace(line))
                    continue;

                // skip header
                if (headerSkipped == false && line.StartsWith("AddressBookName,"))
                {
                    headerSkipped = true;
                    continue;
                }

                string[] cols = ParseCsvLine(line);

                // Expected: 9 columns
                if (cols.Length < 9)
                    continue;

                string bookName = cols[0];

                if (!addressBooks.ContainsKey(bookName))
                {
                    addressBooks[bookName] = new List<Contact>();
                }

                Contact c = new Contact();
                c.SetFirstName(cols[1]);
                c.SetLastName(cols[2]);
                c.SetAddress(cols[3]);
                c.SetCity(cols[4]);
                c.SetState(cols[5]);
                c.SetZip(cols[6]);
                c.SetPhoneNumber(cols[7]);
                c.SetEmail(cols[8]);

                addressBooks[bookName].Add(c);
            }

            // choose active book
            if (addressBooks.ContainsKey("Default"))
            {
                activeBookName = "Default";
            }
            else
            {
                // if no books exist, fallback to predefined
                if (addressBooks.Count == 0)
                {
                    LoadPredefinedContacts();
                    return;
                }

                foreach (var kv in addressBooks)
                {
                    activeBookName = kv.Key;
                    break;
                }
            }

            predefinedLoaded = true;
        }
    }

    public void SaveToFile()
    {
        lock (ioLock)
        {
            using (StreamWriter sw = new StreamWriter(filePath, false))
            {
                // Header
                sw.WriteLine("AddressBookName,FirstName,LastName,Address,City,State,Zip,PhoneNumber,Email");

                foreach (KeyValuePair<string, List<Contact>> kv in addressBooks)
                {
                    string bookName = kv.Key;
                    List<Contact> list = kv.Value;

                    for (int i = 0; i < list.Count; i++)
                    {
                        Contact c = list[i];

                        string line =
                            EscapeCsv(bookName) + "," +
                            EscapeCsv(c.GetFirstName()) + "," +
                            EscapeCsv(c.GetLastName()) + "," +
                            EscapeCsv(c.GetAddress()) + "," +
                            EscapeCsv(c.GetCity()) + "," +
                            EscapeCsv(c.GetState()) + "," +
                            EscapeCsv(c.GetZip()) + "," +
                            EscapeCsv(c.GetPhoneNumber()) + "," +
                            EscapeCsv(c.GetEmail());

                        sw.WriteLine(line);
                    }
                }
            }
        }
    }

    // ------------------ CORE FEATURES ------------------

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

        AutoSave();
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
                break;

            Console.WriteLine("Invalid input.");
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

                AutoSave();
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
                AutoSave();
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

            Console.WriteLine("Invalid input. Please enter a valid number.");
        }

        suppressAutoSave = true;

        for (int i = 0; i < n; i++)
        {
            Contact c = CreateContact();
            if (c == null)
            {
                suppressAutoSave = false;
                return;
            }

            AddBook(c);
            Console.WriteLine("This contact is added to the Address Book successfully.");
            Console.WriteLine();
        }

        suppressAutoSave = false;
        SaveToFile();
    }

    // ------------------ MULTITHREAD SEARCH/COUNT ------------------

    public void SearchPersonByCity()
    {
        Console.Write("Enter City: ");
        string city = Console.ReadLine();

        // Snapshot into arrays
        int bookCount = addressBooks.Count;
        string[] names = new string[bookCount];
        Contact[][] contacts = new Contact[bookCount][];

        int idx = 0;
        foreach (var kv in addressBooks)
        {
            names[idx] = kv.Key;
            contacts[idx] = kv.Value.ToArray(); // List<T>.ToArray()
            idx++;
        }

        Task<string>[] tasks = new Task<string>[bookCount];

        for (int i = 0; i < bookCount; i++)
        {
            string bookName = names[i];
            Contact[] bookContacts = contacts[i];

            tasks[i] = Task.Run(() =>
            {
                StringBuilder sb = new StringBuilder();

                for (int j = 0; j < bookContacts.Length; j++)
                {
                    if (bookContacts[j] != null && bookContacts[j].GetCity() == city)
                    {
                        sb.AppendLine("Address Book: " + bookName);
                        sb.AppendLine(bookContacts[j].ToString());
                        sb.AppendLine();
                    }
                }

                return sb.ToString();
            });
        }

        Task.WaitAll(tasks);

        bool found = false;
        for (int i = 0; i < tasks.Length; i++)
        {
            string result = tasks[i].Result;
            if (!string.IsNullOrEmpty(result))
            {
                Console.Write(result);
                found = true;
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

        int bookCount = addressBooks.Count;
        string[] names = new string[bookCount];
        Contact[][] contacts = new Contact[bookCount][];

        int idx = 0;
        foreach (var kv in addressBooks)
        {
            names[idx] = kv.Key;
            contacts[idx] = kv.Value.ToArray();
            idx++;
        }

        Task<string>[] tasks = new Task<string>[bookCount];

        for (int i = 0; i < bookCount; i++)
        {
            string bookName = names[i];
            Contact[] bookContacts = contacts[i];

            tasks[i] = Task.Run(() =>
            {
                StringBuilder sb = new StringBuilder();

                for (int j = 0; j < bookContacts.Length; j++)
                {
                    if (bookContacts[j] != null && bookContacts[j].GetState() == state)
                    {
                        sb.AppendLine("Address Book: " + bookName);
                        sb.AppendLine(bookContacts[j].ToString());
                        sb.AppendLine();
                    }
                }

                return sb.ToString();
            });
        }

        Task.WaitAll(tasks);

        bool found = false;
        for (int i = 0; i < tasks.Length; i++)
        {
            string result = tasks[i].Result;
            if (!string.IsNullOrEmpty(result))
            {
                Console.Write(result);
                found = true;
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

        int bookCount = addressBooks.Count;
        Contact[][] contacts = new Contact[bookCount][];

        int idx = 0;
        foreach (var kv in addressBooks)
        {
            contacts[idx] = kv.Value.ToArray();
            idx++;
        }

        Task<int>[] tasks = new Task<int>[bookCount];

        for (int i = 0; i < bookCount; i++)
        {
            Contact[] bookContacts = contacts[i];

            tasks[i] = Task.Run(() =>
            {
                int localCount = 0;
                for (int j = 0; j < bookContacts.Length; j++)
                {
                    if (bookContacts[j] != null && bookContacts[j].GetCity() == city)
                    {
                        localCount++;
                    }
                }
                return localCount;
            });
        }

        Task.WaitAll(tasks);

        int total = 0;
        for (int i = 0; i < tasks.Length; i++)
        {
            total += tasks[i].Result;
        }

        Console.WriteLine("Total contacts in city '" + city + "': " + total);
    }

    public void CountContactsByState()
    {
        Console.Write("Enter State: ");
        string state = Console.ReadLine();

        int bookCount = addressBooks.Count;
        Contact[][] contacts = new Contact[bookCount][];

        int idx = 0;
        foreach (var kv in addressBooks)
        {
            contacts[idx] = kv.Value.ToArray();
            idx++;
        }

        Task<int>[] tasks = new Task<int>[bookCount];

        for (int i = 0; i < bookCount; i++)
        {
            Contact[] bookContacts = contacts[i];

            tasks[i] = Task.Run(() =>
            {
                int localCount = 0;
                for (int j = 0; j < bookContacts.Length; j++)
                {
                    if (bookContacts[j] != null && bookContacts[j].GetState() == state)
                    {
                        localCount++;
                    }
                }
                return localCount;
            });
        }

        Task.WaitAll(tasks);

        int total = 0;
        for (int i = 0; i < tasks.Length; i++)
        {
            total += tasks[i].Result;
        }

        Console.WriteLine("Total contacts in state '" + state + "': " + total);
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

        // Bubble sort (manual)
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
        AutoSave();
    }
}