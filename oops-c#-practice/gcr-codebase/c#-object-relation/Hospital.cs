using System;

class Patient
{
    public string Name;
}

class Doctor
{
    public string Name;

    public void Consult(Patient patient)
    {
        Console.WriteLine($"Dr. {Name} is consulting {patient.Name}");
    }
}

class Program
{
    static void Main()
    {
        Doctor d1 = new Doctor { Name = "Sharma" };
        Doctor d2 = new Doctor { Name = "Mehta" };

        Patient p1 = new Patient { Name = "Rohit" };
        Patient p2 = new Patient { Name = "Ananya" };

        d1.Consult(p1);
        d1.Consult(p2);
        d2.Consult(p1);
    }
}
