using ExpoloreWebAPI.Models;
using System.Collections.Generic;
using WebAPI.Interfaces;
using WebAPI.Interfaces.Services;
using WebAPI.Repository;

namespace WebAPI.Services
{
    public class EmployeesService : IEmployeeServices
    {
        private readonly IEmployee _employee;
        public EmployeesService()
        {
            _employee = new EmployeeRepository();
        }
        public void CreateEmployee(Employees employees)
        {
            _employee.CreateEmployee(employees);
        }

        public void DeleteEmployee(int employeeId)
        {
            _employee.DeleteEmployee(employeeId);
        }

        public void EditEmployee(int employeeId, Employees employees)
        {
            _employee.EditEmployee(employeeId, employees);
        }

        public IEnumerable<Employees> GetAllEmployees()
        {
            return _employee.GetAllEmployees();
        }

        public Employees GetEmployeeById(int employeeId)
        {
           return _employee.GetEmployeeById(employeeId);
        }
    }
}
