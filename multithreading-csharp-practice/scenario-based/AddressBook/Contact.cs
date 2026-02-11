using System;

public class Contact
{
    private string FirstName;
    private string LastName;
    private string Address;
    private string City;
    private string State;
    private string Zip;
    private string PhoneNumber;
    private string Email;

    // Getter/Setter methods (separately)

    public string GetFirstName()
    {
        return FirstName;
    }
    public void SetFirstName(string firstName) 
    { 
        this.FirstName = firstName; 
    }

    public string GetLastName() 
    { 
        return LastName; 
    }
    public void SetLastName(string lastName) 
    { 
        this.LastName = lastName; 
    }

    public string GetAddress() 
    { 
        return Address; 
    }
    public void SetAddress(string address) 
    { 
        this.Address = address; 
    }

    public string GetCity() 
    { 
        return City; 
    }
    public void SetCity(string city) 
    { 
        this.City = city; 
    }

    public string GetState() 
    { 
        return State; 
    }
    public void SetState(string state) 
    { 
        this.State = state; 
    }

    public string GetZip() 
    { 
        return Zip; 
    }
    public void SetZip(string zip) 
    { 
        this.Zip = zip; 
    }

    public string GetPhoneNumber() 
    { 
        return PhoneNumber; 
    }
    public void SetPhoneNumber(string phoneNumber) 
    { 
        this.PhoneNumber = phoneNumber; 
    }

    public string GetEmail() 
    { 
        return Email; 
    }
    public void SetEmail(string email) 
    { 
        this.Email = email; 
    }

    public override string ToString()
    {
        return "First Name: " + GetFirstName() + "\n"
             + "Last Name: " + GetLastName() + "\n"
             + "Address: " + GetAddress() + "\n"
             + "City: " + GetCity() + "\n"
             + "State: " + GetState() + "\n"
             + "Zip: " + GetZip() + "\n"
             + "Phone Number: " + GetPhoneNumber() + "\n"
             + "Email: " + GetEmail();
    }
}