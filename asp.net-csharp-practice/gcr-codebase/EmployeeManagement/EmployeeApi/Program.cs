using Microsoft.EntityFrameworkCore;
using RepositoryLayer.Context;
using RepositoryLayer.Interface;
using RepositoryLayer.Service;
using BusinessLayer.Interface;
using BusinessLayer.Service;
using System.Runtime.CompilerServices;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<EmployeeContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("EmployeeDB")));

builder.Services.AddScoped<IAddEmployee, EmployeeService>();
builder.Services.AddScoped<IEmployeeBusiness, EmployeeBusiness>();

builder.Services.AddControllers();

var app = builder.Build();

app.MapControllers();
app.Run();