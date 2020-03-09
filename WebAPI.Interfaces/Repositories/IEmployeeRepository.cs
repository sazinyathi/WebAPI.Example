using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAPI.Models;

namespace WebAPI.Interfaces.Repositories
{
    public interface IEmployeeRepository
    {
        Task AddEmployee(Employee employee);
        Task UpdateEmployee(int employeeId, Employee employee);
        Task DeleteEmployee(int employeeId);
        Task<Employee> GetEmployeeById(int employeeId);
        Task<IEnumerable<Employee>> GetAllEmployees();
    }
}
