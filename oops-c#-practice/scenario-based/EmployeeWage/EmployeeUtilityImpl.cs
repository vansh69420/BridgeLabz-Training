using System;
class EmployeeUtilityImpl : IEmployee
{
    private Employee Employee;
    
    public void SetEmployee(Employee employee)
    {
        Employee = employee;
    }
    public void MarkPresent()
    {
        Employee.SetAttendance(true);
    }

    public void MarkAbsent()
    {
        Employee.SetAttendance(false);
    }
}