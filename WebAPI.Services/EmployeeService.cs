using System.Collections.Generic;
using System.Threading.Tasks;
using WebAPI.Interfaces.Repositories;
using WebAPI.Interfaces.Services;
using WebAPI.Models;
using WebAPI.Repositories;

namespace WebAPI.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepository _employeeRepository;
        public EmployeeService()
        {
            _employeeRepository = new EmployeeRepository();
        }
        public async Task AddEmployee(Employee employee)
        {
           await _employeeRepository.AddEmployee(employee);
        }

        public async Task DeleteEmployee(int employeeId)
        {
            await _employeeRepository.DeleteEmployee(employeeId);
        }
    
        public async Task<IEnumerable<Employee>> GetAllEmployees()
        {
            return await _employeeRepository.GetAllEmployees();
        }

        public async Task<Employee> GetEmployeeById(int employeeId)
        {
            return await _employeeRepository.GetEmployeeById(employeeId);
        }

        public async Task UpdateEmployee(int employeeId, WebAPI.Models.Employee employee)
        {
            await _employeeRepository.UpdateEmployee(employeeId, employee);
        }
    }
}
