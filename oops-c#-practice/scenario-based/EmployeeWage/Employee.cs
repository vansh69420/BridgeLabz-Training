using System;
public class Employee
{

    private int EmployeeId{get; set;}
    private string EmployeeName{get; set;}

    private bool IsPresent{get; set;}

    private int WorkingHours { get; set; }
    private double DailyWage { get; set; }
    private string WorkType { get; set; }

    private int TotalWorkingDays { get; set; }
    private int TotalWorkingHours { get; set; }
    private int MonthlyWage { get; set; }

    public void SetEmployeeId(int id)
    {
        EmployeeId = id;
    }
    public int GetEmployeeId()
    {
        return EmployeeId;
    }


    public void SetEmployeeName(string name)
    {
        EmployeeName = name;
    }
    public string GetEmployeeName()
    {
        return EmployeeName;
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
    public int GetWorkingHours()
    {
        return WorkingHours;
    }

    public void SetDailyWage(double wage)
    {
        DailyWage = wage;
    }
    public double GetDailyWage()
    {
        return DailyWage;
    }

    public void SetWorkType(string type)
    {
        WorkType = type;
    }
    public string GetWorkType()
    {
        return WorkType;
    }

    public void SetTotalWorkingDays(int days)
    {
        TotalWorkingDays = days;
    }

    public void SetTotalWorkingHours(int hours)
    {
        TotalWorkingHours = hours;
    }

    public void SetMonthlyWage(int wage)
    {
        MonthlyWage = wage;
    }

    public int GetTotalWorkingDays()
    {
        return TotalWorkingDays;
    }

    public int GetTotalWorkingHours()
    {
        return TotalWorkingHours;
    }

    public int GetMonthlyWage()
    {
        return MonthlyWage;
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