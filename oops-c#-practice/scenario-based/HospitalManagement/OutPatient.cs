using System;

public sealed class OutPatient : Patient
{
    private DateTime visitDate;

    public DateTime VisitDate
    {
        get => visitDate;
        set
        {
            if (value > DateTime.Now)
            {
                throw new ArgumentException("Visit date cannot be in the future.");
            }
            visitDate = value;
        }
    }

    public OutPatient(string name, int age, Doctor doctor, DateTime visitDate)
        : base(name, age, doctor)
    {
        VisitDate = visitDate;
    }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Patient Type: Out-Patient");
        Console.WriteLine($"Visit Date: {VisitDate:yyyy-MM-dd}");
    }
}