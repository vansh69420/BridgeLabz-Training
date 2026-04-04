using System;

class Patient
{
    public static string HospitalName = "City Hospital";
    private static int totalPatients = 0;

    public readonly int PatientID;
    public string Name;
    public int Age;
    public string Ailment;

    public Patient(int id, string name, int age, string ailment)
    {
        this.PatientID = id;
        this.Name = name;
        this.Age = age;
        this.Ailment = ailment;
        totalPatients++;
    }

    public static void GetTotalPatients()
    {
        Console.WriteLine("Total Patients: " + totalPatients);
    }

    public void Display(object obj)
    {
        if (obj is Patient)
        {
            Console.WriteLine($"{Name}, Age: {Age}, Ailment: {Ailment}");
        }
    }
}

class Program
{
    static void Main()
    {
        Patient p = new Patient(1, "Vansh", 45, "Fever");
        p.Display(p);
        Patient.GetTotalPatients();
    }
}
