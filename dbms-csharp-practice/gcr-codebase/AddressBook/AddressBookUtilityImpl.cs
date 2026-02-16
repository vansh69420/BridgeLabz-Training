using System;
using System.Data;
using Microsoft.Data.SqlClient;

class AddressBookUtilityImpl : IAddressBook
{
    private string connectionString =
        "Server=127.0.0.1,1433;" +
        "Database=AddressBookDb;" +
        "User Id=sa;" +
        "Password=Vansh@77;" +
        "Encrypt=False;" +
        "TrustServerCertificate=True;";

    // active book same concept as before
    private string activeBookName = "Default";

    private bool predefinedLoaded = false;

    // -------------------- DB HELPERS (simple) --------------------

    private int ExecuteScalarInt(string sql, params SqlParameter[] parameters)
    {
        using SqlConnection con = new SqlConnection(connectionString);
        using SqlCommand cmd = new SqlCommand(sql, con);
        cmd.CommandType = CommandType.Text;

        if (parameters != null)
        {
            for (int i = 0; i < parameters.Length; i++)
                cmd.Parameters.Add(parameters[i]);
        }

        con.Open();
        object result = cmd.ExecuteScalar();
        return Convert.ToInt32(result);
    }

    private void ExecuteStoredProcedure(string spName, params SqlParameter[] parameters)
    {
        using SqlConnection con = new SqlConnection(connectionString);
        using SqlCommand cmd = new SqlCommand(spName, con);
        cmd.CommandType = CommandType.StoredProcedure;

        if (parameters != null)
        {
            for (int i = 0; i < parameters.Length; i++)
                cmd.Parameters.Add(parameters[i]);
        }

        con.Open();
        cmd.ExecuteNonQuery();
    }

    private int ExecuteStoredProcedureScalarInt(string spName, params SqlParameter[] parameters)
    {
        using SqlConnection con = new SqlConnection(connectionString);
        using SqlCommand cmd = new SqlCommand(spName, con);
        cmd.CommandType = CommandType.StoredProcedure;

        if (parameters != null)
        {
            for (int i = 0; i < parameters.Length; i++)
                cmd.Parameters.Add(parameters[i]);
        }

        con.Open();
        object result = cmd.ExecuteScalar();
        return Convert.ToInt32(result);
    }

    private bool AddressBookExists(string name)
    {
        int count = ExecuteScalarInt(
            "SELECT COUNT(*) FROM address_books WHERE name = @name",
            new SqlParameter("@name", name)
        );

        return count > 0;
    }

    private bool IsDuplicatePersonInActiveBook(string firstName, string lastName)
    {
        int count = ExecuteScalarInt(
            "SELECT COUNT(*) " +
            "FROM contacts c " +
            "INNER JOIN address_books b ON b.address_book_id = c.address_book_id " +
            "WHERE b.name = @book AND c.first_name = @fn AND c.last_name = @ln",
            new SqlParameter("@book", activeBookName),
            new SqlParameter("@fn", firstName),
            new SqlParameter("@ln", lastName)
        );

        return count > 0;
    }

    // -------------------- SEEDING (DB) --------------------

    public void LoadPredefinedContacts()
    {
        if (predefinedLoaded == true)
            return;

        // if DB already has address books, do not seed again
        int bookCount = ExecuteScalarInt("SELECT COUNT(*) FROM address_books");
        if (bookCount > 0)
        {
            predefinedLoaded = true;

            // keep active as Default if exists
            if (AddressBookExists("Default"))
                activeBookName = "Default";

            return;
        }

        // Create 3 predefined address books
        ExecuteStoredProcedure("sp_insert_address_book", new SqlParameter("@name", "Default"));
        ExecuteStoredProcedure("sp_insert_address_book", new SqlParameter("@name", "Family"));
        ExecuteStoredProcedure("sp_insert_address_book", new SqlParameter("@name", "Office"));

        // Insert predefined contacts (India-based)
        activeBookName = "Default";
        AddBook(BuildContact("Rahul", "Sharma", "12, MG Road", "Bengaluru", "Karnataka", "560001", "9876543210", "rahul.sharma@gmail.com"));
        AddBook(BuildContact("Priya", "Iyer", "45, T Nagar", "Chennai", "Tamil Nadu", "600017", "9123456780", "priya.iyer@gmail.com"));

        activeBookName = "Family";
        AddBook(BuildContact("Ananya", "Verma", "21, Rajpath", "New Delhi", "Delhi", "110001", "9988776655", "ananya.verma@gmail.com"));

        activeBookName = "Office";
        AddBook(BuildContact("Arjun", "Nair", "8, Bandra West", "Mumbai", "Maharashtra", "400050", "9012345678", "arjun.nair@company.com"));

        activeBookName = "Default";

        predefinedLoaded = true;
    }

