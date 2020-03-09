using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Interfaces.Repositories;
using WebAPI.Models;

namespace WebAPI.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly ApplicationDbContext _applicationDbContext;
        public EmployeeRepository()
        {
            _applicationDbContext = new ApplicationDbContext();
        }
        public async Task AddEmployee(Employee employee)
        {
             _applicationDbContext.Employees.Add(employee);
           await _applicationDbContext.SaveChangesAsync();
        }

        public async Task DeleteEmployee(int employeeId)
        {
            var employee =  _applicationDbContext.Employees.FirstOrDefault(x => x.EmployeeId == employeeId);
            _applicationDbContext.Employees.Remove(employee);
            await _applicationDbContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<Employee>> GetAllEmployees()
        {
           return  _applicationDbContext.Employees.ToList();
        }

        public async Task<Employee> GetEmployeeById(int employeeId)
        {
           return await _applicationDbContext.Employees.FindAsync(employeeId);
        }

        public  async Task UpdateEmployee(int employeeId, Employee employee)
        {
            var _employee = await _applicationDbContext.Employees.FindAsync(employeeId);
            _employee.EmployeeName = employee.EmployeeName;
            _employee.EmployeeSurname = employee.EmployeeName;
            _applicationDbContext.SaveChanges();

        }
    }
}
