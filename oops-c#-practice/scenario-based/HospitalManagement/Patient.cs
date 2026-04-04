using System;

public abstract class Patient
{
    private string name;
    private int age;
    private readonly Doctor assignedDoctor;

    public string Name
    {
        get => name;
        set
        {
            if(string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentNullException("Name cannot be Empty");
            }
            name = value;
        }
    }

    public int Age
    {
        get => age;
        set
        {
            if(value <= 0 || value > 120)
            {
                throw new ArgumentException("Age must be between 1 and 120.");
            }
            age = value;
        }
    }

    public Doctor AssignedDoctor => assignedDoctor; // Read Only

    protected Patient(string name, int age, Doctor doctor)
    {
        if (doctor == null)
        {
            throw new ArgumentNullException(nameof(doctor));
        }
        Name = name;
        Age = age;
        assignedDoctor = doctor;
    }

    public virtual void DisplayInfo()
    {
        Console.WriteLine("=== Patient Information ===");
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Age: {Age}");
        Console.WriteLine($"Doctor: {AssignedDoctor.Name} ({AssignedDoctor.Specialization})");
    }

}