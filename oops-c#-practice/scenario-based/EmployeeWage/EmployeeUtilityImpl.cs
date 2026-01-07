using System;
class EmployeeUtilityImpl : IEmployee
{
    private Employee Employee;

    private const int WAGE_PER_HOUR = 20;
    private const int FULL_TIME_HOURS = 8;
    
    public void SetEmployee(Employee employee)
    {
        Employee = employee;
    }
    public void CheckAttendance()
    {
        Random random = new Random();
        int attendance = random.Next(0, 2); // 0 or 1

        if (attendance == 1)
            Employee.SetAttendance(true);
        else
            Employee.SetAttendance(false);
    }

    public void CalculateDailyWage()
        {
            Random random = new Random();
            int empType = random.Next(0, 3); 

            int workingHours = 0;

            if (empType == 1)
            {
                workingHours = FULL_TIME_HOURS;
            }
            else if (empType == 2)
            {
                workingHours = random.Next(1, FULL_TIME_HOURS);
            }

            Employee.SetWorkingHours(workingHours);
            Employee.SetDailyWage(workingHours * WAGE_PER_HOUR);
        }
}