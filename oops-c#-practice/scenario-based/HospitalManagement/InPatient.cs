using System;

public sealed class InPatient: Patient
{
    private int roomNumber;
    private int daysAdmitted;

    public int RoomNumber
    {
        get => roomNumber;
        set
        {
            if(value <= 0)
            {
                throw new ArgumentException("Room no. cannot be negative.");
            }
            roomNumber = value;
        }
    }

    public int DaysAdmitted
    {
        get => daysAdmitted;
        set
        {
            if(value < 0)
            {
                throw new ArgumentException("Room no. cannot be negative.");
            }
            daysAdmitted = value;
        }
    }

    public InPatient(string name, int age, Doctor doctor, int roomNumber, int daysAdmitted): base(name, age, doctor)
    {
        RoomNumber = roomNumber;
        DaysAdmitted = daysAdmitted;
    }

    public override void DisplayInfo()
    {
        base.DisplayInfo(); // call base version
        Console.WriteLine($"Patient Type: In-Patient");
        Console.WriteLine($"Room Number: {RoomNumber}");
        Console.WriteLine($"Days Admitted: {DaysAdmitted}");
    }
}