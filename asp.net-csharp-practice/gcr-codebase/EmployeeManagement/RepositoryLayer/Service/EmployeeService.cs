using CommonLayer;
using RepositoryLayer.Context;
using RepositoryLayer.Interface;
namespace RepositoryLayer.Service;
public class EmployeeService : IAddEmployee
{
    private readonly EmployeeContext _context;
    public EmployeeService(EmployeeContext context)
    {
        _context = context;
    }
    public void AddEmployee(Employee employee)
    {
        _context.Employee.Add(employee);
        _context.SaveChanges();
    }
}