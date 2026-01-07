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
        int attendance = random.Next(0, 2);

        if (attendance == 1)
            Employee.SetAttendance(true);
        else
            Employee.SetAttendance(false);
    }

    public void CalculateDailyWage()
    {
        const int WAGE_PER_HOUR = 20;
        const int FULL_TIME_HOURS = 8;

        if (!Employee.GetAttendance())
        {
            Employee.SetWorkingHours(0);
            Employee.SetDailyWage(0);
            Employee.SetWorkType("Absent");
            return;
        }

        Random random = new Random();
        int workType = random.Next(0, 2);

        if (workType == 0)
        {

            Employee.SetWorkType("Full Time");
            Employee.SetWorkingHours(FULL_TIME_HOURS);
            Employee.SetDailyWage(FULL_TIME_HOURS * WAGE_PER_HOUR);
        }
        else
        {

            int partTimeHours = random.Next(1, 8); 

            Employee.SetWorkType("Part Time");
            Employee.SetWorkingHours(partTimeHours);
            Employee.SetDailyWage(partTimeHours * WAGE_PER_HOUR + FULL_TIME_HOURS * WAGE_PER_HOUR);
        }
    }

    

}