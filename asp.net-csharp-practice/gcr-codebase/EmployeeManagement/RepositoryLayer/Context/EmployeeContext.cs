using Microsoft.EntityFrameworkCore;
using CommonLayer;
namespace RepositoryLayer.Context;

public class EmployeeContext : DbContext
{
    public EmployeeContext(DbContextOptions<EmployeeContext> options) : base(options){ }

    public DbSet<Employee> Employee {get; set;}
}