using System;
using System.Diagnostics;
public class EmployeeMenu
    {
        private IEmployee EmployeeService = new EmployeeUtilityImpl(); // renamed

        private Employee[] employees;

        public EmployeeMenu()
        {
            // Hardcoded 10 employees
            employees = new Employee[10];
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
        }

        public void ShowMenu()
        {
            foreach (var emp in employees)
            {
                EmployeeService.SetEmployee(emp);
                EmployeeService.CheckAttendance();        
                EmployeeService.CalculateDailyWage();     
            }

            int choice = 0;

            do
            {
                Console.WriteLine("\n==== Employee Wage Menu ====");
                Console.WriteLine("1. Show Attendance Table");
                Console.WriteLine("2. Show Daily Wage Table");
                Console.WriteLine("3. Show Monthly Wage Table");
                Console.WriteLine("4. Exit");
                Console.Write("Enter your choice: ");

                bool isValid = int.TryParse(Console.ReadLine(), out choice);
                if (!isValid)
                {
                    Console.WriteLine("Invalid input! Enter a number.");
                    continue;
                }

                switch (choice)
                {
                    case 1:
                        ShowAttendance();
                        break;

                    case 2:
                        ShowDailyWage();
                        break;

                    case 3:
                        ShowMonthlyWage();
                        break;

                    case 4:
                        Console.WriteLine("Exiting program...");
                        break;

                    default:
                        Console.WriteLine("Invalid choice! Try again.");
                        break;
                }
            } while (choice != 4);
        }


        private Employee CreateEmployee(int id, string name)
        {
            Employee emp = new Employee();
            emp.SetEmployeeId(id);
            emp.SetEmployeeName(name);
            return emp;
        }

        private void PrintHeader()
        {
            Console.WriteLine("----------------------------------------------------------------------------");
            Console.WriteLine($"{"ID",-6} {"Name",-10} {"Present",-10} {"Hours",-8} {"Wage",-8} {"Type",-10} {"MonthlyWage",-12}");
            Console.WriteLine("----------------------------------------------------------------------------");
        }


        private void ShowAttendance()
        {
            PrintHeader();
            foreach (var emp in employees)
            {

                Console.WriteLine($"{emp.GetEmployeeId(),-6} {emp.GetEmployeeName(),-10} {emp.GetAttendance(),-10} {emp.GetWorkingHours(),-8} {emp.GetDailyWage(),-8} {emp.GetWorkType(),-10}");
            }
            Console.WriteLine("--------------------------------------------------------------");
        }

        private void ShowDailyWage()
        {
            PrintHeader();
            foreach (var emp in employees)
            {
                
                Console.WriteLine(emp); 
            }
            Console.WriteLine("--------------------------------------------------------------");
        }

        private void ShowMonthlyWage()
    {
        const int workingDays = 20;
        PrintHeader();
        foreach (var emp in employees)
        {
            double monthlyWage = 0;

            if (emp.GetAttendance()) 
            {
                if (emp.GetWorkType() == "Full Time")
                    monthlyWage = emp.GetWorkingHours() * 20 * workingDays; 
                else if (emp.GetWorkType() == "Part Time")
                    monthlyWage = emp.GetWorkingHours() * 20 * workingDays + emp.GetWorkingHours() * 20 * workingDays; 
            }

            Console.WriteLine($"{emp.GetEmployeeId(),-6} {emp.GetEmployeeName(),-10} {emp.GetAttendance(),-10} {emp.GetWorkingHours(),-8} {emp.GetDailyWage(),-8} {emp.GetWorkType(),-10} {monthlyWage,-10}");
        }
        Console.WriteLine("--------------------------------------------------------------");
    }


}