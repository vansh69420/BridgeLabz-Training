using System;
public class Employee
{

    private int EmployeeId{get; set;}
    private string EmployeeName{get; set;}

    private bool IsPresent{get; set;}

    private int WorkingHours { get; set; }
    private double DailyWage { get; set; }
    private string WorkType { get; set; }

    public void SetEmployeeID(int id)
    {
        EmployeeId = id;
    }


    public void SetEmployeeName(string name)
    {
        EmployeeName = name;
    }

    public void SetAttendance(bool present)
    {
        IsPresent = present;
    }

    public bool GetAttendance()
    {
            return IsPresent;
    }

    public void SetWorkingHours(int hours)
    {
        WorkingHours = hours;
    }

    public void SetDailyWage(double wage)
    {
        DailyWage = wage;
    }

    public void SetWorkType(string type)
    {
        WorkType = type;
    }

    public override string ToString()
    {

        return $"{EmployeeId,-6} " +
               $"{EmployeeName,-10} " +
               $"{IsPresent,-10} " +
               $"{WorkingHours,-8} " +
               $"{DailyWage,-8} " +
               $"{WorkType,-10}";
    }
}