    private Contact BuildContact(string fn, string ln, string addr, string city, string state, string zip, string phone, string email)
    {
        Contact c = new Contact();
        c.SetFirstName(fn);
        c.SetLastName(ln);
        c.SetAddress(addr);
        c.SetCity(city);
        c.SetState(state);
        c.SetZip(zip);
        c.SetPhoneNumber(phone);
        c.SetEmail(email);
        return c;
    }

    // -------------------- CORE FEATURES (DB as main storage) --------------------

    public void AddBook(Contact contact)
    {
        if (contact == null)
            return;

        // Stored procedure for INSERT
        // sp_insert_contact returns new_contact_id or 0
        ExecuteStoredProcedureScalarInt(
            "sp_insert_contact",
            new SqlParameter("@address_book_name", activeBookName),
            new SqlParameter("@first_name", contact.GetFirstName()),
            new SqlParameter("@last_name", contact.GetLastName()),
            new SqlParameter("@address", (object)contact.GetAddress() ?? DBNull.Value),
            new SqlParameter("@city", (object)contact.GetCity() ?? DBNull.Value),
            new SqlParameter("@state", (object)contact.GetState() ?? DBNull.Value),
            new SqlParameter("@zip", (object)contact.GetZip() ?? DBNull.Value),
            new SqlParameter("@phone_number", (object)contact.GetPhoneNumber() ?? DBNull.Value),
            new SqlParameter("@email", (object)contact.GetEmail() ?? DBNull.Value)
        );
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
            using SqlConnection con = new SqlConnection(connectionString);
            using SqlCommand cmdBooks = new SqlCommand("SELECT name FROM address_books ORDER BY name", con);

            con.Open();
            using SqlDataReader br = cmdBooks.ExecuteReader();

            while (br.Read())
            {
                string bookName = br.GetString(0);
                Console.WriteLine("Address Book: " + bookName);

                DisplayContactsOfBook(bookName);
                Console.WriteLine();
            }
        }
        else
        {
            Console.Write("Enter Address Book Name: ");
            string bookName = Console.ReadLine();

            if (!AddressBookExists(bookName))
            {
                Console.WriteLine("Address Book not found.");
                return;
            }

            Console.WriteLine("Address Book: " + bookName);
            DisplayContactsOfBook(bookName);
        }
    }

    private void DisplayContactsOfBook(string bookName)
    {
        using SqlConnection con = new SqlConnection(connectionString);
        using SqlCommand cmd = new SqlCommand(
            "SELECT c.first_name, c.last_name, c.address, c.city, c.state, c.zip, c.phone_number, c.email " +
            "FROM contacts c INNER JOIN address_books b ON b.address_book_id = c.address_book_id " +
            "WHERE b.name = @name " +
            "ORDER BY c.first_name, c.last_name", con);

        cmd.Parameters.AddWithValue("@name", bookName);

        con.Open();
        using SqlDataReader r = cmd.ExecuteReader();

        while (r.Read())
        {
            Contact c = new Contact();
            c.SetFirstName(r.GetString(0));
            c.SetLastName(r.GetString(1));
            c.SetAddress(r.IsDBNull(2) ? null : r.GetString(2));
            c.SetCity(r.IsDBNull(3) ? null : r.GetString(3));
            c.SetState(r.IsDBNull(4) ? null : r.GetString(4));
            c.SetZip(r.IsDBNull(5) ? null : r.GetString(5));
            c.SetPhoneNumber(r.IsDBNull(6) ? null : r.GetString(6));
            c.SetEmail(r.IsDBNull(7) ? null : r.GetString(7));

            Console.WriteLine(c.ToString());
            Console.WriteLine();
        }
    }

    public void EditContact()
    {
        Console.Write("Enter First Name to Edit: ");
        string firstName = Console.ReadLine();

        Console.Write("Enter Last Name to Edit: ");
        string lastName = Console.ReadLine();

        // create updated object from input
        Contact updated = new Contact();

        Console.Write("Enter New First Name: ");
        updated.SetFirstName(Console.ReadLine());

        Console.Write("Enter New Last Name: ");
        updated.SetLastName(Console.ReadLine());

        Console.Write("Enter New Address: ");
        updated.SetAddress(Console.ReadLine());

        Console.Write("Enter New City: ");
        updated.SetCity(Console.ReadLine());

        Console.Write("Enter New State: ");
        updated.SetState(Console.ReadLine());

        Console.Write("Enter New Zip: ");
        updated.SetZip(Console.ReadLine());

        Console.Write("Enter New Phone Number: ");
        updated.SetPhoneNumber(Console.ReadLine());

        Console.Write("Enter New Email: ");
        updated.SetEmail(Console.ReadLine());

        // Stored procedure for UPDATE
        ExecuteStoredProcedureScalarInt(
            "sp_update_contact",
            new SqlParameter("@address_book_name", activeBookName),
            new SqlParameter("@first_name", firstName),
            new SqlParameter("@last_name", lastName),
            new SqlParameter("@new_first_name", updated.GetFirstName()),
            new SqlParameter("@new_last_name", updated.GetLastName()),
            new SqlParameter("@new_address", (object)updated.GetAddress() ?? DBNull.Value),
            new SqlParameter("@new_city", (object)updated.GetCity() ?? DBNull.Value),
            new SqlParameter("@new_state", (object)updated.GetState() ?? DBNull.Value),
            new SqlParameter("@new_zip", (object)updated.GetZip() ?? DBNull.Value),
            new SqlParameter("@new_phone_number", (object)updated.GetPhoneNumber() ?? DBNull.Value),
            new SqlParameter("@new_email", (object)updated.GetEmail() ?? DBNull.Value)
        );
    }

    public void DeleteContact()
    {
        Console.Write("Enter First Name to Delete: ");
        string firstName = Console.ReadLine();

        Console.Write("Enter Last Name to Delete: ");
        string lastName = Console.ReadLine();

        // Stored procedure for DELETE
        ExecuteStoredProcedureScalarInt(
            "sp_delete_contact",
            new SqlParameter("@address_book_name", activeBookName),
            new SqlParameter("@first_name", firstName),
            new SqlParameter("@last_name", lastName)
        );
    }

    public void AddMultipleContacts()
    {
        string bookName;

        while (true)
        {
            Console.Write("Enter Address Book Name (must be unique): ");
            bookName = Console.ReadLine();

            if (AddressBookExists(bookName))
            {
                Console.WriteLine("Address Book name already exists. Please enter a unique name.");
            }
            else
            {
                break;
            }
        }

        // create address book using stored procedure
        ExecuteStoredProcedure("sp_insert_address_book", new SqlParameter("@name", bookName));

        activeBookName = bookName;

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
                return; // duplicate -> back to menu

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

        using SqlConnection con = new SqlConnection(connectionString);
        using SqlCommand cmd = new SqlCommand(
            "SELECT b.name, c.first_name, c.last_name, c.address, c.city, c.state, c.zip, c.phone_number, c.email " +
            "FROM contacts c INNER JOIN address_books b ON b.address_book_id = c.address_book_id " +
            "WHERE c.city = @city " +
            "ORDER BY b.name, c.first_name, c.last_name", con);

        cmd.Parameters.AddWithValue("@city", city);

        con.Open();
        using SqlDataReader r = cmd.ExecuteReader();

        while (r.Read())
        {
            string bookName = r.GetString(0);

            Contact c = new Contact();
            c.SetFirstName(r.GetString(1));
            c.SetLastName(r.GetString(2));
            c.SetAddress(r.IsDBNull(3) ? null : r.GetString(3));
            c.SetCity(r.IsDBNull(4) ? null : r.GetString(4));
            c.SetState(r.IsDBNull(5) ? null : r.GetString(5));
            c.SetZip(r.IsDBNull(6) ? null : r.GetString(6));
            c.SetPhoneNumber(r.IsDBNull(7) ? null : r.GetString(7));
            c.SetEmail(r.IsDBNull(8) ? null : r.GetString(8));

            Console.WriteLine("Address Book: " + bookName);
            Console.WriteLine(c.ToString());
            Console.WriteLine();

            found = true;
        }

        if (found == false)
            Console.WriteLine("No contact found in this city.");
    }

    public void SearchPersonByState()
    {
        Console.Write("Enter State: ");
        string state = Console.ReadLine();

        bool found = false;

        using SqlConnection con = new SqlConnection(connectionString);
        using SqlCommand cmd = new SqlCommand(
            "SELECT b.name, c.first_name, c.last_name, c.address, c.city, c.state, c.zip, c.phone_number, c.email " +
            "FROM contacts c INNER JOIN address_books b ON b.address_book_id = c.address_book_id " +
            "WHERE c.state = @state " +
            "ORDER BY b.name, c.first_name, c.last_name", con);

        cmd.Parameters.AddWithValue("@state", state);

        con.Open();
        using SqlDataReader r = cmd.ExecuteReader();

        while (r.Read())
        {
            string bookName = r.GetString(0);

            Contact c = new Contact();
            c.SetFirstName(r.GetString(1));
            c.SetLastName(r.GetString(2));
            c.SetAddress(r.IsDBNull(3) ? null : r.GetString(3));
            c.SetCity(r.IsDBNull(4) ? null : r.GetString(4));
            c.SetState(r.IsDBNull(5) ? null : r.GetString(5));
            c.SetZip(r.IsDBNull(6) ? null : r.GetString(6));
            c.SetPhoneNumber(r.IsDBNull(7) ? null : r.GetString(7));
            c.SetEmail(r.IsDBNull(8) ? null : r.GetString(8));

            Console.WriteLine("Address Book: " + bookName);
            Console.WriteLine(c.ToString());
            Console.WriteLine();

            found = true;
        }

        if (found == false)
            Console.WriteLine("No contact found in this state.");
    }

    public void CountContactsByCity()
    {
        Console.Write("Enter City: ");
        string city = Console.ReadLine();

        int count = ExecuteScalarInt(
            "SELECT COUNT(*) FROM contacts WHERE city = @city",
            new SqlParameter("@city", city)
        );

        Console.WriteLine("Total contacts in city '" + city + "': " + count);
    }

    public void CountContactsByState()
    {
        Console.Write("Enter State: ");
        string state = Console.ReadLine();

        int count = ExecuteScalarInt(
            "SELECT COUNT(*) FROM contacts WHERE state = @state",
            new SqlParameter("@state", state)
        );

        Console.WriteLine("Total contacts in state '" + state + "': " + count);
    }

    public void SortContactsByName()
    {
        Console.Write("Enter Address Book Name to Sort: ");
        string bookName = Console.ReadLine();

        if (!AddressBookExists(bookName))
        {
            Console.WriteLine("Address Book not found.");
            return;
        }

        // Sorting is done by SQL ORDER BY (alphabetical view)
        Console.WriteLine("Address Book: " + bookName);
        DisplayContactsOfBook(bookName);

        Console.WriteLine("Contacts sorted alphabetically by Person's name.");
    }
}