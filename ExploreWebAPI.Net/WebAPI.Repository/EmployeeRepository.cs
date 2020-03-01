using ExpoloreWebAPI.Models;
using System.Collections.Generic;
using System.Linq;
using WebAPI.Interfaces;

namespace WebAPI.Repository
{
   public class EmployeeRepository : IEmployee
    {
        private readonly ExporeWebAPIDbContext _exporeWebAPIDbContext;
        public EmployeeRepository()
        {
            _exporeWebAPIDbContext = new ExporeWebAPIDbContext();
        }
        public void CreateEmployee(Employees employees)
        {
            _exporeWebAPIDbContext.Employees.Add(employees);
            _exporeWebAPIDbContext.SaveChanges();
        }

        public void DeleteEmployee(int employeeId)
        {
           var employee = _exporeWebAPIDbContext.Employees.Where(x => x.EmployeeId == employeeId).FirstOrDefault();
            _exporeWebAPIDbContext.Employees.Remove(employee);
            _exporeWebAPIDbContext.SaveChanges();
        }

        public void EditEmployee(int employeeId, Employees employees)
        {
            var employee = _exporeWebAPIDbContext.Employees.Where(x => x.EmployeeId == employeeId).FirstOrDefault();
            employee.Name = employees.Name;
            employee.Surname = employee.Surname;
            _exporeWebAPIDbContext.SaveChanges();
        }

        public IEnumerable<Employees> GetAllEmployees()
        {
            return _exporeWebAPIDbContext.Employees.ToList();
        }

        public Employees GetEmployeeById(int employeeId)
        {
            return _exporeWebAPIDbContext.Employees.Where(x => x.EmployeeId == employeeId).FirstOrDefault();
        }
    }
}
