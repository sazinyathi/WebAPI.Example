using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using WebAPI.Interfaces.Services;
using WebAPI.Models;
using WebAPI.Services;

namespace WebAPI.Controllers
{
    public class EmployeesController : ApiController
    {
        private readonly IEmployeeService _employeeService;
        public EmployeesController()
        {
            _employeeService = new EmployeeService();
        }
        // GET: api/Employees
        public async Task<IEnumerable<Employee>> Get()
        {
            return await _employeeService.GetAllEmployees();
        }

        // GET: api/Employees/5
        public async Task<Employee> Get(int id)
        {
            return await _employeeService.GetEmployeeById(id);
        }

        // POST: api/Employees
        public async Task Post([FromBody]Employee employee)
        {
            await _employeeService.AddEmployee(employee);
        }

        // PUT: api/Employees/5
        public async Task Put(int id, [FromBody]Employee employee)
        {
            await _employeeService.UpdateEmployee(id, employee);
        }

        // DELETE: api/Employees/5
        public async Task Delete(int id)
        {
            await _employeeService.DeleteEmployee(id);
        }
    }
}
