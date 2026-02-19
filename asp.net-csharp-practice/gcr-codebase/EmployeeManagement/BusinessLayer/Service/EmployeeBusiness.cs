using BusinessLayer.Interface;
using CommonLayer;
using RepositoryLayer.Interface;

namespace BusinessLayer.Service;
public class EmployeeBusiness : IEmployeeBusiness
{
    private readonly IAddEmployee _employeeRepository;
    public EmployeeBusiness(IAddEmployee employeeRepository)
    {
        _employeeRepository = employeeRepository;
    }
    public void AddEmployee(Employee employee)
    {
        _employeeRepository.AddEmployee(employee);
    }
}