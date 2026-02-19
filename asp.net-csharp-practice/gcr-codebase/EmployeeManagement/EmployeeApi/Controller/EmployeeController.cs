using BusinessLayer.Interface;
using CommonLayer;
using Microsoft.AspNetCore.Mvc;

[Route("api/[controller]")]
[ApiController]
public class EmployeeController : ControllerBase
{
    private readonly IEmployeeBusiness _employeeBusiness;

    public EmployeeController(IEmployeeBusiness employeeBusiness)
    {
        _employeeBusiness = employeeBusiness;
    }

    [HttpPost]
    public IActionResult AddEmployee([FromBody] Employee employee)
    {
        _employeeBusiness.AddEmployee(employee);
        return Ok("Employee added successfully");
    }
}
