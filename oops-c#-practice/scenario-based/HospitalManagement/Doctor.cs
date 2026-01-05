using System;

public sealed class Doctor
{
    private string name;
    private string specialization;

    public string Name
    {
        get => name;
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("Name cannot be Empty.");
            }
            name = value;
        }
    }

    public string Specialization
    {
        get => specialization;
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("Specialization cannot be Empty.");
            }
            specialization = value;
        }
    }

    public Doctor(string name, string specialization)
    {
        Name = name;
        Specialization = specialization;
    }
}