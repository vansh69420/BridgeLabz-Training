using System;
using System.Diagnostics;
public sealed class EmployeeMenu
{
    private IEmployee EmployeeService = new EmployeeUtilityImpl();

    public void ShowAttendanceMenu()
    {
        Employee employee = new Employee();

        Console.WriteLine("Enter Employee ID: ");
        employee.SetEmployeeID(int.Parse(Console.ReadLine()));

        Console.Write("Enter Employee Name: ");
        employee.SetEmployeeName(Console.ReadLine());

        EmployeeService.SetEmployee(employee);

        Console.WriteLine("\n1. Mark Present");
        Console.WriteLine("2. Mark Absent");
        Console.Write("Choose option: ");

        int choice = Convert.ToInt32(Console.ReadLine());

        switch(choice)
        {
            case 1:
                EmployeeService.MarkPresent();
                break;
            case 2:
                EmployeeService.MarkAbsent();
                break;
            default:
                Console.WriteLine("Invalid Choice.");
                break;
        }

        Console.WriteLine("\nEmployee Details:");
        Console.WriteLine(employee);
    }

    public void MainMenu()
    {
        Console.WriteLine("Employee App");
        Console.WriteLine("1.Take Attendance");

        int choice = Convert.ToInt32(Console.ReadLine());

        switch(choice)
        {
            case 1:
                ShowAttendanceMenu();
                break;
            default:
                Console.WriteLine("Invalid Choice.");
                break;
        }
    }

}