using System;
using System.Diagnostics;
public sealed class EmployeeMenu
{
    private IEmployee EmployeeService = new EmployeeUtilityImpl();

    public void MainMenu()
    {
        Employee[] employees = new Employee[10];

            employees[0] = CreateEmployee(101, "Rahul");
            employees[1] = CreateEmployee(102, "Aman");
            employees[2] = CreateEmployee(103, "Neha");
            employees[3] = CreateEmployee(104, "Priya");
            employees[4] = CreateEmployee(105, "Vikas");
            employees[5] = CreateEmployee(106, "Anjali");
            employees[6] = CreateEmployee(107, "Rohit");
            employees[7] = CreateEmployee(108, "Pooja");
            employees[8] = CreateEmployee(109, "Karan");
            employees[9] = CreateEmployee(110, "Sneha");
        PrintHeader();
        foreach (Employee emp in employees)
            {
                EmployeeService.SetEmployee(emp);
                EmployeeService.CheckAttendance();
                EmployeeService.CalculateDailyWage();
                Console.WriteLine(emp);
            }

        foreach (Employee emp in employees)
            {
                Console.WriteLine(emp);
            }

        
    }
    private Employee CreateEmployee(int id, string name)
        {
            Employee emp = new Employee();
            emp.SetEmployeeID(id);
            emp.SetEmployeeName(name);
            return emp;
        }

    private void PrintHeader()
{
    Console.WriteLine("--------------------------------------------------------------");
    Console.WriteLine($"{"ID",-6} {"Name",-10} {"Present",-10} {"Hours",-8} {"Wage",-8} {"Type",-10}");
    Console.WriteLine("--------------------------------------------------------------");
}

}