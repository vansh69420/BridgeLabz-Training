using System;

public class Program
{
    public static void Main()
    {
        // Create doctors
        Doctor drSmith = new Doctor("Dr. Sarah Smith", "Cardiology");
        Doctor drJones = new Doctor("Dr. Mark Jones", "General");

        // Create patients (demonstrating Inheritance + Polymorphism)
        Patient inPatient = new InPatient("Alice Johnson", 28, drSmith, roomNumber: 305, daysAdmitted: 5);
        Patient outPatient = new OutPatient("Bob Chen", 45, drJones, visitDate: DateTime.Now);

        // Polymorphism: same method call, different behavior
        inPatient.DisplayInfo();
        Console.WriteLine();
        outPatient.DisplayInfo();
        Console.WriteLine();

        // Create bills (demonstrating Abstraction via IPayable interface)
        IPayable inPatientBill = new Bill("B001", inPatient, 15000.00m);
        IPayable outPatientBill = new Bill("B002", outPatient, 2500.00m);

        // Process payments through the interface
        inPatientBill.ProcessPayment();
        outPatientBill.ProcessPayment();

        Console.WriteLine();
        inPatientBill.PrintReceipt();
        Console.WriteLine();
        outPatientBill.PrintReceipt();
    }
}