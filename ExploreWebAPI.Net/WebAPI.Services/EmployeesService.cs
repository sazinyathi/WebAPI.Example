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
        public async Task CreateEmployee(Employees employees)
        {
           await _employee.CreateEmployee(employees);
        }

        public async Task DeleteEmployee(int employeeId)
        {
            await _employee.DeleteEmployee(employeeId);
        }

        public async Task EditEmployee(int employeeId, Employees employees)
        {
            await _employee.EditEmployee(employeeId, employees);
        }

        public async Task<IEnumerable<Employees>> GetAllEmployees()
        {
            return await _employee.GetAllEmployees();
        }

        public async Task<Employees> GetEmployeeById(int employeeId)
        {
           return await _employee.GetEmployeeById(employeeId);
        }
    }
}
